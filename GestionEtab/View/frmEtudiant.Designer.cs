namespace GestionEtab.View
{
    partial class frmEtudiant
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
            txtNomEtu = new TextBox();
            txtPrenomEtu = new TextBox();
            label2 = new Label();
            txtCNIEtu = new TextBox();
            label3 = new Label();
            txtTelEtu = new TextBox();
            label4 = new Label();
            txtEmailEtu = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAjouterEtu = new Button();
            btnModifierEtu = new Button();
            btnSupprimerEtu = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            dgEtu = new DataGridView();
            cbbClasse = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEtu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // txtNomEtu
            // 
            txtNomEtu.Location = new Point(15, 61);
            txtNomEtu.Name = "txtNomEtu";
            txtNomEtu.Size = new Size(228, 31);
            txtNomEtu.TabIndex = 1;
            // 
            // txtPrenomEtu
            // 
            txtPrenomEtu.Location = new Point(15, 151);
            txtPrenomEtu.Name = "txtPrenomEtu";
            txtPrenomEtu.Size = new Size(228, 31);
            txtPrenomEtu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Prenom";
            // 
            // txtCNIEtu
            // 
            txtCNIEtu.Location = new Point(15, 331);
            txtCNIEtu.Name = "txtCNIEtu";
            txtCNIEtu.Size = new Size(228, 31);
            txtCNIEtu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 289);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 4;
            label3.Text = "CNI";
            // 
            // txtTelEtu
            // 
            txtTelEtu.Location = new Point(15, 421);
            txtTelEtu.Name = "txtTelEtu";
            txtTelEtu.Size = new Size(228, 31);
            txtTelEtu.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 379);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Telephone";
            // 
            // txtEmailEtu
            // 
            txtEmailEtu.Location = new Point(15, 241);
            txtEmailEtu.Name = "txtEmailEtu";
            txtEmailEtu.Size = new Size(228, 31);
            txtEmailEtu.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 199);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 469);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 10;
            label6.Text = "Date de naissance";
            // 
            // btnAjouterEtu
            // 
            btnAjouterEtu.Location = new Point(340, 592);
            btnAjouterEtu.Name = "btnAjouterEtu";
            btnAjouterEtu.Size = new Size(112, 34);
            btnAjouterEtu.TabIndex = 12;
            btnAjouterEtu.Text = "Ajouter";
            btnAjouterEtu.UseVisualStyleBackColor = true;
            btnAjouterEtu.Click += btnAjouterEtu_Click;
            // 
            // btnModifierEtu
            // 
            btnModifierEtu.Location = new Point(595, 592);
            btnModifierEtu.Name = "btnModifierEtu";
            btnModifierEtu.Size = new Size(112, 34);
            btnModifierEtu.TabIndex = 13;
            btnModifierEtu.Text = "Modifier";
            btnModifierEtu.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerEtu
            // 
            btnSupprimerEtu.Location = new Point(850, 592);
            btnSupprimerEtu.Name = "btnSupprimerEtu";
            btnSupprimerEtu.Size = new Size(112, 34);
            btnSupprimerEtu.TabIndex = 14;
            btnSupprimerEtu.Text = "Supprimer";
            btnSupprimerEtu.UseVisualStyleBackColor = true;
            btnSupprimerEtu.Click += btnSupprimerEtu_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(15, 511);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(439, 19);
            label7.Name = "label7";
            label7.Size = new Size(280, 38);
            label7.TabIndex = 16;
            label7.Text = "Liste des etudiants";
            // 
            // dgEtu
            // 
            dgEtu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEtu.Location = new Point(340, 60);
            dgEtu.Name = "dgEtu";
            dgEtu.RowHeadersWidth = 62;
            dgEtu.RowTemplate.Height = 33;
            dgEtu.Size = new Size(727, 478);
            dgEtu.TabIndex = 17;
            // 
            // cbbClasse
            // 
            cbbClasse.FormattingEnabled = true;
            cbbClasse.Location = new Point(15, 601);
            cbbClasse.Name = "cbbClasse";
            cbbClasse.Size = new Size(234, 33);
            cbbClasse.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 559);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 19;
            label8.Text = "Classe";
            // 
            // frmEtudiant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 698);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(cbbClasse);
            Controls.Add(dgEtu);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSupprimerEtu);
            Controls.Add(btnModifierEtu);
            Controls.Add(btnAjouterEtu);
            Controls.Add(label6);
            Controls.Add(txtEmailEtu);
            Controls.Add(label5);
            Controls.Add(txtTelEtu);
            Controls.Add(label4);
            Controls.Add(txtCNIEtu);
            Controls.Add(label3);
            Controls.Add(txtPrenomEtu);
            Controls.Add(label2);
            Controls.Add(txtNomEtu);
            Controls.Add(label1);
            Name = "frmEtudiant";
            Text = "Gestion Etudiant";
            Load += frmEtudiant_Load;
            ((System.ComponentModel.ISupportInitialize)dgEtu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomEtu;
        private TextBox txtPrenomEtu;
        private Label label2;
        private TextBox txtCNIEtu;
        private Label label3;
        private TextBox txtTelEtu;
        private Label label4;
        private TextBox txtEmailEtu;
        private Label label5;
        private Label label6;
        private Button btnAjouterEtu;
        private Button btnModifierEtu;
        private Button btnSupprimerEtu;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private DataGridView dgEtu;
        private ComboBox cbbClasse;
        private Label label8;
    }
}