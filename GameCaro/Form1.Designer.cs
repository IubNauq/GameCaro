
namespace GameCaro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_Win = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_STT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Infor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar_CdTime = new System.Windows.Forms.ProgressBar();
            this.pictureBox_Player = new System.Windows.Forms.PictureBox();
            this.label_Player = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_Cooldown = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tierListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeXOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chrismasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(157, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.button_Exit);
            this.panel3.Controls.Add(this.label_Win);
            this.panel3.Controls.Add(this.label_Username);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label_STT);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(337, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 398);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Gold;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.Red;
            this.button_Exit.Location = new System.Drawing.Point(189, 353);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(99, 34);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_Win
            // 
            this.label_Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Win.ForeColor = System.Drawing.Color.Orange;
            this.label_Win.Location = new System.Drawing.Point(366, 105);
            this.label_Win.Name = "label_Win";
            this.label_Win.Size = new System.Drawing.Size(45, 243);
            this.label_Win.TabIndex = 6;
            this.label_Win.Text = "label4";
            // 
            // label_Username
            // 
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.Orange;
            this.label_Username.Location = new System.Drawing.Point(109, 105);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(217, 243);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LawnGreen;
            this.label7.Location = new System.Drawing.Point(361, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Win";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(109, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "User name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(41, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "STT";
            // 
            // label_STT
            // 
            this.label_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_STT.ForeColor = System.Drawing.Color.Orange;
            this.label_STT.Location = new System.Drawing.Point(41, 105);
            this.label_STT.Name = "label_STT";
            this.label_STT.Size = new System.Drawing.Size(50, 243);
            this.label_STT.TabIndex = 1;
            this.label_STT.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(163, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIER LIST";
            // 
            // panel_Infor
            // 
            this.panel_Infor.BackColor = System.Drawing.Color.BurlyWood;
            this.panel_Infor.Controls.Add(this.label2);
            this.panel_Infor.Controls.Add(this.progressBar_CdTime);
            this.panel_Infor.Controls.Add(this.pictureBox_Player);
            this.panel_Infor.Controls.Add(this.label_Player);
            this.panel_Infor.Controls.Add(this.pictureBox1);
            this.panel_Infor.Location = new System.Drawing.Point(998, 134);
            this.panel_Infor.Name = "panel_Infor";
            this.panel_Infor.Size = new System.Drawing.Size(230, 579);
            this.panel_Infor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(41, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Remaining";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar_CdTime
            // 
            this.progressBar_CdTime.BackColor = System.Drawing.Color.SaddleBrown;
            this.progressBar_CdTime.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar_CdTime.Location = new System.Drawing.Point(41, 527);
            this.progressBar_CdTime.Maximum = 10000;
            this.progressBar_CdTime.Name = "progressBar_CdTime";
            this.progressBar_CdTime.Size = new System.Drawing.Size(150, 40);
            this.progressBar_CdTime.Step = 100;
            this.progressBar_CdTime.TabIndex = 3;
            // 
            // pictureBox_Player
            // 
            this.pictureBox_Player.BackColor = System.Drawing.Color.Peru;
            this.pictureBox_Player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Player.Image = global::GameCaro.Properties.Resources.x_avatar;
            this.pictureBox_Player.Location = new System.Drawing.Point(41, 225);
            this.pictureBox_Player.Name = "pictureBox_Player";
            this.pictureBox_Player.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Player.TabIndex = 2;
            this.pictureBox_Player.TabStop = false;
            // 
            // label_Player
            // 
            this.label_Player.BackColor = System.Drawing.Color.Peru;
            this.label_Player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Player.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Player.ForeColor = System.Drawing.Color.LightGreen;
            this.label_Player.Location = new System.Drawing.Point(41, 375);
            this.label_Player.Name = "label_Player";
            this.label_Player.Size = new System.Drawing.Size(150, 68);
            this.label_Player.TabIndex = 1;
            this.label_Player.Text = "Player 1\'s Turn";
            this.label_Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GameCaro.Properties.Resources.png_clipart_tictactoe_tic_tac_toe_chess_jumping_submarine_morabaraba_in_a_row_game_sports1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(977, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 579);
            this.label1.TabIndex = 2;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // timer_Cooldown
            // 
            this.timer_Cooldown.Tick += new System.EventHandler(this.timer_Cooldown_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(157, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 31);
            this.panel2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.tierListToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1VsPlayer2ToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem,
            this.lANToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.newGameToolStripMenuItem.Text = "Game Mode";
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player1 vs. Player2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2ToolStripMenuItem_Click_1);
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.playerVsComputerToolStripMenuItem.Text = "Player vs. Computer";
            this.playerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.playerVsComputerToolStripMenuItem_Click_1);
            // 
            // lANToolStripMenuItem
            // 
            this.lANToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.lANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.lANToolStripMenuItem.Name = "lANToolStripMenuItem";
            this.lANToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.lANToolStripMenuItem.Text = "LAN";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.BackColor = System.Drawing.Color.Khaki;
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(181, 28);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click_1);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // tierListToolStripMenuItem
            // 
            this.tierListToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.tierListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tierListToolStripMenuItem.Name = "tierListToolStripMenuItem";
            this.tierListToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.tierListToolStripMenuItem.Text = "Tier List";
            this.tierListToolStripMenuItem.Click += new System.EventHandler(this.tierListToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click_1);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.changeXOToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.soundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.soundToolStripMenuItem.Text = "Sound";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.onToolStripMenuItem.Checked = true;
            this.onToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // changeXOToolStripMenuItem
            // 
            this.changeXOToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.changeXOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.candyToolStripMenuItem,
            this.chrismasToolStripMenuItem});
            this.changeXOToolStripMenuItem.Name = "changeXOToolStripMenuItem";
            this.changeXOToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.changeXOToolStripMenuItem.Text = "Change X, O display";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // candyToolStripMenuItem
            // 
            this.candyToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.candyToolStripMenuItem.Name = "candyToolStripMenuItem";
            this.candyToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.candyToolStripMenuItem.Text = "Candy";
            this.candyToolStripMenuItem.Click += new System.EventHandler(this.candyToolStripMenuItem_Click);
            // 
            // chrismasToolStripMenuItem
            // 
            this.chrismasToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.chrismasToolStripMenuItem.Name = "chrismasToolStripMenuItem";
            this.chrismasToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.chrismasToolStripMenuItem.Text = "Christmas";
            this.chrismasToolStripMenuItem.Click += new System.EventHandler(this.chrismasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.aboutMeToolStripMenuItem.Text = "About me";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(377, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "USERNAME: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources._800px_COLOURBOX18927332;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Infor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_Infor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Infor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.PictureBox pictureBox_Player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar_CdTime;
        private System.Windows.Forms.Timer timer_Cooldown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeXOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tierListToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_STT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Win;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chrismasToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

