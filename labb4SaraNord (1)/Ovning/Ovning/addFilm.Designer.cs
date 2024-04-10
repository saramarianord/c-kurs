namespace Ovning
{
    partial class addFilm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDFilmtext = new System.Windows.Forms.TextBox();
            this.NamnFilmText = new System.Windows.Forms.TextBox();
            this.PrisFilmText = new System.Windows.Forms.TextBox();
            this.FormatFilmText = new System.Windows.Forms.TextBox();
            this.SpeltidFilmText = new System.Windows.Forms.TextBox();
            this.AntalFilmText = new System.Windows.Forms.TextBox();
            this.sparaButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Speltid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Antal";
            // 
            // IDFilmtext
            // 
            this.IDFilmtext.Location = new System.Drawing.Point(143, 78);
            this.IDFilmtext.Name = "IDFilmtext";
            this.IDFilmtext.Size = new System.Drawing.Size(296, 26);
            this.IDFilmtext.TabIndex = 6;
            // 
            // NamnFilmText
            // 
            this.NamnFilmText.Location = new System.Drawing.Point(143, 117);
            this.NamnFilmText.Name = "NamnFilmText";
            this.NamnFilmText.Size = new System.Drawing.Size(296, 26);
            this.NamnFilmText.TabIndex = 7;
            // 
            // PrisFilmText
            // 
            this.PrisFilmText.Location = new System.Drawing.Point(143, 159);
            this.PrisFilmText.Name = "PrisFilmText";
            this.PrisFilmText.Size = new System.Drawing.Size(296, 26);
            this.PrisFilmText.TabIndex = 8;
            // 
            // FormatFilmText
            // 
            this.FormatFilmText.Location = new System.Drawing.Point(143, 203);
            this.FormatFilmText.Name = "FormatFilmText";
            this.FormatFilmText.Size = new System.Drawing.Size(296, 26);
            this.FormatFilmText.TabIndex = 9;
            // 
            // SpeltidFilmText
            // 
            this.SpeltidFilmText.Location = new System.Drawing.Point(143, 244);
            this.SpeltidFilmText.Name = "SpeltidFilmText";
            this.SpeltidFilmText.Size = new System.Drawing.Size(296, 26);
            this.SpeltidFilmText.TabIndex = 10;
            // 
            // AntalFilmText
            // 
            this.AntalFilmText.Location = new System.Drawing.Point(143, 283);
            this.AntalFilmText.Name = "AntalFilmText";
            this.AntalFilmText.Size = new System.Drawing.Size(296, 26);
            this.AntalFilmText.TabIndex = 11;
            // 
            // sparaButton
            // 
            this.sparaButton.Location = new System.Drawing.Point(466, 423);
            this.sparaButton.Name = "sparaButton";
            this.sparaButton.Size = new System.Drawing.Size(125, 67);
            this.sparaButton.TabIndex = 41;
            this.sparaButton.Text = "Save";
            this.sparaButton.UseVisualStyleBackColor = true;
            this.sparaButton.Click += new System.EventHandler(this.sparaButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 423);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 67);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 535);
            this.Controls.Add(this.sparaButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AntalFilmText);
            this.Controls.Add(this.SpeltidFilmText);
            this.Controls.Add(this.FormatFilmText);
            this.Controls.Add(this.PrisFilmText);
            this.Controls.Add(this.NamnFilmText);
            this.Controls.Add(this.IDFilmtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addFilm";
            this.Text = "addFilm";
            this.Load += new System.EventHandler(this.addFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDFilmtext;
        private System.Windows.Forms.TextBox NamnFilmText;
        private System.Windows.Forms.TextBox PrisFilmText;
        private System.Windows.Forms.TextBox FormatFilmText;
        private System.Windows.Forms.TextBox SpeltidFilmText;
        private System.Windows.Forms.TextBox AntalFilmText;
        private System.Windows.Forms.Button sparaButton;
        private System.Windows.Forms.Button cancelButton;
    }
}