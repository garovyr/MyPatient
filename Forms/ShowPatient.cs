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
    public partial class ShowPatient : Form
    {
        public ShowPatient()
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

        private void addReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatientReport
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void searchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new SearchPatientReport
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void backgroundToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var window = new ShowPatientBackground
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void vaccineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var window = new ShowPatientVaccine
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void backgroundToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            var window = new ShowPatientBackground
            {
                MdiParent = this,
            };

            window.Show();
        }

        private void vaccineToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            var window = new ShowPatientVaccine
            {
                MdiParent = this,
            };

            window.Show();
        }
    }
}
