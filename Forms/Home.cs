using MyPatient.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPatient
{
    public partial class Home : Form
    {
        public bool signed = false;

        public Home()
        {
            InitializeComponent();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatient();

            window.Show();
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new SearchPatient
            {
                MdiParent = this,
            };

            window.Show();
        }
    }
}
