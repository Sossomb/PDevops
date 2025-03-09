namespace GestionEtab.View
{
    partial class frmEmploidutemps
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
            txtSalle = new TextBox();
            label2 = new Label();
            cbbClasse = new ComboBox();
            label3 = new Label();
            cbbCours = new ComboBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            dtpHeureDebut = new DateTimePicker();
            dtpHeureFin = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dgEmploi = new DataGridView();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            cbbProf = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEmploi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Salle";
            // 
            // txtSalle
            // 
            txtSalle.Location = new Point(31, 56);
            txtSalle.Name = "txtSalle";
            txtSalle.Size = new Size(150, 31);
            txtSalle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 106);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "Classe";
            // 
            // cbbClasse
            // 
            cbbClasse.FormattingEnabled = true;
            cbbClasse.Location = new Point(31, 150);
            cbbClasse.Name = "cbbClasse";
            cbbClasse.Size = new Size(150, 33);
            cbbClasse.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 9);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Cours";
            // 
            // cbbCours
            // 
            cbbCours.FormattingEnabled = true;
            cbbCours.Location = new Point(318, 53);
            cbbCours.Name = "cbbCours";
            cbbCours.Size = new Size(273, 33);
            cbbCours.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 105);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(318, 149);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(274, 31);
            dtpDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(713, 12);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Heure Debut";
            // 
            // dtpHeureDebut
            // 
            dtpHeureDebut.Format = DateTimePickerFormat.Time;
            dtpHeureDebut.Location = new Point(713, 56);
            dtpHeureDebut.Name = "dtpHeureDebut";
            dtpHeureDebut.Size = new Size(253, 31);
            dtpHeureDebut.TabIndex = 9;
            // 
            // dtpHeureFin
            // 
            dtpHeureFin.Format = DateTimePickerFormat.Time;
            dtpHeureFin.Location = new Point(713, 150);
            dtpHeureFin.Name = "dtpHeureFin";
            dtpHeureFin.Size = new Size(262, 31);
            dtpHeureFin.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(713, 106);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 10;
            label6.Text = "Heure Fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(302, 227);
            label7.Name = "label7";
            label7.Size = new Size(392, 38);
            label7.TabIndex = 12;
            label7.Text = "Emploi du temps des cours";
            // 
            // dgEmploi
            // 
            dgEmploi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmploi.Location = new Point(31, 268);
            dgEmploi.Name = "dgEmploi";
            dgEmploi.RowHeadersWidth = 62;
            dgEmploi.RowTemplate.Height = 33;
            dgEmploi.Size = new Size(1040, 367);
            dgEmploi.TabIndex = 13;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(65, 654);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(112, 34);
            btnAjouter.TabIndex = 14;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(389, 654);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(112, 34);
            btnModifier.TabIndex = 15;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(713, 654);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(112, 34);
            btnSupprimer.TabIndex = 16;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // cbbProf
            // 
            cbbProf.FormattingEnabled = true;
            cbbProf.Location = new Point(31, 235);
            cbbProf.Name = "cbbProf";
            cbbProf.Size = new Size(150, 33);
            cbbProf.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 200);
            label8.Name = "label8";
            label8.Size = new Size(45, 25);
            label8.TabIndex = 17;
            label8.Text = "Prof";
            // 
            // frmEmploidutemps
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 689);
            ControlBox = false;
            Controls.Add(cbbProf);
            Controls.Add(label8);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dgEmploi);
            Controls.Add(label7);
            Controls.Add(dtpHeureFin);
            Controls.Add(label6);
            Controls.Add(dtpHeureDebut);
            Controls.Add(label5);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(cbbCours);
            Controls.Add(label3);
            Controls.Add(cbbClasse);
            Controls.Add(label2);
            Controls.Add(txtSalle);
            Controls.Add(label1);
            Name = "frmEmploidutemps";
            Text = "Gestion des emploi du temps";
            Load += frmEmploidutemps_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmploi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalle;
        private Label label2;
        private ComboBox cbbClasse;
        private Label label3;
        private ComboBox cbbCours;
        private Label label4;
        private DateTimePicker dtpDate;
        private Label label5;
        private DateTimePicker dtpHeureDebut;
        private DateTimePicker dtpHeureFin;
        private Label label6;
        private Label label7;
        private DataGridView dgEmploi;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private ComboBox cbbProf;
        private Label label8;
    }
}