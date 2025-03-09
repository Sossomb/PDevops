namespace GestionEtab.View
{
    partial class frmCours
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
            txtNomCours = new TextBox();
            txtVolumeHoraire = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbbProf = new ComboBox();
            label4 = new Label();
            cbbClasse = new ComboBox();
            label5 = new Label();
            dgCours = new DataGridView();
            btnAjouterCours = new Button();
            btnModifierCours = new Button();
            btnSupprimerCours = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "NomCours";
            // 
            // txtNomCours
            // 
            txtNomCours.Location = new Point(27, 64);
            txtNomCours.Name = "txtNomCours";
            txtNomCours.Size = new Size(234, 31);
            txtNomCours.TabIndex = 1;
            // 
            // txtVolumeHoraire
            // 
            txtVolumeHoraire.Location = new Point(27, 154);
            txtVolumeHoraire.Name = "txtVolumeHoraire";
            txtVolumeHoraire.Size = new Size(234, 31);
            txtVolumeHoraire.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 2;
            label2.Text = "Volume Horaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 202);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 4;
            label3.Text = "Professeur";
            // 
            // cbbProf
            // 
            cbbProf.FormattingEnabled = true;
            cbbProf.Location = new Point(27, 244);
            cbbProf.Name = "cbbProf";
            cbbProf.Size = new Size(234, 33);
            cbbProf.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 294);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 6;
            label4.Text = "Classe";
            // 
            // cbbClasse
            // 
            cbbClasse.FormattingEnabled = true;
            cbbClasse.Location = new Point(27, 336);
            cbbClasse.Name = "cbbClasse";
            cbbClasse.Size = new Size(234, 33);
            cbbClasse.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(558, 9);
            label5.Name = "label5";
            label5.Size = new Size(223, 38);
            label5.TabIndex = 8;
            label5.Text = "Liste des cours";
            // 
            // dgCours
            // 
            dgCours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCours.Location = new Point(339, 64);
            dgCours.Name = "dgCours";
            dgCours.RowHeadersWidth = 62;
            dgCours.RowTemplate.Height = 33;
            dgCours.Size = new Size(649, 305);
            dgCours.TabIndex = 9;
            // 
            // btnAjouterCours
            // 
            btnAjouterCours.Location = new Point(339, 420);
            btnAjouterCours.Name = "btnAjouterCours";
            btnAjouterCours.Size = new Size(112, 34);
            btnAjouterCours.TabIndex = 10;
            btnAjouterCours.Text = "Ajouter";
            btnAjouterCours.UseVisualStyleBackColor = true;
            btnAjouterCours.Click += btnAjouterCours_Click;
            // 
            // btnModifierCours
            // 
            btnModifierCours.Location = new Point(587, 420);
            btnModifierCours.Name = "btnModifierCours";
            btnModifierCours.Size = new Size(112, 34);
            btnModifierCours.TabIndex = 11;
            btnModifierCours.Text = "Modifier";
            btnModifierCours.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerCours
            // 
            btnSupprimerCours.Location = new Point(835, 420);
            btnSupprimerCours.Name = "btnSupprimerCours";
            btnSupprimerCours.Size = new Size(112, 34);
            btnSupprimerCours.TabIndex = 12;
            btnSupprimerCours.Text = "Supprimer";
            btnSupprimerCours.UseVisualStyleBackColor = true;
            btnSupprimerCours.Click += btnSupprimerCours_Click;
            // 
            // frmCours
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 603);
            ControlBox = false;
            Controls.Add(btnSupprimerCours);
            Controls.Add(btnModifierCours);
            Controls.Add(btnAjouterCours);
            Controls.Add(dgCours);
            Controls.Add(label5);
            Controls.Add(cbbClasse);
            Controls.Add(label4);
            Controls.Add(cbbProf);
            Controls.Add(label3);
            Controls.Add(txtVolumeHoraire);
            Controls.Add(label2);
            Controls.Add(txtNomCours);
            Controls.Add(label1);
            Name = "frmCours";
            Text = "Gestion des cours";
            Load += frmCours_Load;
            ((System.ComponentModel.ISupportInitialize)dgCours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomCours;
        private TextBox txtVolumeHoraire;
        private Label label2;
        private Label label3;
        private ComboBox cbbProf;
        private Label label4;
        private ComboBox cbbClasse;
        private Label label5;
        private DataGridView dgCours;
        private Button btnAjouterCours;
        private Button btnModifierCours;
        private Button btnSupprimerCours;
    }
}