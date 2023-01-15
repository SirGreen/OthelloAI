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
        //PictureBox BlackRec,BlackPiece,WhiteRec,WhitePiece;
        int timeDwn = 121;
        bool turnBlack = true;
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
            b[3, 3].BackColor = Color.Orange;
            b[4, 4].BackColor = Color.Orange;
            b[4, 3].BackColor = Color.Green;
            b[3, 4].BackColor = Color.Green;
        }

        private void StartFirstScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    b[i, j] = new Button();
                    b[i,j].BackgroundImageLayout= ImageLayout.Stretch;
                    b[i, j].Name = i.ToString() + "_" + j.ToString();
                    b[i, j].Location = new Point(i * 50, j * 50);
                    b[i, j].Height = 50;
                    b[i, j].Width = 50;
                    b[i, j].Font = new Font(b[i, j].Font.Name, 10, FontStyle.Bold);
                    b[i, j].BackColor = Color.White;

                    b[i, j].MouseDown += Btn_Click;
                    PlayBoard.Controls.Add(b[i, j]);
                }
            }
            Init();
            BP.Image = Image.FromFile(@"picture\BlackPiece.png");
            BR.Image = Image.FromFile(@"picture\BlackRec.png");
            WP.Image = Image.FromFile(@"picture\WhitePiece.png");
            WR.Image = Image.FromFile(@"picture\WhiteRec.png");
        }

        private void ChangeTurn()
        {
            if (turnBlack) label2.Text = "Turn: White";
            else label2.Text = "Turn: Black";
            turnBlack = !turnBlack;
            timeDwn = 121;
        }

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                if (turnBlack)
                {
                    btn.BackgroundImage = BP.Image;
                }
                else btn.BackgroundImage = WP.Image;
            }
            else return;
            btn.Image = null;
            ChangeTurn();
        }
    }
}
