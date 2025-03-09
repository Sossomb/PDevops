using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEtab.View;
using Microsoft.VisualBasic.Devices;

namespace GestionEtab
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmEtudiant f = new frmEtudiant();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized; // Définir la maximisation AVANT d'afficher le formulaire
            f.Show();
        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCours f = new frmCours();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmClasse f = new frmClasse();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void professeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProf f = new frmProf();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void emploiDuTempsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmEmploidutemps f = new frmEmploidutemps();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
    }
}
