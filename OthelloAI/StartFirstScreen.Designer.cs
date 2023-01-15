namespace OthelloAI
{
    partial class StartFirstScreen
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
            this.PlayBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.flScoreBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbW = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeDown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayBoard
            // 
            this.PlayBoard.Location = new System.Drawing.Point(12, 12);
            this.PlayBoard.Name = "PlayBoard";
            this.PlayBoard.Size = new System.Drawing.Size(457, 469);
            this.PlayBoard.TabIndex = 0;
            // 
            // flScoreBoard
            // 
            this.flScoreBoard.Controls.Add(this.label1);
            this.flScoreBoard.Controls.Add(this.lbB);
            this.flScoreBoard.Controls.Add(this.lbW);
            this.flScoreBoard.Controls.Add(this.label3);
            this.flScoreBoard.Controls.Add(this.timeDown);
            this.flScoreBoard.Controls.Add(this.label2);
            this.flScoreBoard.Controls.Add(this.Exitbtn);
            this.flScoreBoard.Location = new System.Drawing.Point(474, 12);
            this.flScoreBoard.Margin = new System.Windows.Forms.Padding(2);
            this.flScoreBoard.Name = "flScoreBoard";
            this.flScoreBoard.Size = new System.Drawing.Size(178, 244);
            this.flScoreBoard.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(2, 31);
            this.lbB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(90, 26);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "Black: 2";
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbW.Location = new System.Drawing.Point(2, 57);
            this.lbW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(92, 26);
            this.lbW.TabIndex = 1;
            this.lbW.Text = "White: 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Counter";
            // 
            // timeDown
            // 
            this.timeDown.AutoSize = true;
            this.timeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDown.Location = new System.Drawing.Point(2, 114);
            this.timeDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDown.Name = "timeDown";
            this.timeDown.Size = new System.Drawing.Size(59, 31);
            this.timeDown.TabIndex = 4;
            this.timeDown.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn: Black";
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(2, 178);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(91, 32);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartFirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 493);
            this.Controls.Add(this.flScoreBoard);
            this.Controls.Add(this.PlayBoard);
            this.Name = "StartFirstScreen";
            this.Text = "StartFirst";
            this.Load += new System.EventHandler(this.StartFirstScreen_Load);
            this.flScoreBoard.ResumeLayout(false);
            this.flScoreBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PlayBoard;
        private System.Windows.Forms.FlowLayoutPanel flScoreBoard;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label3;
    }
}