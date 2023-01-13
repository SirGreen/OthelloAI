namespace OthelloAI
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
            this.StartFirst = new System.Windows.Forms.Button();
            this.StartSecond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartFirst
            // 
            this.StartFirst.Location = new System.Drawing.Point(376, 194);
            this.StartFirst.Name = "StartFirst";
            this.StartFirst.Size = new System.Drawing.Size(83, 23);
            this.StartFirst.TabIndex = 0;
            this.StartFirst.Text = "Start First";
            this.StartFirst.UseVisualStyleBackColor = true;
            this.StartFirst.Click += new System.EventHandler(this.StartFirst_Click);
            // 
            // StartSecond
            // 
            this.StartSecond.Location = new System.Drawing.Point(376, 224);
            this.StartSecond.Name = "StartSecond";
            this.StartSecond.Size = new System.Drawing.Size(83, 23);
            this.StartSecond.TabIndex = 1;
            this.StartSecond.Text = "Start Second";
            this.StartSecond.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartSecond);
            this.Controls.Add(this.StartFirst);
            this.Name = "Form1";
            this.Text = "Othello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartFirst;
        private System.Windows.Forms.Button StartSecond;
    }
}

