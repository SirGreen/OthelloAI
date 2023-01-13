using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OthelloAI
{
    public partial class StartFirstScreen : Form
    {
        public Button[,] b =new Button [8,8];
        PictureBox BlackRec,BlackPiece,WhiteRec,WhitePiece;
        public StartFirstScreen()
        {
            InitializeComponent();
        }

        private void StartFirstScreen_Load(object sender, EventArgs e)
        {
            for (int i=0; i<8; i++)
                for (int j=0; j<8; j++)
                {
                    b[i, j] = new Button();

                    b[i, j].Name = i.ToString() + "_" + j.ToString();
                    b[i, j].Location = new Point(i * 50, j * 50);
                    b[i, j].Height = 50;
                    b[i, j].Width = 50;
                    b[i, j].Font = new Font(b[i, j].Font.Name, 10, FontStyle.Bold);
                    b[i, j].BackColor = Color.White;

                    PlayBoard.Controls.Add(b[i, j]);

                    b[i, j].MouseDown += Btn_Click;
                }
            
        }

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Green;
            else btn.BackColor = Color.White;
            btn.Image = null;
        }
    }
}
