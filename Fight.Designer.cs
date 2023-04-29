namespace TurnBased_Fighting_Game
{
    partial class Fight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.AIHealth = new System.Windows.Forms.ProgressBar();
            this.playerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.timeOfFight = new System.Windows.Forms.Label();
            this.AIImage = new System.Windows.Forms.PictureBox();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.feetBlock = new System.Windows.Forms.Button();
            this.bodyBlock = new System.Windows.Forms.Button();
            this.headBlock = new System.Windows.Forms.Button();
            this.feetAttack = new System.Windows.Forms.Button();
            this.bodyAttack = new System.Windows.Forms.Button();
            this.headAttack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startPicture = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AIImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(33, 55);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playerHealth.RightToLeftLayout = true;
            this.playerHealth.Size = new System.Drawing.Size(288, 36);
            this.playerHealth.TabIndex = 3;
            this.playerHealth.Value = 100;
            // 
            // AIHealth
            // 
            this.AIHealth.Location = new System.Drawing.Point(371, 55);
            this.AIHealth.Name = "AIHealth";
            this.AIHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AIHealth.RightToLeftLayout = true;
            this.AIHealth.Size = new System.Drawing.Size(288, 36);
            this.AIHealth.TabIndex = 4;
            this.AIHealth.Value = 100;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.playerName.Location = new System.Drawing.Point(35, 21);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(73, 31);
            this.playerName.TabIndex = 5;
            this.playerName.Text = "label1";
            this.playerName.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(535, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer";
            this.label2.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.Black;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.history.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 18;
            this.history.Location = new System.Drawing.Point(212, 180);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history.Size = new System.Drawing.Size(268, 182);
            this.history.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(279, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ход:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.BackColor = System.Drawing.Color.Transparent;
            this.step.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.step.Location = new System.Drawing.Point(365, 97);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(28, 36);
            this.step.TabIndex = 9;
            this.step.Text = "1";
            this.step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.step.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // timeOfFight
            // 
            this.timeOfFight.AutoSize = true;
            this.timeOfFight.BackColor = System.Drawing.Color.Transparent;
            this.timeOfFight.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeOfFight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.timeOfFight.Location = new System.Drawing.Point(312, 132);
            this.timeOfFight.Name = "timeOfFight";
            this.timeOfFight.Size = new System.Drawing.Size(0, 36);
            this.timeOfFight.TabIndex = 11;
            this.timeOfFight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AIImage
            // 
            this.AIImage.BackColor = System.Drawing.Color.Transparent;
            this.AIImage.Location = new System.Drawing.Point(486, 96);
            this.AIImage.Name = "AIImage";
            this.AIImage.Size = new System.Drawing.Size(173, 266);
            this.AIImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AIImage.TabIndex = 12;
            this.AIImage.TabStop = false;
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.Location = new System.Drawing.Point(33, 97);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(173, 266);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 13;
            this.playerImage.TabStop = false;
            // 
            // feetBlock
            // 
            this.feetBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.feetBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feetBlock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.feetBlock.FlatAppearance.BorderSize = 2;
            this.feetBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feetBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.feetBlock.Location = new System.Drawing.Point(137, 491);
            this.feetBlock.Name = "feetBlock";
            this.feetBlock.Size = new System.Drawing.Size(103, 38);
            this.feetBlock.TabIndex = 19;
            this.feetBlock.Text = "Feet";
            this.feetBlock.UseVisualStyleBackColor = false;
            this.feetBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // bodyBlock
            // 
            this.bodyBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bodyBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyBlock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bodyBlock.FlatAppearance.BorderSize = 2;
            this.bodyBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bodyBlock.Location = new System.Drawing.Point(137, 448);
            this.bodyBlock.Name = "bodyBlock";
            this.bodyBlock.Size = new System.Drawing.Size(103, 38);
            this.bodyBlock.TabIndex = 20;
            this.bodyBlock.Text = "Body";
            this.bodyBlock.UseVisualStyleBackColor = false;
            this.bodyBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // headBlock
            // 
            this.headBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headBlock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.headBlock.FlatAppearance.BorderSize = 2;
            this.headBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.headBlock.Location = new System.Drawing.Point(137, 405);
            this.headBlock.Name = "headBlock";
            this.headBlock.Size = new System.Drawing.Size(103, 38);
            this.headBlock.TabIndex = 21;
            this.headBlock.Text = "Head";
            this.headBlock.UseVisualStyleBackColor = false;
            this.headBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // feetAttack
            // 
            this.feetAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.feetAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feetAttack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.feetAttack.FlatAppearance.BorderSize = 2;
            this.feetAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feetAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetAttack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.feetAttack.Location = new System.Drawing.Point(21, 490);
            this.feetAttack.Name = "feetAttack";
            this.feetAttack.Size = new System.Drawing.Size(110, 37);
            this.feetAttack.TabIndex = 16;
            this.feetAttack.Text = "Feet";
            this.feetAttack.UseVisualStyleBackColor = false;
            this.feetAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // bodyAttack
            // 
            this.bodyAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bodyAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyAttack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bodyAttack.FlatAppearance.BorderSize = 2;
            this.bodyAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyAttack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bodyAttack.Location = new System.Drawing.Point(21, 448);
            this.bodyAttack.Name = "bodyAttack";
            this.bodyAttack.Size = new System.Drawing.Size(110, 37);
            this.bodyAttack.TabIndex = 17;
            this.bodyAttack.Text = "Body";
            this.bodyAttack.UseVisualStyleBackColor = false;
            this.bodyAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // headAttack
            // 
            this.headAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headAttack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.headAttack.FlatAppearance.BorderSize = 2;
            this.headAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headAttack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.headAttack.Location = new System.Drawing.Point(22, 405);
            this.headAttack.Name = "headAttack";
            this.headAttack.Size = new System.Drawing.Size(110, 37);
            this.headAttack.TabIndex = 18;
            this.headAttack.Text = "Head";
            this.headAttack.UseVisualStyleBackColor = false;
            this.headAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(150, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Block";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(35, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Attack";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startPicture
            // 
            this.startPicture.BackColor = System.Drawing.Color.Transparent;
            this.startPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startPicture.Image = global::TurnBased_Fighting_Game.Properties.Resources.StartButton_2;
            this.startPicture.Location = new System.Drawing.Point(285, 380);
            this.startPicture.Name = "startPicture";
            this.startPicture.Size = new System.Drawing.Size(130, 83);
            this.startPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPicture.TabIndex = 22;
            this.startPicture.TabStop = false;
            this.startPicture.Click += new System.EventHandler(this.startButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuButton.Location = new System.Drawing.Point(518, 469);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(102, 45);
            this.menuButton.TabIndex = 23;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurnBased_Fighting_Game.Properties.Resources.BackForRegistration_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 537);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.startPicture);
            this.Controls.Add(this.feetBlock);
            this.Controls.Add(this.bodyBlock);
            this.Controls.Add(this.headBlock);
            this.Controls.Add(this.feetAttack);
            this.Controls.Add(this.bodyAttack);
            this.Controls.Add(this.headAttack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AIImage);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.timeOfFight);
            this.Controls.Add(this.history);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.step);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.AIHealth);
            this.Controls.Add(this.playerHealth);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.Load += new System.EventHandler(this.Fight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AIImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.ProgressBar AIHealth;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Label timeOfFight;
        private System.Windows.Forms.PictureBox AIImage;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.Button feetBlock;
        private System.Windows.Forms.Button bodyBlock;
        private System.Windows.Forms.Button headBlock;
        private System.Windows.Forms.Button feetAttack;
        private System.Windows.Forms.Button bodyAttack;
        private System.Windows.Forms.Button headAttack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox startPicture;
        private System.Windows.Forms.Button menuButton;
    }
}