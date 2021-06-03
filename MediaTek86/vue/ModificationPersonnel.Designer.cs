namespace MediaTek86.vue
{
    partial class frmModificationPersonnel
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEnregistrerModif = new System.Windows.Forms.Button();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAnnulerModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(26, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(202, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Modification du personnel :";
            // 
            // btnEnregistrerModif
            // 
            this.btnEnregistrerModif.Location = new System.Drawing.Point(126, 135);
            this.btnEnregistrerModif.Name = "btnEnregistrerModif";
            this.btnEnregistrerModif.Size = new System.Drawing.Size(182, 23);
            this.btnEnregistrerModif.TabIndex = 6;
            this.btnEnregistrerModif.Text = "Enregistrer les modifications";
            this.btnEnregistrerModif.UseVisualStyleBackColor = true;
            this.btnEnregistrerModif.Click += new System.EventHandler(this.btnEnregistrerModif_Click);
            // 
            // cbbService
            // 
            this.cbbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(398, 70);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(152, 26);
            this.cbbService.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(317, 68);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(70, 19);
            this.lblService.TabIndex = 23;
            this.lblService.Text = "Service :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(398, 36);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(113, 24);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(317, 38);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(75, 19);
            this.lblPrenom.TabIndex = 21;
            this.lblPrenom.Text = "Prenom :";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(126, 96);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(177, 24);
            this.txtMail.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(126, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(113, 24);
            this.txtNom.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(126, 67);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(113, 24);
            this.txtTel.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMail.Location = new System.Drawing.Point(27, 98);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 19);
            this.lblMail.TabIndex = 17;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTel.Location = new System.Drawing.Point(26, 68);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(94, 19);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(26, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 19);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nom :";
            // 
            // btnAnnulerModif
            // 
            this.btnAnnulerModif.Location = new System.Drawing.Point(368, 135);
            this.btnAnnulerModif.Name = "btnAnnulerModif";
            this.btnAnnulerModif.Size = new System.Drawing.Size(182, 23);
            this.btnAnnulerModif.TabIndex = 7;
            this.btnAnnulerModif.Text = "Annuler les modifications";
            this.btnAnnulerModif.UseVisualStyleBackColor = true;
            this.btnAnnulerModif.Click += new System.EventHandler(this.btnAnnulerModif_Click);
            // 
            // frmModificationPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 185);
            this.Controls.Add(this.btnAnnulerModif);
            this.Controls.Add(this.btnEnregistrerModif);
            this.Controls.Add(this.cbbService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmModificationPersonnel";
            this.Text = "Modification du personnel";
            this.Load += new System.EventHandler(this.frmModificationPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnEnregistrerModif;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnulerModif;
    }
}