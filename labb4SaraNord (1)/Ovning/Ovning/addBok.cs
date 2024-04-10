using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ovning
{
    public partial class addBok : Form
    { 
        public Book Book { get; set; }
        CSVFile kontroll;



        public addBok()
        {
            InitializeComponent();
            kontroll = new CSVFile();
        }

        public void cancelButton_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
            Close();
        }

        public void addBok_Load(object sender, EventArgs e)
        {
            kontroll.ReadCSV();
            

        }

        private void sparaButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int parsedValue;
                
             
                
               
                    
                if (!BokIdTextBox.Text.StartsWith("1"))
                {
                    throw new Exception("Böcker ska börja med 1");
                }

                   
                if (string.IsNullOrEmpty(BokIdTextBox.Text))
                {
                    throw new Exception("Fyll i ID!!");
                }

                if (!int.TryParse(BokIdTextBox.Text, out parsedValue))
                {
                    throw new Exception("id ska bestå av siffror");
                }

                if (bokPrisTextBox.Text.Contains("-"))
                {
                    throw new Exception("Får inte vara negativ");
                }
                if (!int.TryParse(bokPrisTextBox.Text, out parsedValue))
                {
                    throw new Exception("pris ska bestå av siffror");
                }

                if (BokAntalTextBox.Text.Contains("-"))
                {
                    throw new Exception("Får inte vara negativ");
                }

                if (string.IsNullOrEmpty(BokAntalTextBox.Text))
                {
                    throw new Exception("fyll i antal");
                }
                if (!int.TryParse(BokAntalTextBox.Text, out parsedValue))
                {
                    throw new Exception("antal ska bestå av siffror");
                }

                if (string.IsNullOrEmpty(bokNamnTextBox.Text))
                {
                    throw new Exception("Fyll i namn!!");
                }

                if (string.IsNullOrEmpty(bokPrisTextBox.Text))
                {
                    throw new Exception("Fyll i pris!!");
                }

                if (string.IsNullOrEmpty(BokAntalTextBox.Text))
                {
                    throw new Exception("Fyll i antal!");
                }
                foreach(var item in kontroll.BokLista) 
                {
                    if (item.ID == int.Parse(BokIdTextBox.Text))
                    {
                        throw new Exception("ID finns redan, välj ett unikt ID!");
                    }
                }
                    Book = new Book();
                    Book.ID = int.Parse(BokIdTextBox.Text);
                    Book.Namn = bokNamnTextBox.Text;
                    Book.Pris = bokPrisTextBox.Text;
                    Book.Författare = BokFörfattareTextBox.Text;
                    Book.Genre = BokGenreTextBox.Text;
                    Book.Format = BokFormatTextBox.Text;
                    Book.Språk = BokSpråkTextBox.Text;
                    Book.Antal = int.Parse(BokAntalTextBox.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
