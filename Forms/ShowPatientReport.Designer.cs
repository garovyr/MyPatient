namespace MyPatient.Forms
{
    partial class ShowPatientReport
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
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(434, 85);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(415, 27);
            numericUpDown1.TabIndex = 23;
            numericUpDown1.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 62);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 22;
            label4.Text = "Revisión";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 118);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(837, 299);
            textBox4.TabIndex = 19;
            textBox4.Text = "...";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(12, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(416, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2024, 11, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 17;
            label3.Text = "Fecha de creación";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(434, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 27);
            textBox3.TabIndex = 16;
            textBox3.Text = "+58 0400-000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 15;
            label2.Text = "Teléfono";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(223, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 14;
            textBox2.Text = "Pediatra Puericultor";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 13;
            textBox1.Text = "Luisana Atencio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 12;
            label1.Text = "Profesinal";
            // 
            // ShowPatientReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 442);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ShowPatientReport";
            Text = " Buscar un reporte";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label4;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}