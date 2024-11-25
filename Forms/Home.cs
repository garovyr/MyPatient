﻿using System;
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

            updateSignStatus();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddPatient();

            window.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signed = false;

            updateSignStatus();
        }

        //

        private void updateSignStatus()
        {
            if (!signed)
            {
                var window = new SignUp();

                window.Show();

                signed = true;
            }

            patientsToolStripMenuItem.Enabled = signed;
        }
    }
}
