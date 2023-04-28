using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TurnBased_Fighting_Game
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =LeaderBoard.mdb;";
        private OleDbConnection myConnection;

        List<string[]> dates = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }

        public bool CheckSignText(TextBox textBox)
        {
            return textBox.Text.Length >= 3;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            string query = $"SELECT Leader FROM LeaderBoard";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            bool sign = true;

            if (CheckSignText(name))
            {
                while (reader.Read())
                {
                    if (reader[0].ToString() == name.Text)
                    {
                        errorProvider1.SetError(name, "Имя занято");
                        if (NameOccupied())
                        {
                            query = $"UPDATE LeaderBoard Set Points = 0 WHERE Leader = '{name.Text}'";
                            //Передать в форму драки имя игрока и свернуть форму
                            Hide();
                        }
                        sign = false;
                    }
                }

                reader.Close();
                command.CommandText = query;
                command.ExecuteNonQuery();
                if (sign)
                {
                    errorProvider1.Clear();
                    query = $"INSERT INTO LeaderBoard(Leader) Values('{name.Text}')";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    // передать имя игрока и свернуть форму
                }
            }
        }
        public bool NameOccupied()
        {
            DialogResult result = MessageBox.Show("Имя персонажа занято. Хотите сбросить очки и начать с этим именем?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public void LoadPoints(int points, string name)
        {
            string query = $"UPDATE LeaderBoard Set Points = {points} WHERE Leader = '{name}'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        public void LoadBoard() // передать в метод форму с таблицей лидеров
        {
            string query = "SELECT Leader, Points FROM LeaderBoard ORDER BY Points DESC";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            int counter = 1;
            while (reader.Read())
            {
                dates.Add(new string[3]);
                dates[dates.Count - 1][0] = counter.ToString();
                dates[dates.Count - 1][1] = reader[0].ToString();
                dates[dates.Count - 1][2] = reader[1].ToString();
                counter++;
            }
            reader.Close();
            myConnection.Close();
            //foreach (string[] s in dates)
                //board.table.Rows.Add(s);
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Sign_Click(sender, e);
            }
        }
    }
}
