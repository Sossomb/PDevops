namespace GestionEtab
{
    partial class frmAccueil
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
            actionToolStripMenuItem = new ToolStripMenuItem();
            seDecToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            parametreToolStripMenuItem = new ToolStripMenuItem();
            etudiantToolStripMenuItem = new ToolStripMenuItem();
            coursToolStripMenuItem = new ToolStripMenuItem();
            classeToolStripMenuItem = new ToolStripMenuItem();
            professeursToolStripMenuItem = new ToolStripMenuItem();
            emploiDuTempsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { actionToolStripMenuItem, parametreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(852, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seDecToolStripMenuItem, quitterToolStripMenuItem });
            actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            actionToolStripMenuItem.Size = new Size(79, 29);
            actionToolStripMenuItem.Text = "Action";
            // 
            // seDecToolStripMenuItem
            // 
            seDecToolStripMenuItem.Name = "seDecToolStripMenuItem";
            seDecToolStripMenuItem.Size = new Size(237, 34);
            seDecToolStripMenuItem.Text = "Se Deconnecter";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(237, 34);
            quitterToolStripMenuItem.Text = "&Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // parametreToolStripMenuItem
            // 
            parametreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { etudiantToolStripMenuItem, coursToolStripMenuItem, classeToolStripMenuItem, professeursToolStripMenuItem, emploiDuTempsToolStripMenuItem });
            parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            parametreToolStripMenuItem.Size = new Size(107, 29);
            parametreToolStripMenuItem.Text = "Parametre";
            // 
            // etudiantToolStripMenuItem
            // 
            etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            etudiantToolStripMenuItem.Size = new Size(250, 34);
            etudiantToolStripMenuItem.Text = "Etudiants";
            etudiantToolStripMenuItem.Click += etudiantToolStripMenuItem_Click;
            // 
            // coursToolStripMenuItem
            // 
            coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            coursToolStripMenuItem.Size = new Size(250, 34);
            coursToolStripMenuItem.Text = "Cours";
            coursToolStripMenuItem.Click += coursToolStripMenuItem_Click;
            // 
            // classeToolStripMenuItem
            // 
            classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            classeToolStripMenuItem.Size = new Size(250, 34);
            classeToolStripMenuItem.Text = "Classes";
            classeToolStripMenuItem.Click += classeToolStripMenuItem_Click;
            // 
            // professeursToolStripMenuItem
            // 
            professeursToolStripMenuItem.Name = "professeursToolStripMenuItem";
            professeursToolStripMenuItem.Size = new Size(250, 34);
            professeursToolStripMenuItem.Text = "Professeurs";
            professeursToolStripMenuItem.Click += professeursToolStripMenuItem_Click;
            // 
            // emploiDuTempsToolStripMenuItem
            // 
            emploiDuTempsToolStripMenuItem.Name = "emploiDuTempsToolStripMenuItem";
            emploiDuTempsToolStripMenuItem.Size = new Size(250, 34);
            emploiDuTempsToolStripMenuItem.Text = "Emploi du temps";
            emploiDuTempsToolStripMenuItem.Click += emploiDuTempsToolStripMenuItem_Click;
            // 
            // frmAccueil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 605);
            ControlBox = false;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmAccueil";
            Text = "Accueil";
            Load += frmAccueil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem actionToolStripMenuItem;
        private ToolStripMenuItem parametreToolStripMenuItem;
        private ToolStripMenuItem seDecToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem etudiantToolStripMenuItem;
        private ToolStripMenuItem coursToolStripMenuItem;
        private ToolStripMenuItem classeToolStripMenuItem;
        private ToolStripMenuItem professeursToolStripMenuItem;
        private ToolStripMenuItem emploiDuTempsToolStripMenuItem;
    }
}