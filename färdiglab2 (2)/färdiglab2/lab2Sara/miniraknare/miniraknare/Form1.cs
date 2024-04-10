using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniraknare
{
    public partial class Calculator : Form
    {


        public Calculator()
        {
            InitializeComponent();
        }
        int result = 0;
        int tal = 0;
        String operation = "";
        bool knappTryck = false;
        bool likamed = false;
        int tal2 = 0;

        public void btn_Click(object sender, EventArgs e)
        {
            try {
                if (knappTryck)
                {
                    txtTotal.Clear();
                    knappTryck = false;

                }
                if (likamed)
                {
                    likamed = false;
                }

                Button knapp = (Button)sender;
                txtTotal.Text = (txtTotal.Text + knapp.Text);
                tal2 = int.Parse(txtTotal.Text);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void operator_Click(object sender, EventArgs e)
        {
            try
            {
                Button knapp = (Button)sender;

                if (result != 0)
                {
                    btnEqual.PerformClick();
                    operation = knapp.Text;
                }
                else
                {
                    operation = knapp.Text;
                    if (!int.TryParse(txtTotal.Text, out tal)) //om det går att parsa, läggs det i variabeln tal
                    {
                        throw new OverflowException("FEL: För högt tal");
                    }
                    else
                    {
                        result = (result = tal);
                    }
                    
                }
                
                knappTryck = true;
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {   if (likamed == false)
                {
                    if (!int.TryParse(txtTotal.Text, out tal)) //om det går att parsa, läggs det i variabeln tal
                    {
                        throw new Exception("FEL: För högt tal");
                    }
                    switch (operation)
                    {
                        case "+":
                            result = (result += tal);
                            txtTotal.Text = result.ToString();
                            break;
                        case "-":
                            result = (result -= tal);
                            txtTotal.Text = result.ToString();
                            break;
                        case "*":
                            result = (result *= tal);
                            txtTotal.Text = result.ToString();
                            break;

                        case "/":
                            if (int.Parse(txtTotal.Text) == 0)
                            {
                                MessageBox.Show("kan inte divideras med 0.");
                            }
                            else
                            {
                                result /= int.Parse(txtTotal.Text);
                                txtTotal.Text = result.ToString();
                            }
                            break;
                    }
                    result = int.Parse(txtTotal.Text);
                    likamed = true;

                }
                else
                {
                    if(likamed == true)
                    {
                        if (!int.TryParse(txtTotal.Text, out tal)) //om det går att parsa, läggs det i variabeln tal
                        {
                            throw new Exception("FEL: För högt tal"); 
                        }
                        switch (operation)
                        {
                            case "+":
                                result = (result + tal2);
                                txtTotal.Text = result.ToString();
                                break;
                            case "-":
                                result = (result - tal2);
                                txtTotal.Text = result.ToString();
                                break;
                            case "*":
                                result = (result * tal2);
                                txtTotal.Text = result.ToString();
                                break;

                            case "/":
                                if (int.Parse(txtTotal.Text) == 0)
                                {
                                    MessageBox.Show("kan inte divideras med 0.");
                                }
                                else
                                {
                                    result /= int.Parse(txtTotal.Text);
                                    txtTotal.Text = result.ToString();
                                }
                                break;
                        }
                        result = int.Parse(txtTotal.Text);
                    }
                    
                }
         
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            tal2= 0;
            likamed = false;
            knappTryck = false;
        }
    }
}
       
