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
    public partial class ManagementControll : UserControl
    {
        BindingSource VarorSource;
        CSVFile kontroll;
        public ManagementControll()
        {
            InitializeComponent();
            kontroll = new CSVFile();
            VarorSource = new BindingSource();
            ManagementView.DataSource = VarorSource;
        }



       

        private void sparaButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (ManagementView.SelectedRows.Count > 0)
                {
                    var produkt = ManagementView.SelectedRows[0].DataBoundItem;
                    Type type = produkt.GetType();

                    if (antalText.Text.Contains("-"))
                    {
                        throw new Exception("får inte vara negativt");
                    }
                    if (type.Name == "Book")
                    {
                        Book Book = (Book)produkt;
                        int leverans = int.Parse(antalText.Text);
                        foreach (Book bok in kontroll.BokLista)
                        {
                            if (bok.ID == Book.ID)
                            {
                                bok.Antal += leverans;
                            }
                        }

                        kontroll.spara();
                    }


                    if (type.Name == "Filmer")
                    {
                        Filmer Filmer = (Filmer)produkt;
                        int leverans = int.Parse(antalText.Text);
                        foreach (Filmer film in kontroll.filmLista)
                        {
                            if (film.ID == Filmer.ID)
                            {
                                film.Antal += leverans;
                            }
                        }
                        kontroll.spara();
                    }

                    if (type.Name == "Spel")
                    {
                        Spel Spel = (Spel)produkt;
                        int leverans = int.Parse(antalText.Text);
                        foreach (Spel spel in kontroll.spelLista)
                        {
                            if (spel.ID == Spel.ID)
                            {
                                spel.Antal += leverans;
                            }
                        }
                    }
                    kontroll.spara();

                }

            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            ManagementView.Refresh();
         

        }

        private void antalText_TextChanged(object sender, EventArgs e)
        {
            sparaButton.Enabled = true;
            
        }

        private void ValdKnapp_CheckedChanged(object sender, EventArgs e)
        {
            if (BöckerButton.Checked)
            {
                ManagementView.Refresh();
                VarorSource.DataSource = kontroll.BokLista;
               addBook.Enabled = true;
                addFilm.Enabled = false;
                addSpel.Enabled = false;
               
            }
            if (FilmerButton.Checked)
            {
                ManagementView.Refresh();
                VarorSource.DataSource = kontroll.filmLista;
                addFilm.Enabled = true;
                addSpel.Enabled = false;
                addBook.Enabled = false;

            }
            if (SpelButton.Checked)
            {
                ManagementView.Refresh();
                VarorSource.DataSource = kontroll.spelLista;
                addSpel.Enabled = true;
                addBook.Enabled = false;
                addFilm.Enabled = false;
            }
        }

        private void ManagementControll_Load(object sender, EventArgs e)
        {
            kontroll.ReadCSV();
        }

        private void addBook_Click_1(object sender, EventArgs e)
        {
            addBok laggTillBok = new addBok();
            if (laggTillBok.ShowDialog() == DialogResult.OK)
            {
                VarorSource.Add(laggTillBok.Book);
                kontroll.spara();
            }
            else
            {

            }

        }

        private void addSpel_Click(object sender, EventArgs e)
        {
            addSpel1 laggTillSpel = new addSpel1();
            if (laggTillSpel.ShowDialog() == DialogResult.OK)
            {
                VarorSource.Add(laggTillSpel.Spel);
                kontroll.spara();
            }
            else
            {

            }

        }

        private void addFilm_Click(object sender, EventArgs e)
        {
            addFilm laggTillFilm = new addFilm();
            if (laggTillFilm.ShowDialog() == DialogResult.OK)
            {
                VarorSource.Add(laggTillFilm.Filmer);
                kontroll.spara();
            }
            else
            {

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ManagementView.SelectedRows.Count > 0)
            {
                var produkt = ManagementView.SelectedRows[0].DataBoundItem;
                Type type = produkt.GetType();
                int vald = 0;

                if (type.Name == "Book")
                {
                    Book bok = (Book)produkt;
                    vald = bok.Antal;
                }
                if(type.Name == "Filmer")
                {
                    Filmer film =(Filmer)produkt;
                    vald = film.Antal;
                }
                if (type.Name == "Spel")
                {
                    Spel spel = (Spel)produkt;
                    vald = spel.Antal;
                }


                if (vald > 0) //om saldot inte är 0
                {
                    var meddelande = MessageBox.Show("Vill du ta bort varan?", "Message", MessageBoxButtons.YesNo);
                    if (meddelande == DialogResult.Yes)
                    {
                        if (type.Name == "Book")
                        {
                            Book bok = (Book)produkt;
                            VarorSource.Remove(bok);
                        }
                        if (type.Name == "Filmer")
                        {
                            Filmer film = (Filmer)produkt;
                            VarorSource.Remove(film);
                        }
                        if (type.Name == "Spel")
                        {
                            Spel spel = (Spel)produkt;
                            VarorSource.Remove(spel);
                        }

                    }
                    else if (meddelande == DialogResult.No)
                    {
                        return;
                    }
                }


                if (type.Name == "Book")
                {
                    Book bok = (Book)produkt;
                    VarorSource.Remove(bok);
                }

                if (type.Name == "Filmer")
                {
                    Filmer film = (Filmer)produkt;
                    VarorSource.Remove(film);
                }
                if (type.Name == "Spel")
                {
                    Spel spel = (Spel)produkt;
                    VarorSource.Remove(spel);
                }
                kontroll.spara();
                ManagementView.Refresh();

            }
        }

       
    }
}


       