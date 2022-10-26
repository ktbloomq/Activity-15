namespace Activity_15
{
    partial class LuckyNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.yearPrompt = new System.Windows.Forms.ComboBox();
            this.monthprompt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dayPrompt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorPrompt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year";
            // 
            // yearPrompt
            // 
            this.yearPrompt.FormattingEnabled = true;
            this.yearPrompt.Location = new System.Drawing.Point(174, 13);
            this.yearPrompt.Name = "yearPrompt";
            this.yearPrompt.Size = new System.Drawing.Size(161, 24);
            this.yearPrompt.TabIndex = 2;
            // 
            // monthprompt
            // 
            this.monthprompt.FormattingEnabled = true;
            this.monthprompt.Location = new System.Drawing.Point(174, 43);
            this.monthprompt.Name = "monthprompt";
            this.monthprompt.Size = new System.Drawing.Size(161, 24);
            this.monthprompt.TabIndex = 4;
            //this.monthprompt.SelectedIndexChanged += new System.EventHandler(this.monthprompt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your birth month";
            // 
            // dayPrompt
            // 
            this.dayPrompt.FormattingEnabled = true;
            this.dayPrompt.Location = new System.Drawing.Point(174, 73);
            this.dayPrompt.Name = "dayPrompt";
            this.dayPrompt.Size = new System.Drawing.Size(161, 24);
            this.dayPrompt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your birth day";
            // 
            // colorPrompt
            // 
            this.colorPrompt.FormattingEnabled = true;
            this.colorPrompt.Location = new System.Drawing.Point(174, 103);
            this.colorPrompt.Name = "colorPrompt";
            this.colorPrompt.Size = new System.Drawing.Size(161, 24);
            this.colorPrompt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter your favorite color";
            // 
            // GetNumber
            // 
            this.GetNumber.Location = new System.Drawing.Point(15, 139);
            this.GetNumber.Name = "GetNumber";
            this.GetNumber.Size = new System.Drawing.Size(320, 39);
            this.GetNumber.TabIndex = 9;
            this.GetNumber.Text = "Get your lucky number";
            this.GetNumber.UseVisualStyleBackColor = true;
            this.GetNumber.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // LuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 190);
            this.Controls.Add(this.GetNumber);
            this.Controls.Add(this.colorPrompt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dayPrompt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthprompt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearPrompt);
            this.Controls.Add(this.label1);
            this.Name = "LuckyNumbers";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearPrompt;
        private System.Windows.Forms.ComboBox monthprompt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dayPrompt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colorPrompt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetNumber;
    }
}

