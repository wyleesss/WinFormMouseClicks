namespace MouseClicks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clicksCountText = new System.Windows.Forms.Label();
            this.clicksNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clicksCountText
            // 
            this.clicksCountText.AutoSize = true;
            this.clicksCountText.Font = new System.Drawing.Font("TechnicBold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clicksCountText.Location = new System.Drawing.Point(150, 98);
            this.clicksCountText.Name = "clicksCountText";
            this.clicksCountText.Size = new System.Drawing.Size(246, 41);
            this.clicksCountText.TabIndex = 0;
            this.clicksCountText.Text = "Clicks Count:";
            // 
            // clicksNumber
            // 
            this.clicksNumber.AutoSize = true;
            this.clicksNumber.Font = new System.Drawing.Font("TechnicBold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clicksNumber.Location = new System.Drawing.Point(384, 98);
            this.clicksNumber.Name = "clicksNumber";
            this.clicksNumber.Size = new System.Drawing.Size(38, 41);
            this.clicksNumber.TabIndex = 1;
            this.clicksNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.clicksNumber);
            this.Controls.Add(this.clicksCountText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_onClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clicksCountText;
        private Label clicksNumber;
    }
}