namespace MyPatient
{
    partial class AddPatient
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
            medicalHistoryToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            vaccineToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicalHistoryToolStripMenuItem, backgroundToolStripMenuItem, vaccineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // medicalHistoryToolStripMenuItem
            // 
            medicalHistoryToolStripMenuItem.Name = "medicalHistoryToolStripMenuItem";
            medicalHistoryToolStripMenuItem.Size = new Size(128, 24);
            medicalHistoryToolStripMenuItem.Text = "Historia Médica";
            medicalHistoryToolStripMenuItem.Click += medicalHistoryToolStripMenuItem_Click;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(113, 24);
            backgroundToolStripMenuItem.Text = "Antecedentes";
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            // 
            // vaccineToolStripMenuItem
            // 
            vaccineToolStripMenuItem.Name = "vaccineToolStripMenuItem";
            vaccineToolStripMenuItem.Size = new Size(76, 24);
            vaccineToolStripMenuItem.Text = "Vacunas";
            vaccineToolStripMenuItem.Click += vaccineToolStripMenuItem_Click;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AddPatient";
            Text = "Añadir un paciente";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicalHistoryToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem vaccineToolStripMenuItem;
    }
}