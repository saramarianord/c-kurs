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
    public partial class kassaKontroll : UserControl
    {
        BindingSource VarorSource;
        CSVFile kontroll;
 

        public Button AddKassaButton { get { return addVarukorgButton; } }
        public kassaKontroll()
        {
            InitializeComponent();
            kontroll = new CSVFile();
            VarorSource = new BindingSource();
            kassaView.DataSource = VarorSource;
          

        }

        public void kassaKontroll_Load(object sender, EventArgs e)
        {
            kontroll.ReadCSV();
           
        }

        public void ValdKnapp_CheckedChanged(object sender, EventArgs e)
        {
            if (BöckerButton.Checked)
            {
                kassaView.Refresh();
                kontroll.ReadCSV();
                VarorSource.DataSource = kontroll.BokLista;
                kassaView.Refresh();
            }

            if (FilmerButton.Checked)
            {
                kassaView.Refresh();
                kontroll.ReadCSV();
                VarorSource.DataSource = kontroll.filmLista;
                kassaView.Refresh();
            }
            if (SpelButton.Checked)
            {
                kassaView.Refresh();
                kontroll.ReadCSV();
                VarorSource.DataSource = kontroll.spelLista;
                kassaView.Refresh();
            }
        }

        public void kassaView_SelectionChanged(object sender, EventArgs e)
        {
           
            if (kassaView.SelectedRows.Count > 0)
            {

                var produkt = kassaView.SelectedRows[0].DataBoundItem;
                Type type = produkt.GetType();



                if (type.Name == "Book")
                {

                    Book Book = (Book)produkt;
                    if (Book.Antal == 0)
                    {
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();
                    }
                    else
                    {
                        addVarukorgButton.Enabled = true;
                        kassaView.Refresh();
                    }
                }
                if (type.Name == "Filmer")
                {

                    Filmer Filmer = (Filmer)produkt;
                    if (Filmer.Antal == 0)
                    {
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();
                    }
                    else
                    {
                        addVarukorgButton.Enabled = true;
                        kassaView.Refresh();
                    }
                }
                if (type.Name == "Spel")
                {

                    Spel Spel = (Spel)produkt;
                    if (Spel.Antal == 0)
                    {
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();
                    }
                    else
                    {
                        addVarukorgButton.Enabled = true;
                        kassaView.Refresh();
                    }
                }
            }
           

        }
       
            public void addVarukorgButton_Click(object sender, EventArgs e)
        {
           
            if (kassaView.SelectedRows.Count > 0)
            { 
               
                var produkt = kassaView.SelectedRows[0].DataBoundItem;
                Type type = produkt.GetType();
            
                if (type.Name == "Book")
                {
                    Book Book = (Book)produkt;
                    if(Book.Antal != 0)
                    {
                        CartList.Items.Add(Book);
                        köpButton.Enabled = true;
                        Book.Antal = Book.Antal - 1;
                        kassaView.Refresh();
                      
                    }
                    

                 

                    if (Book.Antal < 1)
                    {
                        MessageBox.Show("Det var den sista på lagret!");
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();
                        
                    }
                    
                    return;
                    
                }
                if (type.Name == "Filmer")
                {

                    Filmer Filmer = (Filmer)produkt;
                    if (Filmer.Antal == 0)
                    {
                        addVarukorgButton.Enabled = false;
                    }

                    Filmer.Antal = Filmer.Antal - 1;
                    kassaView.Refresh();

                    if (Filmer.Antal < 1)
                    {
                        MessageBox.Show("Det var den sista på lagret!");
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();

                    }
                    CartList.Items.Add(Filmer);
                    köpButton.Enabled = true;
                   
                    return;

                }
                if (type.Name == "Spel")
                {

                    Spel Spel = (Spel)produkt;
                    if (Spel.Antal == 0)
                    {
                        addVarukorgButton.Enabled = false;
                    }

                    Spel.Antal = Spel.Antal - 1;
                    kassaView.Refresh();

                    if (Spel.Antal < 1)
                    {
                        MessageBox.Show("Det var den sista på lagret!");
                        addVarukorgButton.Enabled = false;
                        kassaView.Refresh();

                    }
                    CartList.Items.Add(Spel);
                    köpButton.Enabled= true;
                    return;

                }
            }
           

        }

       public void köpButton_Click(object sender, EventArgs e)
        {
            foreach (var item in CartList.Items)
            {
                Type type = item.GetType();
                if (type.Name == "Book")
                {
                   var book = (Book)item;
                 
                    kassaView.Refresh();  
                }
                if (type.Name == "Filmer")
                {
                    var film = (Filmer)item;
                    film.Köpt = true;
                    kassaView.Refresh();
                }
                if (type.Name == "Spel")
                {
                    var spel = (Spel)item;
                    spel.Köpt = true;
                    kassaView.Refresh();
                 
                }
               
                kontroll.spara();
               
               
                

            }
            MessageBox.Show("Tack för ditt köp");
            CartList.Items.Clear();
        }
    }
    }
