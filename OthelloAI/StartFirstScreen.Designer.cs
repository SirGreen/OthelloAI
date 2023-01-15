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
            this.label2 = new System.Windows.Forms.Label();
            this.timeDown = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.flScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayBoard
            // 
            this.PlayBoard.Location = new System.Drawing.Point(18, 18);
            this.PlayBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayBoard.Name = "PlayBoard";
            this.PlayBoard.Size = new System.Drawing.Size(686, 722);
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
            this.flScoreBoard.Location = new System.Drawing.Point(711, 18);
            this.flScoreBoard.Name = "flScoreBoard";
            this.flScoreBoard.Size = new System.Drawing.Size(267, 375);
            this.flScoreBoard.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(3, 46);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(131, 37);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "Black: 2";
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbW.Location = new System.Drawing.Point(3, 83);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(135, 37);
            this.lbW.TabIndex = 1;
            this.lbW.Text = "White: 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn: Black";
            // 
            // timeDown
            // 
            this.timeDown.AutoSize = true;
            this.timeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDown.Location = new System.Drawing.Point(178, 120);
            this.timeDown.Name = "timeDown";
            this.timeDown.Size = new System.Drawing.Size(86, 46);
            this.timeDown.TabIndex = 4;
            this.timeDown.Text = "120";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(3, 215);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(137, 49);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Counter";
            // 
            // StartFirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 758);
            this.Controls.Add(this.flScoreBoard);
            this.Controls.Add(this.PlayBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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