namespace GestionEtab.View
{
    partial class frmProf
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
            txtNomProf = new TextBox();
            txtPrenomProf = new TextBox();
            label2 = new Label();
            txtEmailProf = new TextBox();
            label3 = new Label();
            txtTelProf = new TextBox();
            label4 = new Label();
            txtSpecialiteProf = new TextBox();
            label5 = new Label();
            btnAjouterProf = new Button();
            btnModifierProf = new Button();
            btnSupprimerProf = new Button();
            label6 = new Label();
            dgProf = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgProf).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // txtNomProf
            // 
            txtNomProf.Location = new Point(22, 60);
            txtNomProf.Name = "txtNomProf";
            txtNomProf.Size = new Size(247, 31);
            txtNomProf.TabIndex = 1;
            // 
            // txtPrenomProf
            // 
            txtPrenomProf.Location = new Point(22, 148);
            txtPrenomProf.Name = "txtPrenomProf";
            txtPrenomProf.Size = new Size(247, 31);
            txtPrenomProf.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Prenom";
            // 
            // txtEmailProf
            // 
            txtEmailProf.Location = new Point(22, 236);
            txtEmailProf.Name = "txtEmailProf";
            txtEmailProf.Size = new Size(247, 31);
            txtEmailProf.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 195);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtTelProf
            // 
            txtTelProf.Location = new Point(22, 324);
            txtTelProf.Name = "txtTelProf";
            txtTelProf.Size = new Size(247, 31);
            txtTelProf.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 283);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Telephone";
            // 
            // txtSpecialiteProf
            // 
            txtSpecialiteProf.Location = new Point(22, 412);
            txtSpecialiteProf.Name = "txtSpecialiteProf";
            txtSpecialiteProf.Size = new Size(247, 31);
            txtSpecialiteProf.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 371);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 8;
            label5.Text = "Specialite";
            // 
            // btnAjouterProf
            // 
            btnAjouterProf.Location = new Point(431, 519);
            btnAjouterProf.Name = "btnAjouterProf";
            btnAjouterProf.Size = new Size(112, 34);
            btnAjouterProf.TabIndex = 10;
            btnAjouterProf.Text = "Ajouter";
            btnAjouterProf.UseVisualStyleBackColor = true;
            btnAjouterProf.Click += btnAjouterProf_Click;
            // 
            // btnModifierProf
            // 
            btnModifierProf.Location = new Point(672, 519);
            btnModifierProf.Name = "btnModifierProf";
            btnModifierProf.Size = new Size(112, 34);
            btnModifierProf.TabIndex = 11;
            btnModifierProf.Text = "Modifier";
            btnModifierProf.UseVisualStyleBackColor = true;
            btnModifierProf.Click += btnModifierProf_Click;
            // 
            // btnSupprimerProf
            // 
            btnSupprimerProf.Location = new Point(913, 519);
            btnSupprimerProf.Name = "btnSupprimerProf";
            btnSupprimerProf.Size = new Size(112, 34);
            btnSupprimerProf.TabIndex = 12;
            btnSupprimerProf.Text = "Supprimer";
            btnSupprimerProf.UseVisualStyleBackColor = true;
            btnSupprimerProf.Click += btnSupprimerProf_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(449, 6);
            label6.Name = "label6";
            label6.Size = new Size(311, 38);
            label6.TabIndex = 13;
            label6.Text = "Liste des professeurs";
            // 
            // dgProf
            // 
            dgProf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProf.Location = new Point(343, 60);
            dgProf.Name = "dgProf";
            dgProf.RowHeadersWidth = 62;
            dgProf.RowTemplate.Height = 33;
            dgProf.Size = new Size(697, 383);
            dgProf.TabIndex = 14;
            // 
            // frmProf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 660);
            ControlBox = false;
            Controls.Add(dgProf);
            Controls.Add(label6);
            Controls.Add(btnSupprimerProf);
            Controls.Add(btnModifierProf);
            Controls.Add(btnAjouterProf);
            Controls.Add(txtSpecialiteProf);
            Controls.Add(label5);
            Controls.Add(txtTelProf);
            Controls.Add(label4);
            Controls.Add(txtEmailProf);
            Controls.Add(label3);
            Controls.Add(txtPrenomProf);
            Controls.Add(label2);
            Controls.Add(txtNomProf);
            Controls.Add(label1);
            Name = "frmProf";
            Text = "Gestion des professeurs";
            Load += frmProf_Load;
            ((System.ComponentModel.ISupportInitialize)dgProf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomProf;
        private TextBox txtPrenomProf;
        private Label label2;
        private TextBox txtEmailProf;
        private Label label3;
        private TextBox txtTelProf;
        private Label label4;
        private TextBox txtSpecialiteProf;
        private Label label5;
        private Button btnAjouterProf;
        private Button btnModifierProf;
        private Button btnSupprimerProf;
        private Label label6;
        private DataGridView dgProf;
    }
}