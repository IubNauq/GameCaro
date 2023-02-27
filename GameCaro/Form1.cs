using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        private Button[,] MatrixBox;
        private int[,] idMatrixBox;
        private int columns, rows;

        private Stack<Chess> chesses;
        private Chess chess;

        private int player;
        private bool gameOver;
        private bool Gaming;
        private int prePlayerWin;
        public string username;

        private bool vsComputer;
        private bool LAN;

        private bool youChessed;

        SocketManager socket;

        System.Media.SoundPlayer click_sound, lose_sound, newgame_sound, win_sound;
        Image image_x, image_o, avatar_x, avatar_o;
        int SoundState = 1; // 1:on, 0:off

        Form2 f2;

        private string SaveGameFilePath;

        public Form1(Form2 f2_)
        {
            f2 = f2_;
            username = f2.GetCurUsername();

            columns = 20;
            rows = 15;
            MatrixBox = new Button[rows + 2, columns + 2];
            idMatrixBox = new int[rows + 2, columns + 2];

            chesses = new Stack<Chess>();

            player = 1;
            gameOver = false;
            prePlayerWin = 2;

            vsComputer = false;
            LAN = false;

            socket = new SocketManager();

            click_sound = new System.Media.SoundPlayer("click.wav");
            lose_sound = new System.Media.SoundPlayer("lose.wav");
            win_sound = new System.Media.SoundPlayer("win.wav");
            newgame_sound = new System.Media.SoundPlayer("new_game.wav");

            image_x = Properties.Resources.x_red;
            image_o = Properties.Resources.o_blue;
            avatar_x = Properties.Resources.x_avatar;
            avatar_o = Properties.Resources.o_avatar;

            //SaveGameFilePath = @"D:\Learning\Programming\C#\Program\Buoi01\GameCaro\" + username + ".txt";
            SaveGameFilePath = username + ".txt";

            InitializeComponent();

            BuildTable();

            label4.Text = "USERNAME: " + username;
        }

        void BuildTable()
        {
            for (int i = 1; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                {
                    MatrixBox[i, j] = new Button();
                    MatrixBox[i, j].FlatStyle = FlatStyle.Flat;
                    MatrixBox[i, j].Parent = panel1;
                    MatrixBox[i, j].Top = (i) * Parameter.lengthBox;
                    MatrixBox[i, j].Left = j * Parameter.lengthBox;
                    MatrixBox[i, j].Size = new Size(Parameter.lengthBox, Parameter.lengthBox);
                    MatrixBox[i, j].BackColor = Color.Snow;

                    MatrixBox[i, j].MouseLeave += Box_MouseLeave;
                    MatrixBox[i, j].MouseEnter += Box_MouseEnter;
                    MatrixBox[i, j].Click += Box_Click;
                }

            if (File.Exists(SaveGameFilePath))
            {
                string s = File.ReadAllText(SaveGameFilePath);

                if (s != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want continue last game?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        string[] fileData = File.ReadAllLines(SaveGameFilePath);

                        if (fileData[0] == "1")
                        {
                            string[] line;

                            line = fileData[1].Split(' ');
                            player = int.Parse(line[0]);

                            for (int i = 2; i < fileData.Length; ++i)
                            {
                                line = fileData[i].Split(' ');

                                for (int j = 0; j < line.Length - 1; j++)
                                {
                                    int num = int.Parse(line[j]);
                                    idMatrixBox[i, j + 1] = num;

                                    if (idMatrixBox[i, j + 1] == 1)
                                    {
                                        MatrixBox[i, j + 1].BackgroundImage = image_x;
                                        MatrixBox[i, j + 1].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (idMatrixBox[i, j + 1] == 2)
                                    {
                                        MatrixBox[i, j + 1].BackgroundImage = image_o;
                                        MatrixBox[i, j + 1].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                        }
                        else if (fileData[0] == "2")
                        {
                            vsComputer = true;
                            player = 1;

                            string[] line;
                            for (int i = 1; i < fileData.Length; ++i)
                            {
                                line = fileData[i].Split(' ');

                                for (int j = 0; j < line.Length - 1; j++)
                                {
                                    int num = int.Parse(line[j]);
                                    idMatrixBox[i, j + 1] = num;

                                    if (idMatrixBox[i, j + 1] == 1)
                                    {
                                        MatrixBox[i, j + 1].BackgroundImage = image_x;
                                        MatrixBox[i, j + 1].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (idMatrixBox[i, j + 1] == 2)
                                    {
                                        MatrixBox[i, j + 1].BackgroundImage = image_o;
                                        MatrixBox[i, j + 1].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                        }

                        File.WriteAllText(SaveGameFilePath, "");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                        File.WriteAllText(SaveGameFilePath, "");
                    }
                }
            }
        }

        private void Box_MouseEnter(object sender, EventArgs e)
        {
            if (gameOver) return;

            Button bt = (Button)sender;
            bt.BackColor = Color.AliceBlue;
        }

        private void Box_MouseLeave(object sender, EventArgs e)
        {
            if (gameOver) return;

            Button bt = (Button)sender;
            bt.BackColor = Color.Snow;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            Gaming = true;

            Button bt = (Button)sender;
            int x = bt.Top / Parameter.lengthBox, y = bt.Left / Parameter.lengthBox;

            if (idMatrixBox[x, y] != 0)
                return;

            if (SoundState == 1)
                click_sound.Play();

            if (vsComputer)
            {
                timer_Cooldown.Start();
                progressBar_CdTime.Value = 0;

                player = 1;
                bt.BackgroundImage = image_x;
                bt.BackgroundImageLayout = ImageLayout.Zoom;
                idMatrixBox[x, y] = 1;
                Check(x, y);

                AiFindChess();
            }
            else if (LAN)
            {
                youChessed = true;
                timer_Cooldown.Stop();
                progressBar_CdTime.Value = 0;
                if (player == 1)
                {
                    bt.BackgroundImage = image_x;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    idMatrixBox[x, y] = 1;
                    Check(x, y);

                    player = 2;
                    label_Player.Text = "Enemy Turn";
                    pictureBox_Player.Image = avatar_o;
                }
                else
                {
                    bt.BackgroundImage = image_o;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    idMatrixBox[x, y] = 2;
                    Check(x, y);

                    player = 1;
                    label_Player.Text = "Enemy Turn";
                    pictureBox_Player.Image = avatar_x;
                }
                panel1.Enabled = false;
                socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", x, y));
                Listen();
            }
            else
            {
                if (player == 1)
                {
                    timer_Cooldown.Start();
                    progressBar_CdTime.Value = 0;

                    bt.BackgroundImage = image_x;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    idMatrixBox[x, y] = 1;
                    Check(x, y);

                    player = 2;
                    label_Player.Text = "Player 2's Turn";
                    pictureBox_Player.Image = avatar_o;
                }
                else
                {
                    timer_Cooldown.Start();
                    progressBar_CdTime.Value = 0;

                    bt.BackgroundImage = image_o;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    idMatrixBox[x, y] = 2;
                    Check(x, y);

                    player = 1;
                    label_Player.Text = "Player 1's Turn";
                    pictureBox_Player.Image = avatar_x;
                }
            }

            chess = new Chess(bt, x, y);
            chesses.Push(chess);
        }

        private void Check(int x, int y)
        {
            int column = 1, row = 1, mdiagonal = 1, ediagonal = 1;

            int i = x - 1, j = y;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i >= 1)
            {
                column++;
                i--;
            }

            i = x + 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i <= rows)
            {
                column++;
                i++;
            }

            i = x; j = y - 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && j >= 1)
            {
                row++;
                j--;
            }

            j = y + 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && j <= columns)
            {
                row++;
                j++;
            }

            i = x - 1; j = y - 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i >= 1 && j >= 1)
            {
                mdiagonal++;
                i--;
                j--;
            }

            i = x + 1; j = y + 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }

            i = x - 1; j = y + 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i >= 1 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }

            i = x + 1; j = y - 1;
            while (idMatrixBox[x, y] == idMatrixBox[i, j] && i <= rows && j >= 1)
            {
                ediagonal++;
                i++;
                j--;
            }

            if (row >= 5 || column >= 5 || mdiagonal >= 5 || ediagonal >= 5)
                Gameover();
        }

        private void timer_Cooldown_Tick(object sender, EventArgs e)
        {
            progressBar_CdTime.PerformStep();

            if (progressBar_CdTime.Value >= progressBar_CdTime.Maximum)
            {
                if (SoundState == 1)
                    lose_sound.Play();

                Gameover();
            }
        }

        private void Gameover()
        {
            timer_Cooldown.Stop();
            gameOver = true;
            Gaming = false;

            BackgroundGameover();

            if (vsComputer)
            {
                if (player == 1)
                {
                    if (SoundState == 1)
                        win_sound.Play();

                    f2.AddScoreforPlayer(username);

                    MessageBox.Show("YOU WIN!!!");
                }
                else
                {
                    if (SoundState == 1)
                        lose_sound.Play();
                    MessageBox.Show("YOU LOSE!!!");
                }
            }
            else if (LAN)
            {
                if (progressBar_CdTime.Value >= progressBar_CdTime.Maximum)
                {
                    if (player == 1)
                    {
                        if (SoundState == 1)
                            lose_sound.Play();

                        socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "YOU WIN!!!", 0, 0));
                        MessageBox.Show("YOU LOSE!!!");
                        Listen();
                    }
                    else
                    {
                        if (SoundState == 1)
                            win_sound.Play();

                        f2.AddScoreforPlayer(username);

                        socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "YOU LOSE!!!", 0, 0));
                        MessageBox.Show("YOU WIN!!!");
                        Listen();
                    }

                }
                else
                {
                    if (player == 1)
                    {
                        if (youChessed == true)
                        {
                            if (SoundState == 1)
                                win_sound.Play();

                            f2.AddScoreforPlayer(username);

                            MessageBox.Show("YOU WIN!!!");
                        }
                        else
                        {
                            if (SoundState == 1)
                                lose_sound.Play();
                            MessageBox.Show("YOU LOSE!!!");
                        }

                    }
                    else
                    {
                        if (youChessed == false)
                        {
                            if (SoundState == 1)
                                lose_sound.Play();
                            MessageBox.Show("YOU LOSE!!!");
                        }
                        else
                        {
                            if (SoundState == 1)
                                win_sound.Play();

                            f2.AddScoreforPlayer(username);

                            MessageBox.Show("YOU WIN!!!");
                        }
                    }
                }
            }
            else
            {
                if (progressBar_CdTime.Value >= progressBar_CdTime.Maximum)
                {
                    if (SoundState == 1)
                        win_sound.Play();
                    string mess;
                    if (player == 1)
                    {
                        prePlayerWin = 2;
                        mess = "PLAYER2 WIN!!!";
                    }
                    else
                    {
                        prePlayerWin = 1;
                        mess = "PLAYER1 WIN!!!";
                    }
                    MessageBox.Show(mess);
                }
                else
                {
                    if (SoundState == 1)
                        win_sound.Play();
                    if (player == 1)
                    {
                        prePlayerWin = 1;
                        MessageBox.Show("PLAYER1 WIN!!!");
                    }
                    else
                    {
                        prePlayerWin = 2;
                        MessageBox.Show("PLAYER2 WIN!!!");
                    }
                }
            }
        }

        private void BackgroundGameover()
        {
            for (int i = 1; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                    MatrixBox[i, j].BackColor = Color.Gray;
        }

        #region MenuStrip
        private void player1VsPlayer2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (SoundState == 1)
                newgame_sound.Play();

            vsComputer = false;
            LAN = false;
            gameOver = false;
            panel1.Controls.Clear();
            panel1.Enabled = true;

            if (prePlayerWin == 2)
            {
                player = 1;
                pictureBox_Player.Image = avatar_x;
                label_Player.Text = "Player 1's Turn";
            }
            else
            {
                player = 2;
                pictureBox_Player.Image = avatar_o;
                label_Player.Text = "Player 2's Turn";
            }

            MatrixBox = new Button[rows + 2, columns + 2];
            idMatrixBox = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();

            BuildTable();

            timer_Cooldown.Stop();
            progressBar_CdTime.Value = 0;
        }

        private void playerVsComputerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (SoundState == 1)
                newgame_sound.Play();

            vsComputer = true;
            LAN = false;
            gameOver = false;
            panel1.Controls.Clear();
            panel1.Enabled = true;

            progressBar_CdTime.Value = 0;
            timer_Cooldown.Stop();

            player = 1;
            pictureBox_Player.Image = avatar_x;
            label_Player.Text = "Player's Turn";

            MatrixBox = new Button[rows + 2, columns + 2];
            idMatrixBox = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();

            BuildTable();
        }

        private void connectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            vsComputer = false;
            LAN = true;
            gameOver = false;
            panel1.Controls.Clear();
            panel1.Enabled = true;

            progressBar_CdTime.Value = 0;
            timer_Cooldown.Stop();

            player = 1;

            pictureBox_Player.Image = Properties.Resources.x_avatar;

            MatrixBox = new Button[rows + 2, columns + 2];
            idMatrixBox = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();

            BuildTable();

            socket.IP = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);

            if (!socket.ConnectServer())
            {
                label_Player.Text = "Your Turn";
                socket.CreateServer();
                MessageBox.Show("Bạn đang là Server!!!", "THÔNG BÁO");
            }
            else
            {
                label_Player.Text = "Enemy Turn";
                panel1.Enabled = false;
                MessageBox.Show("Kết nối thành công!!!", "THÔNG BÁO");
                Listen();
            }
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", 0, 0));
            Listen();
        }

        private void NewGame()
        {
            if (SoundState == 1)
                newgame_sound.Play();

            player = 1;
            label_Player.Text = "Your Turn";
            pictureBox_Player.Image = Properties.Resources.x_avatar;

            gameOver = false;
            progressBar_CdTime.Value = 0;

            panel1.Enabled = true;
            panel1.Controls.Clear();

            MatrixBox = new Button[rows + 2, columns + 2];
            idMatrixBox = new int[rows + 2, columns + 2];
            BuildTable();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (chesses.Count != 0 && !gameOver)
            {
                if (vsComputer)
                {
                    Chess temp = new Chess();
                    temp = chesses.Pop();
                    temp.bt.BackgroundImage = null;
                    idMatrixBox[temp.X, temp.Y] = 0;

                    temp = chesses.Pop();
                    temp.bt.BackgroundImage = null;
                    idMatrixBox[temp.X, temp.Y] = 0;

                    progressBar_CdTime.Value = 0;
                    player = 1;
                }
                else if (LAN)
                {

                }
                else
                {
                    Chess temp = new Chess();
                    temp = chesses.Pop();
                    temp.bt.BackgroundImage = null;
                    idMatrixBox[temp.X, temp.Y] = 0;

                    progressBar_CdTime.Value = 0;

                    ChangePlayer();
                }
            }
        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                socket.Send(new SocketData((int)SocketCommand.QUIT, "", 0, 0));
                socket.CloseConnect();
            }
            catch
            {

            }

            if (Gaming)
            {
                string str = "";

                if (vsComputer)
                {
                    str = "2" + "\n";
                }
                else if (LAN)
                {

                }
                else
                {
                    str = "1" + "\n";
                    str += player + "\n";
                }

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        str += idMatrixBox[i, j] + " ";
                    }
                    str += "\n";
                }
                File.WriteAllText(SaveGameFilePath, str);
            }

            this.Close();
            f2.Close();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                socket.CloseConnect();
                MessageBox.Show("NGẮT KẾT NỐI THÀNH CÔNG!!!", "THÔNG BÁO");
            }
            catch { }
        }

        private void tierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            string username = f2.GetDataUsername();
            string score = f2.GetDataScore();
            string stt = "#1\n#2\n#3\n#4\n#5\n#6\n#7\n#8";

            label_STT.Text = stt;
            label_Username.Text = username;
            label_Win.Text = score;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onToolStripMenuItem.Checked == false)
            {
                SoundState = 1;
                onToolStripMenuItem.Checked = true;
                offToolStripMenuItem.Checked = false;
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (offToolStripMenuItem.Checked == false)
            {
                SoundState = 0;
                offToolStripMenuItem.Checked = true;
                onToolStripMenuItem.Checked = false;
            }

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (standardToolStripMenuItem.Checked == false)
            {
                image_x = Properties.Resources.x_red;
                image_o = Properties.Resources.o_blue;
                avatar_x = Properties.Resources.x_avatar;
                avatar_o = Properties.Resources.o_avatar;

                if (player == 1)
                    pictureBox_Player.Image = avatar_x;
                else if (player == 2)
                    pictureBox_Player.Image = avatar_o;

                standardToolStripMenuItem.Checked = true;
                candyToolStripMenuItem.Checked = false;
                chrismasToolStripMenuItem.Checked = false;
            }
        }

        private void candyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (candyToolStripMenuItem.Checked == false)
            {
                image_x = Properties.Resources.candy_x;
                image_o = Properties.Resources.candy_o;
                avatar_x = Properties.Resources.candy_x;
                avatar_o = Properties.Resources.candy_o;

                if (player == 1)
                    pictureBox_Player.Image = avatar_x;
                else if (player == 2)
                    pictureBox_Player.Image = avatar_o;

                standardToolStripMenuItem.Checked = false;
                candyToolStripMenuItem.Checked = true;
                chrismasToolStripMenuItem.Checked = false;
            }
        }

        private void chrismasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chrismasToolStripMenuItem.Checked == false)
            {
                image_x = Properties.Resources.christmas_x;
                image_o = Properties.Resources.christmas_o;
                avatar_x = Properties.Resources.christmas_x;
                avatar_o = Properties.Resources.christmas_o;

                if (player == 1)
                    pictureBox_Player.Image = avatar_x;
                else if (player == 2)
                    pictureBox_Player.Image = avatar_o;

                standardToolStripMenuItem.Checked = false;
                candyToolStripMenuItem.Checked = false;
                chrismasToolStripMenuItem.Checked = true;
            }

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
        #endregion

        #region LAN

        private void Listen()
        {
            Thread ListenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch { }
            });

            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.command)
            {
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        OtherPlayerClicked(data.curRow, data.curCol);
                        panel1.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        panel1.Enabled = false;
                        label_Player.Text = "Enemy Turn";
                    }));
                    break;

                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (SoundState == 1)
                            win_sound.Play();

                        f2.AddScoreforPlayer(username);

                        BackgroundGameover();
                        gameOver = true;
                        MessageBox.Show(data.message);
                    }));
                    break;

                case (int)SocketCommand.QUIT:
                    BackgroundGameover();
                    gameOver = true;
                    timer_Cooldown.Stop();

                    socket.CloseConnect();
                    MessageBox.Show("ĐỐI THỦ ĐÃ THOÁT!!!", "THÔNG BÁO");
                    break;

                case (int)SocketCommand.SEND_MESSAGE:
                    break;

                default:
                    break;
            }
            Listen();
        }

        private void OtherPlayerClicked(int curRow, int curCol)
        {
            youChessed = false;
            timer_Cooldown.Start();
            progressBar_CdTime.Value = 0;

            Button bt = MatrixBox[curRow, curCol];
            if (player == 1)
            {
                bt.BackgroundImage = image_x;
                bt.BackgroundImageLayout = ImageLayout.Zoom;
                idMatrixBox[curRow, curCol] = 1;
                Check(curRow, curCol);

                player = 2;
                label_Player.Text = "Your Turn";
                pictureBox_Player.Image = avatar_o;
            }
            else
            {
                bt.BackgroundImage = image_o;
                bt.BackgroundImageLayout = ImageLayout.Zoom;
                idMatrixBox[curRow, curCol] = 2;
                Check(curRow, curCol);

                player = 1;
                label_Player.Text = "Your Turn";
                pictureBox_Player.Image = avatar_x;
            }

        }
        #endregion

        #region AI

        private long[] ArrAttackScore = new long[7] { 0, 64, 4096, 262144, 16777216, 1073741824, 68719476736 };
        private long[] ArrDefenseScore = new long[7] { 0, 8, 512, 32768, 2097152, 134217728, 8589934592 };

        private long AttackHorizontal(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curRow <= rows; count++)
            {
                if (idMatrixBox[count + curRow, curCol] == 2)
                    AiCells++;
                else if (idMatrixBox[count + curRow, curCol] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, curCol] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow - count, curCol] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[AiCells];

            return TotalScore;
        }

        private long AttackVertical(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns; count++)
            {
                if (idMatrixBox[curRow, count + curCol] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow, count + curCol] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1; count++)
            {
                if (idMatrixBox[curRow, curCol - count] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow, curCol - count] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[AiCells];

            return TotalScore;
        }

        private long AttackMainDiag(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns && count + curRow <= rows; count++)
            {
                if (idMatrixBox[curRow + count, count + curCol] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow + count, count + curCol] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1 && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, curCol - count] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow - count, curCol - count] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[AiCells];

            return TotalScore;
        }

        private long AttackExtraDiag(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, count + curCol] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow - count, count + curCol] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1 && curRow + count <= rows; count++)
            {
                if (idMatrixBox[curRow + count, curCol - count] == 2)
                    AiCells++;
                else if (idMatrixBox[curRow + count, curCol - count] == 1)
                {
                    ManCells++;
                    break;
                }
                else
                    break;
            }

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[AiCells];

            return TotalScore;
        }

        private long DefenseHorizontal(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curRow <= rows; count++)
            {
                if (idMatrixBox[count + curRow, curCol] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[count + curRow, curCol] == 1)
                    ManCells++;
                else
                    break;
            }

            for (int count = 1; count < 6 && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, curCol] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow - count, curCol] == 1)
                    ManCells++;
                else
                    break;
            }

            if (AiCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }

        private long DefenseVertical(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns; count++)
            {
                if (idMatrixBox[curRow, count + curCol] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow, count + curCol] == 1)
                    ManCells++;
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1; count++)
            {
                if (idMatrixBox[curRow, curCol - count] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow, curCol - count] == 1)
                    ManCells++;
                else
                    break;
            }

            if (AiCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }

        private long DefenseMainDiag(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns && count + curRow <= rows; count++)
            {
                if (idMatrixBox[curRow + count, count + curCol] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow + count, count + curCol] == 1)
                    ManCells++;
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1 && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, curCol - count] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow - count, curCol - count] == 1)
                    ManCells++;
                else
                    break;
            }

            if (AiCells == 2)
                return 0;

            TotalScore += ArrAttackScore[ManCells];

            return TotalScore;
        }

        private long DefenseExtraDiag(int curRow, int curCol)
        {
            long TotalScore = 0;
            int AiCells = 0;
            int ManCells = 0;

            for (int count = 1; count < 6 && count + curCol <= columns && curRow - count >= 1; count++)
            {
                if (idMatrixBox[curRow - count, count + curCol] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow - count, count + curCol] == 1)
                    ManCells++;
                else
                    break;
            }

            for (int count = 1; count < 6 && curCol - count >= 1 && curRow + count <= rows; count++)
            {
                if (idMatrixBox[curRow + count, curCol - count] == 2)
                {
                    AiCells++;
                    break;
                }
                else if (idMatrixBox[curRow + count, curCol - count] == 1)
                    ManCells++;
                else
                    break;
            }

            if (AiCells == 2)
                return 0;

            TotalScore += ArrAttackScore[ManCells];

            return TotalScore;
        }

        private void AiFindChess()
        {
            if (gameOver) return;

            long MaxScore = 0;
            int curRow = 0;
            int curCol = 0;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (idMatrixBox[i, j] == 0)
                    {
                        long AttackScore = AttackHorizontal(i, j) + AttackVertical(i, j) + AttackMainDiag(i, j) + AttackExtraDiag(i, j);
                        long DefenseScore = DefenseHorizontal(i, j) + DefenseVertical(i, j) + DefenseMainDiag(i, j) + DefenseExtraDiag(i, j);
                        long TempScore = AttackScore > DefenseScore ? AttackScore : DefenseScore;

                        if (MaxScore < TempScore)
                        {
                            MaxScore = TempScore;
                            curRow = i;
                            curCol = j;
                        }
                    }
                }
            }
            PutChess(curRow, curCol);
        }

        private void PutChess(int curRow, int curColumn)
        {
            player = 2;
            progressBar_CdTime.Value = 0;
            MatrixBox[curRow, curColumn].BackgroundImage = image_o;
            MatrixBox[curRow, curColumn].BackgroundImageLayout = ImageLayout.Zoom;
            idMatrixBox[curRow, curColumn] = 2;

            Check(curRow, curColumn);

            chess = new Chess(MatrixBox[curRow, curColumn], curRow, curColumn);
            chesses.Push(chess);
        }
        #endregion

        #region Support Function
        public class Chess
        {
            public Button bt;
            public int X;
            public int Y;
            public Chess()
            {
                bt = new Button();
            }
            public Chess(Button _bt, int x, int y)
            {
                bt = new Button();
                bt = _bt;
                X = x;
                Y = y;
            }
        }

        public void ChangePlayer()
        {
            player = player == 1 ? 2 : 1;
            if (player == 1)
            {
                pictureBox_Player.Image = avatar_x;
                label_Player.Text = "Player 1's Turn";
            }
            else
            {
                pictureBox_Player.Image = avatar_o;
                label_Player.Text = "Player 2's Turn";
            }
        }
        #endregion
    }
}




