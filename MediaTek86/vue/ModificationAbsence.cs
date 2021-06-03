using MediaTek86.controle;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class frmModificationAbsence : Form
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private DateTime datedebut;
        private DateTime datefin;
        private int idmotif;
        private string motif;

        /// <summary>
        /// Permet de changer la valeur de idpersonnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SetIdPersonnel(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
        }
        /// <summary>
        /// Permet de changer la valeur du nom
        /// </summary>
        /// <param name="nom"></param>
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Permet de changer la valeur du prenom
        /// </summary>
        /// <param name="prenom"></param>
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        /// <summary>
        /// Permet de changer la valeur de datedebut
        /// </summary>
        /// <param name="datedebut"></param>
        public void SetDateDebut(DateTime datedebut)
        {
            this.datedebut = datedebut;
        }
        /// <summary>
        /// Permet de changer la valeur de datefin
        /// </summary>
        /// <param name="datefin"></param>
        public void SetDateFin(DateTime datefin)
        {
            this.datefin = datefin;
        }
        /// <summary>
        /// Permet de changer la valeur de idmotif
        /// </summary>
        /// <param name="idmotif"></param>
        public void SetIdMotif(int idmotif)
        {
            this.idmotif = idmotif;
        }
        /// <summary>
        /// Permet de changer la valeur du motif
        /// </summary>
        /// <param name="motif"></param>
        public void SetMotif(string motif)
        {
            this.motif = motif;
        }
        /// <summary>
        /// Retourne idpersonnel
        /// </summary>
        /// <returns></returns>
        public int GetIdPersonnel()
        {
            return idpersonnel;
        }
        /// <summary>
        /// Retourne le nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }
        /// <summary>
        /// Retourne le prenom
        /// </summary>
        /// <returns></returns>
        public string GetPrenom()
        {
            return prenom;
        }
        /// <summary>
        /// Retourne datedebut
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateDebut()
        {
            return datedebut;
        }
        /// <summary>
        /// Retourne datefin
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateFin()
        {
            return datefin;
        }
        /// <summary>
        /// Retourne idmotif
        /// </summary>
        /// <returns></returns>
        public int GetIdMotif()
        {
            return idmotif;
        }
        /// <summary>
        /// Retourne le motif
        /// </summary>
        /// <returns></returns>
        public string GetMotif()
        {
            return motif;
        }

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        public BindingSource bdgMotif = new BindingSource();

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public frmModificationAbsence(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListeMotif();
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
        }

       /// <summary>
       /// Affiche les motifs
       /// </summary>
        public void RemplirListeMotif()
        {
            controle.GetLesMotifs(bdgMotif);
            cbbMotif.DataSource = bdgMotif;
            if (cbbMotif.Items.Count > 0)
            {
                cbbMotif.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Remplis les zones de texte au chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificationAbsence_Load(object sender, EventArgs e)
        {
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            dtpDateDebut.Value = datedebut;
            dtpDateFin.Value = datefin;
            cbbMotif.SelectedIndex = cbbMotif.FindStringExact(motif);
        }

        /// <summary>
        /// Annule les modifications et retourne à la liste des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            controle.AnnulerUpdateAbsence();
        }

        /// <summary>
        /// Enregistre les modifications de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            DateTime datedebut = dtpDateDebut.Value;
            DateTime datefin = dtpDateFin.Value;
            int result = DateTime.Compare(datedebut, datefin);

            if (cbbMotif.SelectedIndex != -1)
            {
                if (result < 0)
                {
                    if (MessageBox.Show("Voulez-vous vraiment enregistrer ?", "Confirmation d'enregistrement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.EnrUpdateAbsence(dtpDateDebut.Value, dtpDateFin.Value);
                    }
                }
                else
                {
                    MessageBox.Show("La date de début est supérieur à la date de fin", "Imformation");

                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
