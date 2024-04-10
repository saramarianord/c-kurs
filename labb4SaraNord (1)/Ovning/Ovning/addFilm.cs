using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovning
{
    public partial class addFilm : Form
    {
        public Filmer Filmer { get; set; }
        CSVFile kontroll;
        public addFilm()
        {
            InitializeComponent();
            kontroll = new CSVFile();
        }

        private void sparaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int parsedValue;

                if (!IDFilmtext.Text.StartsWith("2")) {
                    throw new Exception("Filmer ska börja med 2");
                }
                if (string.IsNullOrEmpty(IDFilmtext.Text))
                {
                    throw new Exception("Fyll i ID!!");
                }

                if (!int.TryParse(IDFilmtext.Text, out parsedValue))
                {
                    throw new Exception("id ska bestå av siffror");
                }

                if (SpeltidFilmText.Text.Contains("-")) {
                    throw new Exception("Får inte vara negativ");
                }
                if (PrisFilmText.Text.Contains('-'))
                {
                    throw new Exception("Får inte vara negativ");
                }

                if (!int.TryParse(PrisFilmText.Text, out parsedValue))
                {
                    throw new Exception("pris ska bestå av siffror");
                }


                if (string.IsNullOrEmpty(NamnFilmText.Text))
                {
                    throw new Exception("Fyll i namn!!");
                }

                if (string.IsNullOrEmpty(PrisFilmText.Text))
                {
                    throw new Exception("Fyll i pris!!");
                }

                if (string.IsNullOrEmpty(AntalFilmText.Text))
                {
                    throw new Exception("Fyll i antal!");
                }
                if (!int.TryParse(AntalFilmText.Text, out parsedValue))
                {
                    throw new Exception("antal ska bestå av siffror");
                }

                if (AntalFilmText.Text.Contains('-'))
                {
                    throw new Exception("Får inte vara negativ");
                }

                foreach (var item in kontroll.filmLista)
                {
                    if (item.ID == int.Parse(IDFilmtext.Text))
                    {
                        throw new Exception("ID finns redan, välj ett unikt ID!");
                    }
                }



                Filmer = new Filmer();
                Filmer.ID = int.Parse(IDFilmtext.Text);
                Filmer.Namn = NamnFilmText.Text;
                Filmer.Pris = PrisFilmText.Text;
                Filmer.Format = FormatFilmText.Text;
                Filmer.Speltid = SpeltidFilmText.Text;
                Filmer.Antal = int.Parse(AntalFilmText.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addFilm_Load(object sender, EventArgs e)
        {
            kontroll.ReadCSV();
        }
    
    }
}
