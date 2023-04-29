using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBased_Fighting_Game
{
    public partial class Fight : Form
    {
        public string nameOfPlayer;
        public int counterOfSteps = 1;
        public int totalpoints = 0;

        public bool attack = true;
        public bool block = false;
        public bool alive = true;
        string stopper;

        Random random = new Random();
        public int randNum;

        string[] AIblockDirection = { "Head", "Body", "Feet" };
        int[] AIDamage = new int[3];

        public Fight()
        {
            InitializeComponent();
            AIDamage[0] = 9;
            AIDamage[1] = 15;
            AIDamage[2] = 12;
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            playerName.Text = nameOfPlayer;
            timeOfFight.Text = "15";
            VisibleAttack(false);
            VisibleBlock(false);
            if (random.Next(0, 2) == 0)
            {
                block = false;
                attack = true;
            }
            else
            {
                block = true;
                attack = false;
            }
        }

        public void HistoryOfFight(string text)
        {
            if (history.Items.Count % 3 == 0)
            {
                history.Items.Insert(0, "--------------------------- Ход: " + counterOfSteps);
                counterOfSteps++;
            }
            history.Items.Insert(0, text);
        }

        public DialogResult SendMessage(string winner)
        {
            DialogResult result;
            result = MessageBox.Show($"Ура {winner} победил",
                    "Winner", MessageBoxButtons.OK);
            totalpoints = 200 + (playerHealth.Value * 20) + (AIHealth.Value * 3);
            HistoryOfFight($"{nameOfPlayer}! Ваши очки: {totalpoints}");
            return result;
        }
        public void WinnerIs()
        {
            DialogResult result;
            Form1 form1 = new Form1();
            timer1.Stop();
            if (playerHealth.Value > AIHealth.Value)
            {
                AIHealth.Value = 0;
                result = SendMessage(nameOfPlayer);
            }
            else
            {
                playerHealth.Value = 0;
                result = SendMessage("AI");
            }
            form1.LoadPoints(totalpoints, nameOfPlayer);
            VisibleAttack(false);
            VisibleBlock(false);
        }
        public int HealthControl(int current, int value)
        {
            if (current - value > 0)
            {
                alive = true;
                return current - value;
            }
            alive = false;
            WinnerIs();
            return 0;
        }

        public int Attacking(ProgressBar health, string damageText, string attack, string block)
        {
            int damage = DetermineDamage(damageText);
            if (RandomCriticalDamage())
                damage += 3;

            damage = Blocking(damage, block, attack);

            int totalHealth = HealthControl(health.Value, damage);
            totalpoints += AIHealth.Value - totalHealth;
            if (alive)
                HistoryOfFight($"{nameOfPlayer} нанес {health.Value - totalHealth} урона");
            return totalHealth;
        }

        private int DetermineDamage(string textButton)
        {
            switch (textButton)
            {
                case "Head":
                    return 11;
                case "Body":
                    return 13;
                default: return 9;
            }

        }

        public int Blocking(int damage, string block, string attack)
        {
            double percentage = (double)random.Next(70, 101) / 100;
            if (block == attack && alive)
                HistoryOfFight($"Было заблокировано {Math.Ceiling(damage * percentage)}");
            else if (alive)
                HistoryOfFight($"Удар прошел через блок");
            return block == attack ? Convert.ToInt32(damage - Math.Ceiling(damage * percentage)) : damage;
        }

        public bool RandomCriticalDamage()
        {
            return random.Next(0, 101) > 70;
        }

        public int AiAttacking(ProgressBar health, string block)
        {
            randNum = random.Next(0, 3);
            int damage = AIDamage[randNum];
            if (RandomCriticalDamage())
                damage += 2;

            damage = Blocking(damage, block, AIblockDirection[randNum]);

            int totalHealth = HealthControl(health.Value, damage);
            if (alive)
                HistoryOfFight($"ИИ нанес {health.Value - totalHealth} урона");
            return totalHealth;
        }

        private void Fight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeOfFight.Text = (int.Parse(timeOfFight.Text) - 1).ToString();
            if (int.Parse(timeOfFight.Text) == 0)
            {
                playerHealth.Value = AiAttacking(playerHealth, " ");
                NextStep();
            }
        }
        public void SwapStep()
        {
            attack = !attack;
            block = !block;
        }

        public void SwapTextStep()
        {
            timeOfFight.Text = "15";
        }

        public void NextStep()
        {
            if (alive)
            {
                step.Text = (int.Parse(step.Text) + 1).ToString();
                SwapStep();
                VisibleAttack(attack);
                VisibleBlock(block);

                SwapTextStep();
            }
        }
        public void CanBeatAllButtons()
        {
            headAttack.Enabled = CanBeat(headAttack);
            bodyAttack.Enabled = CanBeat(bodyAttack);
            feetAttack.Enabled = CanBeat(feetAttack);
        }

        private void VisibleAttack(bool trueFalse)
        {
            headAttack.Enabled = trueFalse;
            bodyAttack.Enabled = trueFalse;
            feetAttack.Enabled = trueFalse;
            if (trueFalse)
                CanBeatAllButtons();
        }
        private void VisibleBlock(bool trueFalse)
        {
            headBlock.Enabled = trueFalse;
            bodyBlock.Enabled = trueFalse;
            feetBlock.Enabled = trueFalse;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            VisibleBlock(block);
            VisibleAttack(attack);
            timer1.Start();
            startPicture.Enabled = false;
            startPicture.Visible = false;
        }
        private void ChangeFocus(object sender, EventArgs e)
        {
            headBlock.Focus();
        }

        public bool CanBeat(Button button)
        {
            return stopper != button.Text;
        }

        public void PlayerAttack(object sender, EventArgs e)
        {
            Button button = sender as Button;
            AIHealth.Value = Attacking(AIHealth, button.Text, button.Text, AIblockDirection[random.Next(0, 3)]);
            stopper = button.Text;
            NextStep();
        }

        public void PlayerBlock(object sender, EventArgs e)
        {
            Button button = sender as Button;
            playerHealth.Value = AiAttacking(playerHealth, button.Text);
            NextStep();
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

    }
}
