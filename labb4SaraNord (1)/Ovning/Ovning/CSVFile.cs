using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovning
{
    public class CSVFile
    {
        public BindingList<Book> BokLista { get; set; }
        public BindingList<Filmer> filmLista { get; set; }
        public BindingList<Spel> spelLista { get; set; }

        public string Path = Directory.GetCurrentDirectory();

        public CSVFile()
        {
            BokLista = new BindingList<Book>();
            filmLista = new BindingList<Filmer>();
            spelLista = new BindingList<Spel>();
        }


        // https://stackoverflow.com/questions/56458045/c-sharp-read-csv-from-stream-in-handler-class
        // https://www.tutorialspoint.com/how-to-read-a-csv-file-and-store-the-values-into-an-array-in-chash?fbclid=IwAR2N2cMxzE64YL_hBxuLE1th3cAZgBR5_mQfOowwwuzS0c73xlyaclLPzhE */

        public void ReadCSV() 
        {
            try
            {
                BokLista.Clear();
                filmLista.Clear();
                spelLista.Clear();
                using (var reader = new StreamReader("Bok1.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string rad = reader.ReadLine();
                        var kolumn = rad.Split(',');
                        
                        if (kolumn[0].StartsWith("1"))
                        {
                            
                            Book book = new Book(int.Parse(kolumn[0]),
                                kolumn[1],
                                kolumn[2],
                                kolumn[3],
                                kolumn[4],
                                kolumn[5],
                                kolumn[6],
                                int.Parse(kolumn[7]));
                                BokLista.Add(book);
                        }
                        else if (kolumn[0].StartsWith("2"))
                        {
                            Filmer film = new Filmer(int.Parse(kolumn[0]),
                                kolumn[1],
                                kolumn[2],
                                kolumn[3],
                                kolumn[4],
                                int.Parse(kolumn[5]));
                                filmLista.Add(film);
                        }
                        else if (kolumn[0].StartsWith("3"))
                        {
                            Spel spel = new Spel(int.Parse(kolumn[0]),
                                kolumn[1],
                                kolumn[2],
                                kolumn[3],
                                int.Parse(kolumn[4]));
                                spelLista.Add(spel);
                        }
                    }
                }
               
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }

        }
      


        // https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-8.0&fbclid=IwAR3Hgr1DeRmtKjObzF4l3HI9CLklctST8Ou_BWT6x7xKyeoesg1GW8FQe-Q
        public void spara()
        {
           
            var bocker = BokLista.ToList();
            var spel = spelLista.ToList();
            var film = filmLista.ToList();
            using (var skriv = new StreamWriter(Path + "/Bok1.csv"))
            {
                foreach (var b in bocker)
                {
                    if (b.ID >= 1){
                        skriv.WriteLine(b.ID.ToString() + "," + b.Namn.ToString() + "," + b.Pris.ToString() + "," + b.Författare.ToString() + "," + b.Genre.ToString() + "," + b.Format.ToString() + "," + b.Språk.ToString() + "," + b.Antal.ToString());
                    }
                }
                foreach (var s in spel)
                {
                    if (s.ID >= 3)
                    {
                        skriv.WriteLine(s.ID.ToString() + "," + s.Namn.ToString() + "," + s.Pris.ToString() + ","  + s.Plattform.ToString() + "," + s.Antal.ToString());
                    }
                }
                foreach (var f in film)
                {
                    if (f.ID >= 2)
                    {
                        skriv.WriteLine(f.ID.ToString() + "," + f.Namn.ToString() + "," + f.Pris.ToString() + "," + f.Format.ToString() + "," + f.Speltid.ToString() +  "," + f.Antal.ToString());
                    }
                }
            }
        }

      
    }

}


                       


