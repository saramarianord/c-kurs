using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartaLottoButton_Click(object sender, EventArgs e)
        {
            try

            {
                // Mina variabler! + inläsning av vad användaren har skrivit i textboxarna!
                int[] lottoNummer = new int[7];
                int antalDrag = 0;
                int antal5Ratt = 0;
                int antal6Ratt = 0;
                int antal7Ratt = 0;

                lottoNummer[0] = int.Parse(ruta1.Text);
                lottoNummer[1] = int.Parse(ruta2.Text);
                lottoNummer[2] = int.Parse(ruta3.Text);
                lottoNummer[3] = int.Parse(ruta4.Text);
                lottoNummer[4] = int.Parse(ruta5.Text);
                lottoNummer[5] = int.Parse(rutasex.Text);
                lottoNummer[6] = int.Parse(rutasju.Text);
                antalDrag = int.Parse(antaldragningar.Text);



                //felhantering startar
                //kontrollera unika tal
                // Kontrollera att lottoraden innehåller unika tal och är mellan 1-35
                if (lottoNummer.Distinct().Count() != 7)
                {
                    throw new Exception("det ska vara unika tal");

                }

                if (antalDrag > 999999)
                {
                    throw new Exception("maxdrag är 999999!");
                }
                for (int x = 0; x < lottoNummer.Length; x++)
                {
                    if (lottoNummer[x] < 1 || lottoNummer[x] > 36)
                    {
                        throw new Exception("talen ska vara mellan 1 och 35");
                    }
                    else
                    {
                        // Har de inmatade värderna klarat sig genom valideringen, så kan vi starta lottot!. 

                        Random rnd = new Random();
                        int[] slumpLottoNummer = new int[7];

                        for (int i = 0; i < antalDrag; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                slumpLottoNummer[j] = rnd.Next(1, 36);

                                for (int k = 0; k < j; k++)
                                {
                                    if (slumpLottoNummer[j] == slumpLottoNummer[k])
                                    {
                                        j--;
                                    }
                                }

                            }


                            int antalRatt = 0;

                            for (int j = 0; j < 7; j++)
                            {
                                if (lottoNummer.Contains(slumpLottoNummer[j]))
                                {
                                    antalRatt++;
                                }


                                if (antalRatt == 5)
                                {
                                    antal5Ratt++;

                                }
                                else if (antalRatt == 6)
                                {
                                    antal6Ratt++;
                                }
                                else if (antalRatt == 7)
                                {
                                    antal7Ratt++;
                                }


                                // Skriv ut antal rätt
                                femratt.Text = antal5Ratt.ToString();
                                sexratt.Text = antal6Ratt.ToString();
                                sjuratt.Text = antal7Ratt.ToString();

                                i++;
                            }
                        }

                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("FEL: " + ex.Message);
            }
        }
    
    }
}