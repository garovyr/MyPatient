using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPatient.Forms
{
    public partial class SearchPatientReport : Form
    {
        public SearchPatientReport()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var window = new ShowPatientReport();

            window.Show();
        }
    }
}
