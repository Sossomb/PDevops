using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEtab.Model;

namespace GestionEtab.View
{
    public partial class frmProf : Form
    {
        public frmProf()
        {
            InitializeComponent();
        }
        EtablissementContext db = new EtablissementContext();
        private void ResetForm()
        {
            txtNomProf.Text = string.Empty;
            txtPrenomProf.Text = string.Empty;
            txtEmailProf.Text = string.Empty;
            txtTelProf.Text = string.Empty;
            txtSpecialiteProf.Text = string.Empty;
            dgProf.DataSource = db.Profs.
                Select(a => new
                {
                    a.NomProf,
                    a.PrenomProf,
                    a.EmailProf,
                    a.TelProf,
                    a.Specialite,
                }).ToList();
            // Modifier le texte de l'en-tête de la première colonne
            dgProf.Columns[0].HeaderText = "Nom";
            dgProf.Columns[1].HeaderText = "Prenom";
            dgProf.Columns[2].HeaderText = "Email";
            dgProf.Columns[3].HeaderText = "Telephone";
            txtNomProf.Focus();
        }
        private void frmProf_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnAjouterProf_Click(object sender, EventArgs e)
        {
            Prof pr = new Prof();
            pr.NomProf = txtNomProf.Text;
            pr.PrenomProf = txtPrenomProf.Text;
            pr.EmailProf = txtEmailProf.Text;
            pr.TelProf = txtTelProf.Text;
            pr.Specialite = txtSpecialiteProf.Text;
            db.Profs.Add(pr);
            db.SaveChanges();
            ResetForm();
        }

        private void btnModifierProf_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerProf_Click(object sender, EventArgs e)
        {
            int? IdProf = int.Parse(dgProf.CurrentRow.Cells[0].Value.ToString());
            var pr = db.Etudiants.Find(IdProf);
            db.Etudiants.Remove(pr);
            db.SaveChanges();
            ResetForm();
        }
    }
}
