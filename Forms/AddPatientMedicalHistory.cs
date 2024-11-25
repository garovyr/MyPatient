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
    public partial class AddPatientMedicalHistory : Form
    {
        public AddPatientMedicalHistory()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var medicalHistory = new PatientMedicalHistory
            {
                firstName = firstNameTextBox.Text,
                lastName = lastNameTextBox.Text,

                birthday = birthdateDateTimePicker.Value,
                birthplace = birthplaceTextBox.Text,

                address = addressTextBox.Text,

                age = ageNumericUpDown.Value,
                weight = weightNumericUpDown.Value,
                size = sizeNumericUpDown.Value,

                bloodGroup = bloodGroupComboBox.Text,

                motherFirstName = motherFirstNameTextBox.Text,
                motherLastName = motherLastNameTextBox.Text,
                motherId = motherIdTextBox.Text,

                fatherFirstName = fatherFirstNameTextBox.Text,
                fatherLastName = fatherLastNameTextBox.Text,
                fatherId = fatherIdTextBox.Text,
            };
        }
    }
}
