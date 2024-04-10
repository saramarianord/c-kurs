namespace Ovning
{
    partial class ManagementControll
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
            this.components = new System.ComponentModel.Container();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.SpelButton = new System.Windows.Forms.RadioButton();
            this.FilmerButton = new System.Windows.Forms.RadioButton();
            this.BöckerButton = new System.Windows.Forms.RadioButton();
            this.ButtonSplitter = new System.Windows.Forms.SplitContainer();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ManagementView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addSpel = new System.Windows.Forms.Button();
            this.addFilm = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.antalText = new System.Windows.Forms.TextBox();
            this.antalLabel = new System.Windows.Forms.Label();
            this.sparaButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSplitter)).BeginInit();
            this.ButtonSplitter.Panel2.SuspendLayout();
            this.ButtonSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagementView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.SpelButton);
            this.MainSplit.Panel1.Controls.Add(this.FilmerButton);
            this.MainSplit.Panel1.Controls.Add(this.BöckerButton);
            this.MainSplit.Panel1.Controls.Add(this.ButtonSplitter);
            this.MainSplit.Panel1.Controls.Add(this.ManagementView);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.label1);
            this.MainSplit.Panel2.Controls.Add(this.addSpel);
            this.MainSplit.Panel2.Controls.Add(this.addFilm);
            this.MainSplit.Panel2.Controls.Add(this.addBook);
            this.MainSplit.Panel2.Controls.Add(this.antalText);
            this.MainSplit.Panel2.Controls.Add(this.antalLabel);
            this.MainSplit.Panel2.Controls.Add(this.sparaButton);
            
            this.MainSplit.Size = new System.Drawing.Size(904, 555);
            this.MainSplit.SplitterDistance = 650;
            this.MainSplit.TabIndex = 0;
            // 
            // SpelButton
            // 
            this.SpelButton.AutoSize = true;
            this.SpelButton.Location = new System.Drawing.Point(307, 22);
            this.SpelButton.Name = "SpelButton";
            this.SpelButton.Size = new System.Drawing.Size(66, 24);
            this.SpelButton.TabIndex = 6;
            this.SpelButton.TabStop = true;
            this.SpelButton.Text = "Spel";
            this.SpelButton.UseVisualStyleBackColor = true;
            this.SpelButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // FilmerButton
            // 
            this.FilmerButton.AutoSize = true;
            this.FilmerButton.Location = new System.Drawing.Point(162, 22);
            this.FilmerButton.Name = "FilmerButton";
            this.FilmerButton.Size = new System.Drawing.Size(77, 24);
            this.FilmerButton.TabIndex = 5;
            this.FilmerButton.TabStop = true;
            this.FilmerButton.Text = "Filmer";
            this.FilmerButton.UseVisualStyleBackColor = true;
            this.FilmerButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // BöckerButton
            // 
            this.BöckerButton.AutoSize = true;
            this.BöckerButton.Location = new System.Drawing.Point(20, 22);
            this.BöckerButton.Name = "BöckerButton";
            this.BöckerButton.Size = new System.Drawing.Size(84, 24);
            this.BöckerButton.TabIndex = 4;
            this.BöckerButton.TabStop = true;
            this.BöckerButton.Text = "Böcker";
            this.BöckerButton.UseVisualStyleBackColor = true;
            this.BöckerButton.CheckedChanged += new System.EventHandler(this.ValdKnapp_CheckedChanged);
            // 
            // ButtonSplitter
            // 
            this.ButtonSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSplitter.IsSplitterFixed = true;
            this.ButtonSplitter.Location = new System.Drawing.Point(4, 442);
            this.ButtonSplitter.Name = "ButtonSplitter";
            // 
            // ButtonSplitter.Panel2
            // 
            this.ButtonSplitter.Panel2.Controls.Add(this.RemoveButton);
            this.ButtonSplitter.Size = new System.Drawing.Size(643, 110);
            this.ButtonSplitter.SplitterDistance = 144;
            this.ButtonSplitter.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(495, 110);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ManagementView
            // 
            this.ManagementView.AllowUserToAddRows = false;
            this.ManagementView.AllowUserToDeleteRows = false;
            this.ManagementView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagementView.Location = new System.Drawing.Point(-3, 63);
            this.ManagementView.MultiSelect = false;
            this.ManagementView.Name = "ManagementView";
            this.ManagementView.ReadOnly = true;
            this.ManagementView.RowHeadersWidth = 62;
            this.ManagementView.RowTemplate.Height = 28;
            this.ManagementView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManagementView.ShowCellErrors = false;
            this.ManagementView.ShowCellToolTips = false;
            this.ManagementView.ShowEditingIcon = false;
            this.ManagementView.ShowRowErrors = false;
            this.ManagementView.Size = new System.Drawing.Size(650, 373);
            this.ManagementView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ändra antal:";
            // 
            // addSpel
            // 
            this.addSpel.Enabled = false;
            this.addSpel.Location = new System.Drawing.Point(33, 166);
            this.addSpel.Name = "addSpel";
            this.addSpel.Size = new System.Drawing.Size(119, 40);
            this.addSpel.TabIndex = 20;
            this.addSpel.Text = "Lägg till spel";
            this.addSpel.UseVisualStyleBackColor = true;
            this.addSpel.Click += new System.EventHandler(this.addSpel_Click);
            // 
            // addFilm
            // 
            this.addFilm.Enabled = false;
            this.addFilm.Location = new System.Drawing.Point(33, 109);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(119, 36);
            this.addFilm.TabIndex = 19;
            this.addFilm.Text = "Lägg till film";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.addFilm_Click);
            // 
            // addBook
            // 
            this.addBook.Enabled = false;
            this.addBook.Location = new System.Drawing.Point(33, 48);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(119, 38);
            this.addBook.TabIndex = 18;
            this.addBook.Text = "Lägg till bok";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click_1);
            // 
            // antalText
            // 
            this.antalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.antalText.Location = new System.Drawing.Point(81, 313);
            this.antalText.Name = "antalText";
            this.antalText.Size = new System.Drawing.Size(123, 26);
            this.antalText.TabIndex = 17;
            this.antalText.TextChanged += new System.EventHandler(this.antalText_TextChanged);
            // 
            // antalLabel
            // 
            this.antalLabel.AutoSize = true;
            this.antalLabel.Location = new System.Drawing.Point(29, 319);
            this.antalLabel.Name = "antalLabel";
            this.antalLabel.Size = new System.Drawing.Size(46, 20);
            this.antalLabel.TabIndex = 16;
            this.antalLabel.Text = "Antal";
            // 
            // sparaButton
            // 
            this.sparaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sparaButton.Enabled = false;
            this.sparaButton.Location = new System.Drawing.Point(99, 361);
            this.sparaButton.Name = "sparaButton";
            this.sparaButton.Size = new System.Drawing.Size(89, 39);
            this.sparaButton.TabIndex = 14;
            this.sparaButton.Text = "Spara";
            this.sparaButton.UseVisualStyleBackColor = true;
            this.sparaButton.Click += new System.EventHandler(this.sparaButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManagementControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplit);
            this.Name = "ManagementControll";
            this.Size = new System.Drawing.Size(904, 555);
            this.Load += new System.EventHandler(this.ManagementControll_Load);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel1.PerformLayout();
            this.MainSplit.Panel2.ResumeLayout(false);
            this.MainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.ButtonSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSplitter)).EndInit();
            this.ButtonSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagementView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.DataGridView ManagementView;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer ButtonSplitter;
        private System.Windows.Forms.RadioButton SpelButton;
        private System.Windows.Forms.RadioButton FilmerButton;
        private System.Windows.Forms.RadioButton BöckerButton;
        private System.Windows.Forms.Button sparaButton;
        private System.Windows.Forms.TextBox antalText;
        private System.Windows.Forms.Label antalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSpel;
        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.Button addBook;
    }
}
