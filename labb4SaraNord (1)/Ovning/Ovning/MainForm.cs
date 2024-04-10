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
    public partial class MainForm : Form
    {
        CSVFile kontroll;

        public MainForm()
        {
            kontroll = new CSVFile();
            InitializeComponent();

        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            ManagementControll management = new ManagementControll();
            management.Dock = DockStyle.Fill;
            ManagementTab.Controls.Add(management);

            kassaKontroll kassa = new kassaKontroll();
            kassa.Dock = DockStyle.Fill;
            LendingTab.Controls.Add(kassa);

            AcceptButton = kassa.AddKassaButton; 
        }

        private void ManagementTab_Click(object sender, EventArgs e)
        {
            
            kontroll.ReadCSV();
        }
    }
}
