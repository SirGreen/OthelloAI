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
            this.PlayBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PlayBoard
            // 
            this.PlayBoard.Location = new System.Drawing.Point(12, 12);
            this.PlayBoard.Name = "PlayBoard";
            this.PlayBoard.Size = new System.Drawing.Size(502, 469);
            this.PlayBoard.TabIndex = 0;
            // 
            // StartFirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 493);
            this.Controls.Add(this.PlayBoard);
            this.Name = "StartFirstScreen";
            this.Text = "StartFirst";
            this.Load += new System.EventHandler(this.StartFirstScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PlayBoard;
    }
}