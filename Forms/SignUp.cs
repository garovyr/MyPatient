namespace MyPatient
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.TextLength < 1)
            {
                firstNameTextBox.Focus();

                return;
            }

            if (lastNameTextBox.TextLength < 1)
            {
                lastNameLabel.Focus();

                return;
            }

            if (idTextBox.TextLength < 1)
            {
                idTextBox.Focus();

                return;
            }

            if (prefessionComboBox.SelectionLength < 1)
            {
                prefessionComboBox.Focus();

                return;
            }

            if (phoneCountryComboBox.SelectionLength < 1)
            {
                phoneCountryComboBox.Focus();

                return;
            }

            if (phoneNumberTextBox.TextLength < 1)
            {
                phoneNumberTextBox.Focus();

                return;
            }

            if (firstPasswordTextBox.TextLength < 1)
            {
                firstPasswordTextBox.Focus();

                return;
            }

            if (lastPasswordTextBox.TextLength < 1)
            {
                lastPasswordTextBox.Focus();

                return;
            }

            Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;

            firstPasswordTextBox.UseSystemPasswordChar = !checkBox.Checked;
            lastPasswordTextBox.UseSystemPasswordChar = !checkBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
