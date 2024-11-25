namespace MyPatient
{
    partial class ShowPatientMedicalHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            birthdateLabel = new Label();
            birthdateDateTimePicker = new DateTimePicker();
            birthplaceLabel = new Label();
            birthplaceTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            ageLabel = new Label();
            ageNumericUpDown = new NumericUpDown();
            weightLabel = new Label();
            sizeLabel = new Label();
            bloodGroupLabel = new Label();
            bloodGroupComboBox = new ComboBox();
            motherGroupBox = new GroupBox();
            motherIdTextBox = new TextBox();
            motherIdLabel = new Label();
            motherLastNameTextBox = new TextBox();
            motherFirstNameLabel = new Label();
            motherLastNameLabel = new Label();
            motherFirstNameTextBox = new TextBox();
            fatherGroupBox = new GroupBox();
            fatherIdLabel = new Label();
            fatherIdTextBox = new TextBox();
            fatherFistNameLabel = new Label();
            fatherLastNameTextBox = new TextBox();
            fatherFirstNameTextBox = new TextBox();
            fatherLastNameLabel = new Label();
            cancelButton = new Button();
            acceptButton = new Button();
            weightNumericUpDown = new NumericUpDown();
            sizeNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            motherGroupBox.SuspendLayout();
            fatherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(267, 32);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(249, 27);
            lastNameTextBox.TabIndex = 10;
            lastNameTextBox.Text = "Jose Torres";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lastNameLabel.Location = new Point(267, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(86, 20);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Apellido(s)";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "Nombre(s)";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 32);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(249, 27);
            firstNameTextBox.TabIndex = 7;
            firstNameTextBox.Text = "Angel Miguel";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            birthdateLabel.Location = new Point(12, 62);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(152, 20);
            birthdateLabel.TabIndex = 11;
            birthdateLabel.Text = "Fecha de nacimiento";
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Location = new Point(12, 85);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(504, 27);
            birthdateDateTimePicker.TabIndex = 12;
            birthdateDateTimePicker.Value = new DateTime(2018, 8, 4, 1, 17, 0, 0);
            // 
            // birthplaceLabel
            // 
            birthplaceLabel.AutoSize = true;
            birthplaceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            birthplaceLabel.Location = new Point(522, 62);
            birthplaceLabel.Name = "birthplaceLabel";
            birthplaceLabel.Size = new Size(152, 20);
            birthplaceLabel.TabIndex = 13;
            birthplaceLabel.Text = "Lugar de nacimiento";
            // 
            // birthplaceTextBox
            // 
            birthplaceTextBox.Location = new Point(522, 85);
            birthplaceTextBox.Name = "birthplaceTextBox";
            birthplaceTextBox.Size = new Size(504, 27);
            birthplaceTextBox.TabIndex = 14;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addressLabel.Location = new Point(12, 115);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(75, 20);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Domicilio";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 138);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(504, 81);
            addressTextBox.TabIndex = 16;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 9F);
            ageLabel.Location = new Point(522, 115);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(43, 20);
            ageLabel.TabIndex = 17;
            ageLabel.Text = "Edad";
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Enabled = false;
            ageNumericUpDown.Location = new Point(522, 138);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(249, 27);
            ageNumericUpDown.TabIndex = 18;
            ageNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weightLabel.Location = new Point(777, 115);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(42, 20);
            weightLabel.TabIndex = 19;
            weightLabel.Text = "Peso";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sizeLabel.Location = new Point(522, 168);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(41, 20);
            sizeLabel.TabIndex = 22;
            sizeLabel.Text = "Talla";
            // 
            // bloodGroupLabel
            // 
            bloodGroupLabel.AutoSize = true;
            bloodGroupLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bloodGroupLabel.Location = new Point(777, 168);
            bloodGroupLabel.Name = "bloodGroupLabel";
            bloodGroupLabel.Size = new Size(129, 20);
            bloodGroupLabel.TabIndex = 23;
            bloodGroupLabel.Text = "Grupo sanguineo";
            // 
            // bloodGroupComboBox
            // 
            bloodGroupComboBox.FormattingEnabled = true;
            bloodGroupComboBox.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            bloodGroupComboBox.Location = new Point(777, 191);
            bloodGroupComboBox.Name = "bloodGroupComboBox";
            bloodGroupComboBox.Size = new Size(249, 28);
            bloodGroupComboBox.TabIndex = 24;
            // 
            // motherGroupBox
            // 
            motherGroupBox.Controls.Add(motherIdTextBox);
            motherGroupBox.Controls.Add(motherIdLabel);
            motherGroupBox.Controls.Add(motherLastNameTextBox);
            motherGroupBox.Controls.Add(motherFirstNameLabel);
            motherGroupBox.Controls.Add(motherLastNameLabel);
            motherGroupBox.Controls.Add(motherFirstNameTextBox);
            motherGroupBox.Location = new Point(12, 225);
            motherGroupBox.Name = "motherGroupBox";
            motherGroupBox.Size = new Size(504, 213);
            motherGroupBox.TabIndex = 25;
            motherGroupBox.TabStop = false;
            motherGroupBox.Text = "Madre";
            // 
            // motherIdTextBox
            // 
            motherIdTextBox.Location = new Point(6, 152);
            motherIdTextBox.Name = "motherIdTextBox";
            motherIdTextBox.Size = new Size(492, 27);
            motherIdTextBox.TabIndex = 32;
            motherIdTextBox.Text = "29392394";
            // 
            // motherIdLabel
            // 
            motherIdLabel.AutoSize = true;
            motherIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            motherIdLabel.Location = new Point(6, 129);
            motherIdLabel.Name = "motherIdLabel";
            motherIdLabel.Size = new Size(35, 20);
            motherIdLabel.TabIndex = 31;
            motherIdLabel.Text = "C. I.";
            // 
            // motherLastNameTextBox
            // 
            motherLastNameTextBox.Location = new Point(6, 99);
            motherLastNameTextBox.Name = "motherLastNameTextBox";
            motherLastNameTextBox.Size = new Size(492, 27);
            motherLastNameTextBox.TabIndex = 30;
            // 
            // motherFirstNameLabel
            // 
            motherFirstNameLabel.AutoSize = true;
            motherFirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            motherFirstNameLabel.Location = new Point(6, 23);
            motherFirstNameLabel.Name = "motherFirstNameLabel";
            motherFirstNameLabel.Size = new Size(86, 20);
            motherFirstNameLabel.TabIndex = 28;
            motherFirstNameLabel.Text = "Nombre(s)";
            // 
            // motherLastNameLabel
            // 
            motherLastNameLabel.AutoSize = true;
            motherLastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            motherLastNameLabel.Location = new Point(6, 76);
            motherLastNameLabel.Name = "motherLastNameLabel";
            motherLastNameLabel.Size = new Size(86, 20);
            motherLastNameLabel.TabIndex = 29;
            motherLastNameLabel.Text = "Apellido(s)";
            // 
            // motherFirstNameTextBox
            // 
            motherFirstNameTextBox.Location = new Point(6, 46);
            motherFirstNameTextBox.Name = "motherFirstNameTextBox";
            motherFirstNameTextBox.Size = new Size(492, 27);
            motherFirstNameTextBox.TabIndex = 27;
            motherFirstNameTextBox.Text = "Maria Jose";
            // 
            // fatherGroupBox
            // 
            fatherGroupBox.Controls.Add(fatherIdLabel);
            fatherGroupBox.Controls.Add(fatherIdTextBox);
            fatherGroupBox.Controls.Add(fatherFistNameLabel);
            fatherGroupBox.Controls.Add(fatherLastNameTextBox);
            fatherGroupBox.Controls.Add(fatherFirstNameTextBox);
            fatherGroupBox.Controls.Add(fatherLastNameLabel);
            fatherGroupBox.Location = new Point(522, 225);
            fatherGroupBox.Name = "fatherGroupBox";
            fatherGroupBox.Size = new Size(504, 213);
            fatherGroupBox.TabIndex = 26;
            fatherGroupBox.TabStop = false;
            fatherGroupBox.Text = "Padre";
            // 
            // fatherIdLabel
            // 
            fatherIdLabel.AutoSize = true;
            fatherIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fatherIdLabel.Location = new Point(6, 129);
            fatherIdLabel.Name = "fatherIdLabel";
            fatherIdLabel.Size = new Size(35, 20);
            fatherIdLabel.TabIndex = 33;
            fatherIdLabel.Text = "C. I.";
            // 
            // fatherIdTextBox
            // 
            fatherIdTextBox.Location = new Point(6, 152);
            fatherIdTextBox.Name = "fatherIdTextBox";
            fatherIdTextBox.Size = new Size(492, 27);
            fatherIdTextBox.TabIndex = 37;
            fatherIdTextBox.Text = "30194293";
            // 
            // fatherFistNameLabel
            // 
            fatherFistNameLabel.AutoSize = true;
            fatherFistNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fatherFistNameLabel.Location = new Point(6, 23);
            fatherFistNameLabel.Name = "fatherFistNameLabel";
            fatherFistNameLabel.Size = new Size(86, 20);
            fatherFistNameLabel.TabIndex = 34;
            fatherFistNameLabel.Text = "Nombre(s)";
            // 
            // fatherLastNameTextBox
            // 
            fatherLastNameTextBox.Location = new Point(6, 99);
            fatherLastNameTextBox.Name = "fatherLastNameTextBox";
            fatherLastNameTextBox.Size = new Size(492, 27);
            fatherLastNameTextBox.TabIndex = 36;
            // 
            // fatherFirstNameTextBox
            // 
            fatherFirstNameTextBox.Location = new Point(6, 46);
            fatherFirstNameTextBox.Name = "fatherFirstNameTextBox";
            fatherFirstNameTextBox.Size = new Size(492, 27);
            fatherFirstNameTextBox.TabIndex = 33;
            fatherFirstNameTextBox.Text = "Luis Torres";
            // 
            // fatherLastNameLabel
            // 
            fatherLastNameLabel.AutoSize = true;
            fatherLastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fatherLastNameLabel.Location = new Point(6, 76);
            fatherLastNameLabel.Name = "fatherLastNameLabel";
            fatherLastNameLabel.Size = new Size(86, 20);
            fatherLastNameLabel.TabIndex = 35;
            fatherLastNameLabel.Text = "Apellido(s)";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(937, 459);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 27;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(837, 459);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(94, 29);
            acceptButton.TabIndex = 28;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // weightNumericUpDown
            // 
            weightNumericUpDown.Location = new Point(777, 139);
            weightNumericUpDown.Name = "weightNumericUpDown";
            weightNumericUpDown.Size = new Size(249, 27);
            weightNumericUpDown.TabIndex = 29;
            // 
            // sizeNumericUpDown
            // 
            sizeNumericUpDown.Location = new Point(522, 191);
            sizeNumericUpDown.Name = "sizeNumericUpDown";
            sizeNumericUpDown.Size = new Size(249, 27);
            sizeNumericUpDown.TabIndex = 30;
            // 
            // ShowPatientMedicalHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 500);
            Controls.Add(sizeNumericUpDown);
            Controls.Add(weightNumericUpDown);
            Controls.Add(acceptButton);
            Controls.Add(cancelButton);
            Controls.Add(fatherGroupBox);
            Controls.Add(motherGroupBox);
            Controls.Add(bloodGroupComboBox);
            Controls.Add(bloodGroupLabel);
            Controls.Add(sizeLabel);
            Controls.Add(weightLabel);
            Controls.Add(ageNumericUpDown);
            Controls.Add(ageLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(birthplaceTextBox);
            Controls.Add(birthplaceLabel);
            Controls.Add(birthdateDateTimePicker);
            Controls.Add(birthdateLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Name = "ShowPatientMedicalHistory";
            Text = "Historia Médica";
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            motherGroupBox.ResumeLayout(false);
            motherGroupBox.PerformLayout();
            fatherGroupBox.ResumeLayout(false);
            fatherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label birthdateLabel;
        private DateTimePicker birthdateDateTimePicker;
        private Label birthplaceLabel;
        private TextBox birthplaceTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label ageLabel;
        private NumericUpDown ageNumericUpDown;
        private Label weightLabel;
        private Label sizeLabel;
        private Label bloodGroupLabel;
        private ComboBox bloodGroupComboBox;
        private GroupBox motherGroupBox;
        private TextBox motherIdTextBox;
        private Label motherIdLabel;
        private TextBox motherLastNameTextBox;
        private Label motherFirstNameLabel;
        private Label motherLastNameLabel;
        private TextBox motherFirstNameTextBox;
        private GroupBox fatherGroupBox;
        private TextBox fatherIdTextBox;
        private Label fatherFistNameLabel;
        private TextBox fatherLastNameTextBox;
        private TextBox fatherFirstNameTextBox;
        private Label fatherLastNameLabel;
        private Button cancelButton;
        private Button acceptButton;
        private Label fatherIdLabel;
        private NumericUpDown weightNumericUpDown;
        private NumericUpDown sizeNumericUpDown;
    }
}