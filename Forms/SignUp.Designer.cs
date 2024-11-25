namespace MyPatient
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            idTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            idLabel = new Label();
            prefessionLabel = new Label();
            prefessionComboBox = new ComboBox();
            phoneLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneCountryComboBox = new ComboBox();
            label6 = new Label();
            firstPasswordTextBox = new TextBox();
            lastPasswordTextBox = new TextBox();
            showPasswordCheckBox = new CheckBox();
            acceptButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 32);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(249, 27);
            firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Nombre(s)";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(12, 85);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(249, 27);
            idTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lastNameLabel.Location = new Point(267, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(86, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Apellido(s)";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(267, 32);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(249, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            idLabel.Location = new Point(12, 62);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(35, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "C. I.";
            // 
            // prefessionLabel
            // 
            prefessionLabel.AutoSize = true;
            prefessionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            prefessionLabel.Location = new Point(267, 62);
            prefessionLabel.Name = "prefessionLabel";
            prefessionLabel.Size = new Size(76, 20);
            prefessionLabel.TabIndex = 8;
            prefessionLabel.Text = "Profesión";
            // 
            // prefessionComboBox
            // 
            prefessionComboBox.FormattingEnabled = true;
            prefessionComboBox.Items.AddRange(new object[] { "Pediatra Puericultor" });
            prefessionComboBox.Location = new Point(267, 84);
            prefessionComboBox.Name = "prefessionComboBox";
            prefessionComboBox.Size = new Size(249, 28);
            prefessionComboBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            phoneLabel.Location = new Point(12, 115);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(70, 20);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Teléfono";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(267, 138);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(249, 27);
            phoneNumberTextBox.TabIndex = 11;
            // 
            // phoneCountryComboBox
            // 
            phoneCountryComboBox.FormattingEnabled = true;
            phoneCountryComboBox.Items.AddRange(new object[] { "Venezuela (+58)", "Estados Unidos (+1)" });
            phoneCountryComboBox.Location = new Point(12, 138);
            phoneCountryComboBox.Name = "phoneCountryComboBox";
            phoneCountryComboBox.Size = new Size(249, 28);
            phoneCountryComboBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 169);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 13;
            label6.Text = "Contraseña";
            // 
            // firstPasswordTextBox
            // 
            firstPasswordTextBox.Location = new Point(12, 192);
            firstPasswordTextBox.Name = "firstPasswordTextBox";
            firstPasswordTextBox.Size = new Size(249, 27);
            firstPasswordTextBox.TabIndex = 14;
            firstPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lastPasswordTextBox
            // 
            lastPasswordTextBox.Location = new Point(267, 192);
            lastPasswordTextBox.Name = "lastPasswordTextBox";
            lastPasswordTextBox.Size = new Size(249, 27);
            lastPasswordTextBox.TabIndex = 15;
            lastPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(522, 194);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(52, 24);
            showPasswordCheckBox.TabIndex = 16;
            showPasswordCheckBox.Text = "Ver";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(322, 225);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(94, 29);
            acceptButton.TabIndex = 17;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(422, 225);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 273);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(lastPasswordTextBox);
            Controls.Add(firstPasswordTextBox);
            Controls.Add(label6);
            Controls.Add(phoneCountryComboBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(prefessionComboBox);
            Controls.Add(prefessionLabel);
            Controls.Add(idLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(idTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Name = "SignUp";
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox idTextBox;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label idLabel;
        private Label prefessionLabel;
        private ComboBox prefessionComboBox;
        private Label phoneLabel;
        private TextBox phoneNumberTextBox;
        private ComboBox phoneCountryComboBox;
        private Label label6;
        private TextBox firstPasswordTextBox;
        private TextBox lastPasswordTextBox;
        private CheckBox showPasswordCheckBox;
        private Button acceptButton;
        private Button cancelButton;
    }
}
