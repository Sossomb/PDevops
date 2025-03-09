namespace GestionEtab.View
{
    partial class frmClasse
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
            label1 = new Label();
            txtNomClasse = new TextBox();
            btnAjouterClasse = new Button();
            btnModifier = new Button();
            btnSupprimerClasse = new Button();
            label2 = new Label();
            dgClasse = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgClasse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom Classe";
            // 
            // txtNomClasse
            // 
            txtNomClasse.Location = new Point(237, 57);
            txtNomClasse.Name = "txtNomClasse";
            txtNomClasse.Size = new Size(176, 31);
            txtNomClasse.TabIndex = 1;
            // 
            // btnAjouterClasse
            // 
            btnAjouterClasse.Location = new Point(26, 146);
            btnAjouterClasse.Name = "btnAjouterClasse";
            btnAjouterClasse.Size = new Size(112, 34);
            btnAjouterClasse.TabIndex = 2;
            btnAjouterClasse.Text = "Ajouter";
            btnAjouterClasse.UseVisualStyleBackColor = true;
            btnAjouterClasse.Click += btnAjouterClasse_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(280, 146);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(112, 34);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnSupprimerClasse
            // 
            btnSupprimerClasse.Location = new Point(534, 146);
            btnSupprimerClasse.Name = "btnSupprimerClasse";
            btnSupprimerClasse.Size = new Size(112, 34);
            btnSupprimerClasse.TabIndex = 4;
            btnSupprimerClasse.Text = "Supprimer";
            btnSupprimerClasse.UseVisualStyleBackColor = true;
            btnSupprimerClasse.Click += btnSupprimerClasse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 301);
            label2.Name = "label2";
            label2.Size = new Size(248, 38);
            label2.TabIndex = 5;
            label2.Text = "Liste des Classes";
            // 
            // dgClasse
            // 
            dgClasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClasse.Location = new Point(393, 221);
            dgClasse.Name = "dgClasse";
            dgClasse.RowHeadersWidth = 62;
            dgClasse.RowTemplate.Height = 33;
            dgClasse.Size = new Size(395, 225);
            dgClasse.TabIndex = 6;
            dgClasse.CellContentClick += dgClasse_CellContentClick_1;
            // 
            // frmClasse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgClasse);
            Controls.Add(label2);
            Controls.Add(btnSupprimerClasse);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouterClasse);
            Controls.Add(txtNomClasse);
            Controls.Add(label1);
            Name = "frmClasse";
            Text = "Gestion des classes";
            Load += frmClasse_Load;
            ((System.ComponentModel.ISupportInitialize)dgClasse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomClasse;
        private Button btnAjouterClasse;
        private Button btnModifier;
        private Button btnSupprimerClasse;
        private Label label2;
        private DataGridView dgClasse;
    }
}