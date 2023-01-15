using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OthelloAI
{
    public partial class StartFirstScreen : Form
    {
        //var declaration
        public Button[,] b = new Button[8, 8];
        int BlackPiece = 0, WhitePiece = 0;
        int timeDwn = 120;
        bool turnBlack = true;
        int[,] Game = new int[8, 8];
        /*0: Nothing
          1: Black
          2: White*/

        int[] dx = new int[8] { 0, -1, -1, -1, 0, 1, 1, 1 };
        int[] dy = new int[8] { -1, -1, 0, 1, 1, 1, 0, -1 };


        PictureBox BP = new PictureBox(), BR=new PictureBox(), WP=new PictureBox(), WR = new PictureBox();

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeDwn--;
            timeDown.Text=timeDwn.ToString();
            if (timeDwn == 0) ChangeTurn();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public StartFirstScreen()
        {
            InitializeComponent();
        }

        private void Init()
        {
            flScoreBoard.Location = new Point(PlayBoard.Location.X + PlayBoard.Width, PlayBoard.Location.Y);

            timer1.Start();
            Game[3, 3] = 2;
            Game[4, 4] = 2;
            Game[3, 4] = 1;
            Game[4, 3] = 1;
            b[3, 3].BackgroundImage = WP.Image;
            b[4, 4].BackgroundImage = WP.Image;
            b[4, 3].BackgroundImage = BP.Image;
            b[3, 4].BackgroundImage = BP.Image;
        }

        private void StartFirstScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Game[i, j] = 0;
                    b[i, j] = new Button();
                    b[i,j].BackgroundImageLayout= ImageLayout.Stretch;
                    b[i, j].Name = i.ToString() + "_" + j.ToString();
                    b[i, j].Location = new Point(i * 50, j * 50);
                    b[i, j].Height = 50;
                    b[i, j].Width = 50;
                    b[i, j].Font = new Font(b[i, j].Font.Name, 10, FontStyle.Bold);
                    b[i, j].BackColor = Color.WhiteSmoke;

                    b[i, j].MouseDown += Btn_Click;
                    PlayBoard.Controls.Add(b[i, j]);
                }
            }
            BP.Image = Image.FromFile(@"picture\BlackPiece.png");
            BR.Image = Image.FromFile(@"picture\BlackRec.png");
            WP.Image = Image.FromFile(@"picture\WhitePiece.png");
            WR.Image = Image.FromFile(@"picture\WhiteRec.png");
            Init();
            AvailableMove(1);
        }

        private void ResetImg()
        {
            for (int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++) 
                {
                    if (b[i, j].BackgroundImage == BR.Image || b[i, j].BackgroundImage == WR.Image)
                        b[i, j].BackgroundImage = null;
                }
            }
        }

        private void CheckWin()
        {
            string s = "";
            if (BlackPiece + WhitePiece == 64)
            {
                if (BlackPiece > WhitePiece) s = "Black";
                else s = "White";
                timer1.Stop();
                DialogResult dialog = MessageBox.Show(s + " win!!!", "Notification");
                this.Close();
            }
        }

        private void ChangeTurn()
        {
            
            turnBlack = !turnBlack;
            if (!turnBlack)
            {
                label2.Text = "Turn: White";
                AvailableMove(2);
            }
            else
            {
                label2.Text = "Turn: Black";
                AvailableMove(1);
            }
            timeDwn = 120;
            lbB.Text = "Black: " + BlackPiece.ToString();
            lbW.Text = "White: " + WhitePiece.ToString();
            CheckWin();
        }

        private void AvailableMove(int cl)
        {
            BlackPiece = 0;
            WhitePiece = 0;
            for (int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game[i, j] == 1) BlackPiece++;
                    else if (Game[i, j] == 2) WhitePiece++;
                    if (Game[i,j]==cl)
                    {
                        for (int h = 0; h < 8; h++)
                        {
                            int x = i, y = j;
                            bool diffcolor = false;
                            while (x + dx[h]>-1 && x + dx[h]<8 && y + dy[h]>-1 && y + dy[h]<8)
                            {
                                x = x + dx[h]; y = y + dy[h];
                                if (Game[x, y] == cl) break;
                                if (Game[x, y] == 0)
                                {
                                    if (diffcolor)
                                    {
                                        if (cl == 2) b[x, y].BackgroundImage = WR.Image;
                                        else b[x, y].BackgroundImage = BR.Image;
                                    }
                                    break;
                                }
                                else diffcolor = true;
                            }
                        }
                    }
                }
            }
        }

        private void Flip(int i, int j)
        {
            Queue<int> qux = new Queue<int>();
            Queue<int> quy = new Queue<int>();
            int cl = Game[i, j];

            for (int h = 0; h < 8; h++)
            {
                bool isFlip = false;
                int x = i, y = j;
                while (x + dx[h] > -1 && x + dx[h] < 8 && y + dy[h] > -1 && y + dy[h] < 8)
                {
                    x += dx[h]; y += dy[h];
                    if (Game[x, y] != 0 && Game[x, y] != cl)
                    {
                        qux.Enqueue(x);
                        quy.Enqueue(y);
                    }
                    else
                    {
                        if (Game[x, y] == cl) isFlip = true;
                        break;
                    }
                }
                int cnt=qux.Count;
                while(cnt>0)
                {
                    x = qux.Dequeue();
                    y = quy.Dequeue();
                    if (isFlip)
                    { 
                        Game[x, y] = cl;
                        if (cl == 1) b[x, y].BackgroundImage = BP.Image;
                        else b[x, y].BackgroundImage = WP.Image;
                    }
                    cnt--;
                }
            }
        }

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            string s = btn.Name;

            int i = s[0] - '0';
            int j = s[2] - '0';


            if (turnBlack && btn.BackgroundImage == BR.Image)
            {
                btn.BackgroundImage = BP.Image;
                Game[i, j] = 1;
            }
            else if (!turnBlack && btn.BackgroundImage == WR.Image)
            {
                Game[i, j] = 2;
                btn.BackgroundImage = WP.Image;
            }
            else return;
            ResetImg();
            Flip(i, j);
            ChangeTurn();
        }
    }
}
