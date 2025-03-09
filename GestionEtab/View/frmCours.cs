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
    public partial class frmCours : Form
    {
        public frmCours()
        {
            InitializeComponent();
        }
        EtablissementContext db = new EtablissementContext();
        private void ResetForm()
        {
            txtNomCours.Text = string.Empty;
            txtVolumeHoraire.Text = string.Empty;
            cbbProf.DataSource = db.Profs.ToList();
            cbbProf.ValueMember = "IdProf";
            cbbProf.DisplayMember = "NomProf";
            cbbClasse.DataSource = db.Classes.ToList();
            cbbClasse.ValueMember = "IdClasse";
            cbbClasse.DisplayMember = "NomClasse";
            txtNomCours.Focus();
            dgCours.DataSource = db.Cours.
                Select(a => new
                {
                    a.NomCours,
                    a.VolumeHoraire,
                    a.Prof.NomProf,
                    a.Classe.NomClasse
                }).ToList();
            // Modifier le texte de l'en-tête de la première colonne
            dgCours.Columns[0].HeaderText = "Libelle du cours";
            dgCours.Columns[2].HeaderText = " Nom du professeur";
            dgCours.Columns[3].HeaderText = "Classe";
        }

        private void frmCours_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouterCours_Click(object sender, EventArgs e)
        {
            Cours c = new Cours();
            c.NomCours = txtNomCours.Text;
            c.VolumeHoraire = int.Parse(txtVolumeHoraire.Text);
            c.IdProf = int.Parse(cbbProf.SelectedValue.ToString());
            c.IdClasse = int.Parse(cbbClasse.SelectedValue.ToString());
            db.Cours.Add(c);
            db.SaveChanges();
            ResetForm();

        }

        private void btnSupprimerCours_Click(object sender, EventArgs e)
        {
            int? IdCours = int.Parse(dgCours.CurrentRow.Cells[0].Value.ToString());
            var c = db.Cours.Find(IdCours);
            db.Cours.Remove(c);
            db.SaveChanges();
            ResetForm();
        }
    }
}
