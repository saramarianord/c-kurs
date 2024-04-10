namespace Ovning
{
    partial class addSpel1
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
            this.namnText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.namnTextSpel = new System.Windows.Forms.TextBox();
            this.prisText = new System.Windows.Forms.TextBox();
            this.plattformText = new System.Windows.Forms.TextBox();
            this.antalText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sparaButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // namnText
            // 
            this.namnText.AutoSize = true;
            this.namnText.Location = new System.Drawing.Point(24, 127);
            this.namnText.Name = "namnText";
            this.namnText.Size = new System.Drawing.Size(51, 20);
            this.namnText.TabIndex = 1;
            this.namnText.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pris";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(118, 73);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(232, 26);
            this.IdText.TabIndex = 8;
            // 
            // namnTextSpel
            // 
            this.namnTextSpel.Location = new System.Drawing.Point(118, 124);
            this.namnTextSpel.Name = "namnTextSpel";
            this.namnTextSpel.Size = new System.Drawing.Size(232, 26);
            this.namnTextSpel.TabIndex = 9;
            // 
            // prisText
            // 
            this.prisText.Location = new System.Drawing.Point(118, 166);
            this.prisText.Name = "prisText";
            this.prisText.Size = new System.Drawing.Size(232, 26);
            this.prisText.TabIndex = 10;
            // 
            // plattformText
            // 
            this.plattformText.Location = new System.Drawing.Point(118, 207);
            this.plattformText.Name = "plattformText";
            this.plattformText.Size = new System.Drawing.Size(232, 26);
            this.plattformText.TabIndex = 11;
            // 
            // antalText
            // 
            this.antalText.Location = new System.Drawing.Point(118, 260);
            this.antalText.Name = "antalText";
            this.antalText.Size = new System.Drawing.Size(232, 26);
            this.antalText.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Antal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plattform";
            // 
            // sparaButton
            // 
            this.sparaButton.Location = new System.Drawing.Point(413, 433);
            this.sparaButton.Name = "sparaButton";
            this.sparaButton.Size = new System.Drawing.Size(125, 67);
            this.sparaButton.TabIndex = 39;
            this.sparaButton.Text = "Save";
            this.sparaButton.UseVisualStyleBackColor = true;
            this.sparaButton.Click += new System.EventHandler(this.sparaButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(259, 433);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 67);
            this.cancelButton.TabIndex = 38;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addSpel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 591);
            this.Controls.Add(this.sparaButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.antalText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plattformText);
            this.Controls.Add(this.prisText);
            this.Controls.Add(this.namnTextSpel);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namnText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addSpel1";
            this.Text = "addSpel1";
            this.Load += new System.EventHandler(this.addSpel1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namnText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox namnTextSpel;
        private System.Windows.Forms.TextBox prisText;
        private System.Windows.Forms.TextBox plattformText;
        private System.Windows.Forms.TextBox antalText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sparaButton;
        private System.Windows.Forms.Button cancelButton;
    }
}