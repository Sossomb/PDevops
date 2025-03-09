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
    public partial class frmEtudiant : Form
    {
        public frmEtudiant()
        {
            InitializeComponent();
        }
        EtablissementContext db = new EtablissementContext();
        private void ResetForm()
        {
            txtNomEtu.Text = string.Empty;
            txtPrenomEtu.Text = string.Empty;
            txtEmailEtu.Text = string.Empty;
            txtCNIEtu.Text = string.Empty;
            txtTelEtu.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cbbClasse.DataSource = db.Classes.ToList();
            cbbClasse.ValueMember = "IdClasse";
            cbbClasse.DisplayMember = "NomClasse";
            dgEtu.DataSource = db.Etudiants.
                Select(a => new
                {
                    a.NomEtu,
                    a.PrenomEtu,
                    a.Email,
                    a.CIN,
                    a.Tel,
                    a.DateNaiss,
                    a.Classe.NomClasse
                }).ToList();
            // Modifier le texte de l'en-tête de la première colonne
            dgEtu.Columns[0].HeaderText = "Nom";
            dgEtu.Columns[1].HeaderText = "Prenom";
            dgEtu.Columns[4].HeaderText = "Telephone";
            dgEtu.Columns[5].HeaderText = "Date de naissance";
            txtNomEtu.Focus();

        }
        private void frmEtudiant_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouterEtu_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant();
            et.NomEtu = txtNomEtu.Text;
            et.PrenomEtu = txtPrenomEtu.Text;
            et.Email = txtEmailEtu.Text;
            et.CIN = txtCNIEtu.Text;
            et.Tel = txtTelEtu.Text;
            et.DateNaiss = dateTimePicker1.Value;
            et.IdClasse = int.Parse(cbbClasse.SelectedValue.ToString());
            db.Etudiants.Add(et);
            db.SaveChanges();
            ResetForm();

        }

        private void btnSupprimerEtu_Click(object sender, EventArgs e)
        {
            int? IdEtu = int.Parse(dgEtu.CurrentRow.Cells[0].Value.ToString());
            var et = db.Etudiants.Find(IdEtu);
            db.Etudiants.Remove(et);
            db.SaveChanges();
            ResetForm();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            fermer();
            frmAccueil f = new frmAccueil();
            f.Show();
            this.Close();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
