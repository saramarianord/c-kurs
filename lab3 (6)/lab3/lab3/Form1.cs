using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab3
{
    public partial class Form1 : Form
    {
        private string fileName = null;
      
        public Form1()
        {
            InitializeComponent();
            titel();

        }

        private void titel()
        {
            string fil;
            if(string.IsNullOrEmpty(fileName))
                fil = "Untitled.txt";
            else
                fil = Path.GetFileName(fileName);
            Text = fil + " - Notepad";
        }


        private void nyFil_Click(object sender, EventArgs e)
        {
         
         if (textBox1.Text != string.Empty && this.Text.StartsWith("*"))
            {
                var varning = MessageBox.Show(
                     "Vill du spara?",
                     "Text Editor",
                     MessageBoxButtons.YesNoCancel,
                     MessageBoxIcon.Information
                     );
                if (varning == DialogResult.Yes)
                {
                    spara_Click(sender, e);
                    textBox1.Clear();            
                }
                else if(varning == DialogResult.No)
                {
                    textBox1.Clear();                 
                }
            }else{
             textBox1.Clear();
            }
         
            fileName = null;
            titel();
        }


        private void öppna_Click(object sender, EventArgs e)
        {


            if (this.Text.StartsWith("*"))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = MessageBox.Show("Vill du spara?", "Text Editor", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    sparaSomToolStripMenuItem_Click(sender, e);
                }
                if (result == DialogResult.No)
                {
                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFileDialog1.Filter = "txt files (*.txt)|*.txt";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                        fileName = openFileDialog1.FileName;
                        titel();
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    fileName = openFileDialog1.FileName;
                    titel();
                }
            }
        }
        private void spara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                sparaSomToolStripMenuItem_Click(sender, e);
                titel();
            }
            else
            {
                // Spara filen
                StreamWriter streamWriter = new StreamWriter(fileName);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
                titel();
                
            }
        }


        private void avsluta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Vill du spara?", "Text Editor", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    spara_Click(sender, e);
                    Application.Exit();
                }
                 if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.StartsWith("*"))
            {
                this.Text = "*" + this.Text;
                
            }
        }

            private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
            {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBox1.Text);
                titel();
               

            }
            }

     
    }
    }

