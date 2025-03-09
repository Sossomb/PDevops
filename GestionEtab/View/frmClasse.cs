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
    public partial class frmClasse : Form
    {
        public frmClasse()
        {
            InitializeComponent();
        }
        EtablissementContext db = new EtablissementContext();

        private void ResetForm()
        {
            txtNomClasse.Text = string.Empty;
            dgClasse.DataSource = db.Classes.
                 Select(a => new
                 {
                     a.IdClasse,
                     a.NomClasse
                 })
                 .ToList();
            txtNomClasse.Focus();

        }
        private void frmClasse_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouterClasse_Click(object sender, EventArgs e)
        {
            Classe cl = new Classe();
            cl.NomClasse = txtNomClasse.Text;
            db.Classes.Add(cl);
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimerClasse_Click(object sender, EventArgs e)
        {
            int? IdClasse = int.Parse(dgClasse.CurrentRow.Cells[0].Value.ToString());
            Classe cl = db.Classes.Find(IdClasse);
            db.Classes.Remove(cl);
            db.SaveChanges();
            ResetForm();
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            //Fonction qui permet de modifier
            int? IdClasse = int.Parse(dgClasse.CurrentRow.Cells[0].Value.ToString());
            var c = db.Classes.Find(IdClasse);
            c.NomClasse = txtNomClasse.Text;
            db.SaveChanges();
            ResetForm();

        }

        // Remplir le champ lors de la sélection d'une ligne dans le DataGridView

        private void dgClasse_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClasse.SelectedRows.Count > 0)
            {
                txtNomClasse.Text = dgClasse.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

    }
}
