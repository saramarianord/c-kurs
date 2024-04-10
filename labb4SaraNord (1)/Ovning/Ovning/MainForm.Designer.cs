namespace Ovning
{
    partial class MainForm
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
            this.kassaTab = new System.Windows.Forms.TabControl();
            this.ManagementTab = new System.Windows.Forms.TabPage();
            this.LendingTab = new System.Windows.Forms.TabPage();
            this.kassaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // kassaTab
            // 
            this.kassaTab.Controls.Add(this.ManagementTab);
            this.kassaTab.Controls.Add(this.LendingTab);
            this.kassaTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kassaTab.Location = new System.Drawing.Point(0, 0);
            this.kassaTab.Name = "kassaTab";
            this.kassaTab.SelectedIndex = 0;
            this.kassaTab.Size = new System.Drawing.Size(992, 624);
            this.kassaTab.TabIndex = 0;
            // 
            // ManagementTab
            // 
            this.ManagementTab.Location = new System.Drawing.Point(4, 29);
            this.ManagementTab.Name = "ManagementTab";
            this.ManagementTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManagementTab.Size = new System.Drawing.Size(984, 591);
            this.ManagementTab.TabIndex = 0;
            this.ManagementTab.Text = "Management";
            this.ManagementTab.UseVisualStyleBackColor = true;
            this.ManagementTab.Click += new System.EventHandler(this.ManagementTab_Click);
            // 
            // LendingTab
            // 
            this.LendingTab.Location = new System.Drawing.Point(4, 29);
            this.LendingTab.Name = "LendingTab";
            this.LendingTab.Padding = new System.Windows.Forms.Padding(3);
            this.LendingTab.Size = new System.Drawing.Size(984, 591);
            this.LendingTab.TabIndex = 1;
            this.LendingTab.Text = "Lending ";
            this.LendingTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.kassaTab);
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.kassaTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl kassaTab;
        private System.Windows.Forms.TabPage ManagementTab;
        private System.Windows.Forms.TabPage LendingTab;
    }
}

