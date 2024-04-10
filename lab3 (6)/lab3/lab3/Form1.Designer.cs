namespace lab3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fil = new System.Windows.Forms.ToolStripMenuItem();
            this.nyFil = new System.Windows.Forms.ToolStripMenuItem();
            this.öppna = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spara = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fil});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fil
            // 
            this.fil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyFil,
            this.öppna,
            this.sparaSomToolStripMenuItem,
            this.spara,
            this.avsluta});
            this.fil.Name = "fil";
            this.fil.Size = new System.Drawing.Size(31, 20);
            this.fil.Text = "Fil";
            // 
            // nyFil
            // 
            this.nyFil.Name = "nyFil";
            this.nyFil.Size = new System.Drawing.Size(129, 22);
            this.nyFil.Text = "Ny fil";
            this.nyFil.Click += new System.EventHandler(this.nyFil_Click);
            // 
            // öppna
            // 
            this.öppna.Name = "öppna";
            this.öppna.Size = new System.Drawing.Size(129, 22);
            this.öppna.Text = "Öppna";
            this.öppna.Click += new System.EventHandler(this.öppna_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // spara
            // 
            this.spara.Name = "spara";
            this.spara.Size = new System.Drawing.Size(129, 22);
            this.spara.Text = "Spara";
            this.spara.Click += new System.EventHandler(this.spara_Click);
            // 
            // avsluta
            // 
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(129, 22);
            this.avsluta.Text = "Avsluta";
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 417);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text documents|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fil;
        private System.Windows.Forms.ToolStripMenuItem nyFil;
        private System.Windows.Forms.ToolStripMenuItem öppna;
        private System.Windows.Forms.ToolStripMenuItem spara;
        private System.Windows.Forms.ToolStripMenuItem avsluta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
    }
}

