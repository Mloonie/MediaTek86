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
    public partial class frmSeConnecter : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public frmSeConnecter(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Permet de se connecter à l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtMotDePasse.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtLogin.Text, txtMotDePasse.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    txtLogin.Text = "";
                    txtMotDePasse.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
