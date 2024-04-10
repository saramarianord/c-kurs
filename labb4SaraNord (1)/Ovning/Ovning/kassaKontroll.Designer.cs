namespace Ovning
{
    partial class kassaKontroll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVarukorgButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.köpButton = new System.Windows.Forms.Button();
            this.CartList = new System.Windows.Forms.ListBox();
            this.SpelButton = new System.Windows.Forms.RadioButton();
            this.FilmerButton = new System.Windows.Forms.RadioButton();
            this.BöckerButton = new System.Windows.Forms.RadioButton();
            this.kassaView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kassaView)).BeginInit();
            this.SuspendLayout();
            // 
            // addVarukorgButton
            // 
            this.addVarukorgButton.Location = new System.Drawing.Point(497, 190);
            this.addVarukorgButton.Name = "addVarukorgButton";
            this.addVarukorgButton.Size = new System.Drawing.Size(150, 67);
            this.addVarukorgButton.TabIndex = 2;
            this.addVarukorgButton.Text = "Lägg i varukorg";
            this.addVarukorgButton.UseVisualStyleBackColor = true;
            this.addVarukorgButton.Click += new System.EventHandler(this.addVarukorgButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.köpButton);
            this.splitContainer1.Panel1.Controls.Add(this.CartList);
            this.splitContainer1.Panel1.Controls.Add(this.SpelButton);
            this.splitContainer1.Panel1.Controls.Add(this.FilmerButton);
            this.splitContainer1.Panel1.Controls.Add(this.BöckerButton);
            this.splitContainer1.Panel1.Controls.Add(this.addVarukorgButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.kassaView);
            this.splitContainer1.Size = new System.Drawing.Size(858, 533);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 3;
            // 
            // köpButton
            // 
            this.köpButton.Enabled = false;
            this.köpButton.Location = new System.Drawing.Point(693, 190);
            this.köpButton.Name = "köpButton";
            this.köpButton.Size = new System.Drawing.Size(147, 67);
            this.köpButton.TabIndex = 11;
            this.köpButton.Text = "Köp";
            this.köpButton.UseVisualStyleBackColor = true;
            this.köpButton.Click += new System.EventHandler(this.köpButton_Click);
            // 
            // CartList
            // 
            this.CartList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 20;
            this.CartList.Location = new System.Drawing.Point(0, 0);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(858, 184);
            this.CartList.TabIndex = 10;
            // 
            // SpelButton
            // 
            this.SpelButton.AutoSize = true;
            this.SpelButton.Location = new System.Drawing.Point(328, 227);
            this.SpelButton.Name = "SpelButton";
            this.SpelButton.Size = new System.Drawing.Size(66, 24);
            this.SpelButton.TabIndex = 9;
            this.SpelButton.TabStop = true;
            this.SpelButton.Text = "Spel";
            this.SpelButton.UseVisualStyleBackColor = true;
            this.SpelButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // FilmerButton
            // 
            this.FilmerButton.AutoSize = true;
            this.FilmerButton.Location = new System.Drawing.Point(183, 227);
            this.FilmerButton.Name = "FilmerButton";
            this.FilmerButton.Size = new System.Drawing.Size(77, 24);
            this.FilmerButton.TabIndex = 8;
            this.FilmerButton.TabStop = true;
            this.FilmerButton.Text = "Filmer";
            this.FilmerButton.UseVisualStyleBackColor = true;
            this.FilmerButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // BöckerButton
            // 
            this.BöckerButton.AutoSize = true;
            this.BöckerButton.Location = new System.Drawing.Point(41, 227);
            this.BöckerButton.Name = "BöckerButton";
            this.BöckerButton.Size = new System.Drawing.Size(84, 24);
            this.BöckerButton.TabIndex = 7;
            this.BöckerButton.TabStop = true;
            this.BöckerButton.Text = "Böcker";
            this.BöckerButton.UseVisualStyleBackColor = true;
            this.BöckerButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // kassaView
            // 
            this.kassaView.AllowUserToAddRows = false;
            this.kassaView.AllowUserToDeleteRows = false;
            this.kassaView.AllowUserToOrderColumns = true;
            this.kassaView.AllowUserToResizeColumns = false;
            this.kassaView.AllowUserToResizeRows = false;
            this.kassaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kassaView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kassaView.Location = new System.Drawing.Point(0, 23);
            this.kassaView.MultiSelect = false;
            this.kassaView.Name = "kassaView";
            this.kassaView.RowHeadersWidth = 62;
            this.kassaView.RowTemplate.Height = 28;
            this.kassaView.RowTemplate.ReadOnly = true;
            this.kassaView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kassaView.ShowCellErrors = false;
            this.kassaView.ShowRowErrors = false;
            this.kassaView.Size = new System.Drawing.Size(858, 240);
            this.kassaView.TabIndex = 0;
            this.kassaView.SelectionChanged += new System.EventHandler(this.kassaView_SelectionChanged);
            // 
            // kassaKontroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "kassaKontroll";
            this.Size = new System.Drawing.Size(858, 533);
            this.Load += new System.EventHandler(this.kassaKontroll_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kassaView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addVarukorgButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView kassaView;
        private System.Windows.Forms.RadioButton SpelButton;
        private System.Windows.Forms.RadioButton FilmerButton;
        private System.Windows.Forms.RadioButton BöckerButton;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Button köpButton;
    }
}
