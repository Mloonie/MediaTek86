using MediaTek86.controle;
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
    public partial class frmModificationPersonnel : Form
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string service;

        /// <summary>
        /// Permet de changer la valeur de idpersonnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SetIdPersonnel(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
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
        /// Permet de changer la valeur de nom
        /// </summary>
        /// <param name="nom"></param>
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Retourne nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }
        /// <summary>
        /// Permet de changer la valeur de prenom
        /// </summary>
        /// <param name="prenom"></param>
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        /// <summary>
        /// Retourne prenom
        /// </summary>
        /// <returns></returns>
        public string Getprenom()
        {
            return prenom;
        }
        /// <summary>
        /// Permet de changer la valeur de tel
        /// </summary>
        /// <param name="tel"></param>
        public void SetTel(string tel)
        {
            this.tel = tel;
        }
        /// <summary>
        /// Retourne tel
        /// </summary>
        /// <returns></returns>
        public string GetTel()
        {
            return tel;
        }
        /// <summary>
        /// Permet de changer la valeur de mail
        /// </summary>
        /// <param name="mail"></param>
        public void SetMail(string mail)
        {
            this.mail = mail;
        }
        /// <summary>
        /// Retourne mail
        /// </summary>
        /// <returns></returns>
        public string GetMail()
        {
            return mail;
        }
        /// <summary>
        /// Permet de changer la valeur de service
        /// </summary>
        /// <param name="service"></param>
        public void SetService(string service)
        {
            this.service = service;
        }
        /// <summary>
        /// Retourne service
        /// </summary>
        /// <returns></returns>
        public string GetService()
        {
            return service;
        }
        
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        public BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public frmModificationPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListeService();
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirListeService()
        {
            controle.GetLesServices(bdgService);
            cbbService.DataSource = bdgService;
            if (cbbService.Items.Count > 0)
            {
                cbbService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Remplis les zones de texte au chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificationPersonnel_Load(object sender, EventArgs e)
        {
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtTel.Text = tel;
            txtMail.Text = mail;
            cbbService.SelectedIndex = cbbService.FindStringExact(service);
        }

        /// <summary>
        /// Annule les modifications et retourne à la liste des personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            controle.AnnulerUpdatePersonnel();
        }

        /// <summary>
        /// Enregistre les modifications du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModif_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cbbService.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment enregistrer ?", "Confirmation d'enregistrement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.EnrUpdatePersonnel(txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
                }
                
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
