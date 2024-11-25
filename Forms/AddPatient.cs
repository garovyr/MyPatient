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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void medicalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatientMedicalHistory
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatientBackground
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void vaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatientVaccine
            {
                MdiParent = this,
            };

            window.Show();
        }
    }
}
