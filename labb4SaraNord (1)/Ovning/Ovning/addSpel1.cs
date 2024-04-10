using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovning
{
    public partial class addSpel1 : Form
    {
        public Spel Spel { get; set; }
        CSVFile kontroll;

        public addSpel1()
        {
            InitializeComponent();
            kontroll = new CSVFile();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void sparaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int parsedValue;

                if (!IdText.Text.StartsWith("3"))
                {
                    throw new Exception("Spel ska börja med 3");
                }
                if (!int.TryParse(IdText.Text, out parsedValue))
                {
                    throw new Exception("id ska bestå av siffror");
                }

                if (string.IsNullOrEmpty(IdText.Text))
                {
                    throw new Exception("Fyll i ID!!");
                }


                if (prisText.Text.Contains('-'))
                {
                    throw new Exception("Får inte vara negativ");
                }

                if (!int.TryParse(prisText.Text, out parsedValue))
                {
                    throw new Exception("pris ska bestå av siffror");
                }


                if (!int.TryParse(IdText.Text, out parsedValue))
                {
                    throw new Exception("pris ska bestå av siffror");
                }

                if (string.IsNullOrEmpty(namnTextSpel.Text))
                {
                    throw new Exception("Fyll i namn!!");
                }

                if (string.IsNullOrEmpty(prisText.Text))
                {
                    throw new Exception("Fyll i pris!!");
                }

                if (string.IsNullOrEmpty(antalText.Text))
                {
                    throw new Exception("Fyll i antal!");
                }
                if (!int.TryParse(antalText.Text, out parsedValue))
                {
                    throw new Exception("antal ska bestå av siffror");
                }

                if (antalText.Text.Contains('-'))
                {
                    throw new Exception("Får inte vara negativ");
                }

                foreach (var item in kontroll.spelLista)
                {
                    if (item.ID == int.Parse(IdText.Text))
                    {
                        throw new Exception("ID finns redan, välj ett unikt ID!");
                    }
                }



                Spel = new Spel();
                Spel.ID = int.Parse(IdText.Text);
                Spel.Namn = namnText.Text;
                Spel.Pris = prisText.Text;
                Spel.Plattform = plattformText.Text;
                Spel.Antal = int.Parse(antalText.Text);


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSpel1_Load(object sender, EventArgs e)
        {
            kontroll.ReadCSV();
        }
    }
}
