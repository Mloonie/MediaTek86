namespace MediaTek86.vue
{
    partial class frmGererAbsence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.cbbMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnRetourListePerso = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupAbsence = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(31, 461);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnEnregistrerAbsence.TabIndex = 8;
            this.btnEnregistrerAbsence.Text = "Enregistrer l\'absence";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbsence.Click += new System.EventHandler(this.btnEnregistrerAbsence_Click);
            // 
            // cbbMotif
            // 
            this.cbbMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbbMotif.FormattingEnabled = true;
            this.cbbMotif.Location = new System.Drawing.Point(152, 429);
            this.cbbMotif.Name = "cbbMotif";
            this.cbbMotif.Size = new System.Drawing.Size(152, 26);
            this.cbbMotif.TabIndex = 7;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMotif.Location = new System.Drawing.Point(28, 429);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(55, 19);
            this.lblMotif.TabIndex = 21;
            this.lblMotif.Text = "Motif :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDateFin.Location = new System.Drawing.Point(27, 399);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(97, 19);
            this.lblDateFin.TabIndex = 20;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(27, 369);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(119, 19);
            this.lblDateDebut.TabIndex = 19;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // btnRetourListePerso
            // 
            this.btnRetourListePerso.Location = new System.Drawing.Point(556, 315);
            this.btnRetourListePerso.Name = "btnRetourListePerso";
            this.btnRetourListePerso.Size = new System.Drawing.Size(182, 23);
            this.btnRetourListePerso.TabIndex = 3;
            this.btnRetourListePerso.Text = "Retour à la liste du personnel";
            this.btnRetourListePerso.UseVisualStyleBackColor = true;
            this.btnRetourListePerso.Click += new System.EventHandler(this.btnRetourListePerso_Click);
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(292, 315);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnModifAbsence.TabIndex = 2;
            this.btnModifAbsence.Text = "Modifier l\'absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnSupAbsence
            // 
            this.btnSupAbsence.Location = new System.Drawing.Point(31, 315);
            this.btnSupAbsence.Name = "btnSupAbsence";
            this.btnSupAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnSupAbsence.TabIndex = 1;
            this.btnSupAbsence.Text = "Supprimer l\'absence";
            this.btnSupAbsence.UseVisualStyleBackColor = true;
            this.btnSupAbsence.Click += new System.EventHandler(this.btnSupAbsence_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(32, 33);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsence.Size = new System.Drawing.Size(706, 276);
            this.dgvAbsence.TabIndex = 30;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(28, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 19);
            this.lblNom.TabIndex = 31;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(88, 7);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(113, 24);
            this.txtNom.TabIndex = 32;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(250, 9);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(75, 19);
            this.lblPrenom.TabIndex = 33;
            this.lblPrenom.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(331, 7);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(113, 24);
            this.txtPrenom.TabIndex = 34;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(152, 369);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(173, 20);
            this.dtpDateDebut.TabIndex = 5;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(152, 403);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(173, 20);
            this.dtpDateFin.TabIndex = 6;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(32, 344);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnAjouterAbsence.TabIndex = 4;
            this.btnAjouterAbsence.Text = "Ajouter une absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            this.btnAjouterAbsence.Click += new System.EventHandler(this.btnAjouterAbsence_Click_1);
            // 
            // btnAnnulerAjout
            // 
            this.btnAnnulerAjout.Location = new System.Drawing.Point(219, 461);
            this.btnAnnulerAjout.Name = "btnAnnulerAjout";
            this.btnAnnulerAjout.Size = new System.Drawing.Size(152, 23);
            this.btnAnnulerAjout.TabIndex = 9;
            this.btnAnnulerAjout.Text = "Annuler";
            this.btnAnnulerAjout.UseVisualStyleBackColor = true;
            this.btnAnnulerAjout.Click += new System.EventHandler(this.btnAnnulerAjout_Click);
            // 
            // frmGererAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.btnAnnulerAjout);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgvAbsence);
            this.Controls.Add(this.btnEnregistrerAbsence);
            this.Controls.Add(this.cbbMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.btnRetourListePerso);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnSupAbsence);
            this.Name = "frmGererAbsence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.frmGererAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.ComboBox cbbMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnRetourListePerso;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnAnnulerAjout;
    }
}