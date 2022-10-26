namespace Activity_15
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.displayNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayNumber
            // 
            this.displayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNumber.BackColor = System.Drawing.Color.Transparent;
            this.displayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayNumber.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.displayNumber.Location = new System.Drawing.Point(133, 252);
            this.displayNumber.Name = "displayNumber";
            this.displayNumber.Size = new System.Drawing.Size(167, 77);
            this.displayNumber.TabIndex = 1;
            this.displayNumber.Text = "error";
            this.displayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(435, 431);
            this.Controls.Add(this.displayNumber);
            this.DoubleBuffered = true;
            this.Name = "ResultForm";
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label displayNumber;
    }
}