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
    public partial class frmEmploidutemps : Form
    {
        public frmEmploidutemps()
        {
            InitializeComponent();
        }
        EtablissementContext db = new EtablissementContext();
        private void ResetForm()
        {
            txtSalle.Text = string.Empty;
            cbbClasse.DataSource = db.Classes.ToList();
            cbbClasse.ValueMember = "IdClasse";
            cbbClasse.DisplayMember = "NomClasse";
            cbbCours.DataSource = db.Cours.ToList();
            cbbCours.ValueMember = "IdCours";
            cbbCours.DisplayMember = "NomCours";
            cbbProf.DataSource = db.Profs.ToList();
            cbbProf.ValueMember = "IdProf";
            cbbProf.DisplayMember = "NomProf";
            dtpDate.Value = DateTime.Now;
            dtpHeureDebut.Value = DateTime.Now;
            dtpHeureFin.Value = DateTime.Now;
            txtSalle.Focus();
            dgEmploi.DataSource = db.EmploiDuTemps.
                Select(a => new
                {
                    a.Salle,
                    a.Classe.NomClasse,
                    a.Cours.NomCours,
                    NomProf = a.Prof.NomProf + " " + a.Prof.PrenomProf,
                     a.Date,
                    a.HeureDebut,
                    a.HeureFin
                }).ToList();
        }
        private void frmEmploidutemps_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            EmploiDuTemps edt = new EmploiDuTemps();
            edt.Salle = txtSalle.Text;
            edt.IdClasse = int.Parse(cbbClasse.SelectedValue.ToString());
            edt.IdCours = int.Parse(cbbCours.SelectedValue.ToString());
            edt.IdProf = int.Parse(cbbProf.SelectedValue.ToString());
            edt.Date = dtpDate.Value;
            edt.HeureDebut = dtpHeureDebut.Value.TimeOfDay;
            edt.HeureFin = dtpHeureFin.Value.TimeOfDay;
            db.EmploiDuTemps.Add(edt);
            db.SaveChanges();
            ResetForm();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? IdEmploi = int.Parse(dgEmploi.CurrentRow.Cells[0].Value.ToString());
            var edt = db.EmploiDuTemps.Find(IdEmploi);
            db.EmploiDuTemps.Remove(edt);
            db.SaveChanges();
            ResetForm();
        }

      
    }
}
