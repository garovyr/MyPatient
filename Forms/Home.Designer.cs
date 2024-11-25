namespace MyPatient
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            patientsToolStripMenuItem = new ToolStripMenuItem();
            addPatientToolStripMenuItem = new ToolStripMenuItem();
            searchPatientToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, patientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { signOutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(69, 24);
            accountToolStripMenuItem.Text = "Cuenta";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(224, 26);
            signOutToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // patientsToolStripMenuItem
            // 
            patientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPatientToolStripMenuItem, searchPatientToolStripMenuItem });
            patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            patientsToolStripMenuItem.Size = new Size(84, 24);
            patientsToolStripMenuItem.Text = "Pacientes";
            // 
            // addPatientToolStripMenuItem
            // 
            addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            addPatientToolStripMenuItem.Size = new Size(224, 26);
            addPatientToolStripMenuItem.Text = "Añadir un paciente";
            addPatientToolStripMenuItem.Click += addPatientToolStripMenuItem_Click;
            // 
            // searchPatientToolStripMenuItem
            // 
            searchPatientToolStripMenuItem.Name = "searchPatientToolStripMenuItem";
            searchPatientToolStripMenuItem.Size = new Size(224, 26);
            searchPatientToolStripMenuItem.Text = "Buscar un paciente";
            searchPatientToolStripMenuItem.Click += searchPatientToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 464);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem patientsToolStripMenuItem;
        private ToolStripMenuItem addPatientToolStripMenuItem;
        private ToolStripMenuItem searchPatientToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
    }
}