using MediaTek86.dal;
using MediaTek86.modele;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.controle
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// instance de frmSeConnecter
        /// </summary>
        private frmSeConnecter frmSeConnecter;

        /// <summary>
        /// instance de frmListePersonnel
        /// </summary>
        private frmListePersonnel frmListePersonnel;

        /// <summary>
        /// instance de frmModificationPersonnel
        /// </summary>
        private frmModificationPersonnel frmModificationPersonnel;

        /// <summary>
        /// instance de frmModificationAbsence
        /// </summary>
        private frmModificationAbsence frmModificationAbsence;

        /// <summary>
        /// instance de frmGererAbsence
        /// </summary>
        private frmGererAbsence frmGererAbsence;

        /// <summary>
        /// Permet de sauvegarder le personnel séléctionné auparavant
        /// </summary>
        private Personnel savePersonnel;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmSeConnecter = new frmSeConnecter(this);
            frmSeConnecter.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmSeConnecter.Hide();
                frmListePersonnel = new frmListePersonnel(this);
                frmListePersonnel.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel provenant de la BDD
        /// </summary>
        /// <param name="bdgListe"></param>
        public void GetLesPersonnels(BindingSource bdgListe)
        {
            List<Personnel> lesPersonnels = AccesDonnees.GetLesPersonnels();
            bdgListe.DataSource = lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <param name="bdgListe"></param>
        public void GetLesServices(BindingSource bdgListe)
        {
            List<Service> lesServices = AccesDonnees.GetLesServices();
            bdgListe.DataSource = lesServices;
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <param name="bdgListe"></param>
        public void GetLesMotifs(BindingSource bdgListe)
        {
            List<Motif> lesMotifs = AccesDonnees.GetLesMotifs();
            bdgListe.DataSource = lesMotifs;
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="bdgListe"></param>
        public void GetLesAbsences(Personnel personnel, BindingSource bdgListe)
        {
            List<Absence> lesAbsences = AccesDonnees.GetLesAbsences(personnel);
            bdgListe.DataSource = lesAbsences;
        }

        /// <summary>
        /// Demande pour accéder aux absences d'un personnel
        /// </summary>
        public void DemGererAbsence()
        {
            Personnel personnel = (Personnel)frmListePersonnel.bdgPersonnel.List[frmListePersonnel.bdgPersonnel.Position];
            savePersonnel = personnel;
            frmGererAbsence = new frmGererAbsence(this);
            frmGererAbsence.RemplirListeAbsence(personnel);
            frmGererAbsence.SetNom(personnel.Nom);
            frmGererAbsence.SetPrenom(personnel.Prenom);
            frmGererAbsence.SetIdPersonnel(personnel.Idpersonnel);
            Console.WriteLine("Nom :" + personnel.Nom);
            Console.WriteLine("Prenom :" + personnel.Prenom);
            frmGererAbsence.ShowDialog();

        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public void AddDeveloppeur(string nom, string prenom, string tel, string mail)
        {
            Service service = (Service)frmListePersonnel.bdgService.List[frmListePersonnel.bdgService.Position];
            int idpersonnel = 0;
            Personnel personnel = new Personnel(idpersonnel, nom, prenom, tel, mail, service.Idservice, service.Nom);
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        public void DelPersonnel()
        {
            Personnel personnel = (Personnel)frmListePersonnel.bdgPersonnel.List[frmListePersonnel.bdgPersonnel.Position];
            if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AccesDonnees.DelAllAbsence(personnel);
                AccesDonnees.DelPersonnel(personnel);
            }
        }

        /// <summary>
        /// Demande pour acceder à la modification d'un personnel
        /// </summary>
        public void DemUpdatePersonnel()
        {
            // Ferme la fenêtre ouverte
            frmListePersonnel.Hide();
            frmModificationPersonnel = new frmModificationPersonnel(this);
            Personnel personnel = (Personnel)frmListePersonnel.bdgPersonnel.List[frmListePersonnel.bdgPersonnel.Position];
            frmModificationPersonnel.SetIdPersonnel(personnel.Idpersonnel);
            frmModificationPersonnel.SetNom(personnel.Nom);
            frmModificationPersonnel.SetPrenom(personnel.Prenom);
            frmModificationPersonnel.SetTel(personnel.Tel);
            frmModificationPersonnel.SetMail(personnel.Mail);
            frmModificationPersonnel.SetService(personnel.Service);
            // Ouvre la fenêtre frmModificationPersonnel
            frmModificationPersonnel.ShowDialog();
        }

        /// <summary>
        /// Demande pour acceder à la modification d'une absence
        /// </summary>
        public void DemUpdateAbsence()
        {
            // Ferme la fenêtre active
            frmGererAbsence.Hide();
            frmModificationAbsence = new frmModificationAbsence(this);
            Absence absence = (Absence)frmGererAbsence.bdgAbsence.List[frmGererAbsence.bdgAbsence.Position];
            frmModificationAbsence.SetIdPersonnel(absence.Idpersonnel);
            frmModificationAbsence.SetNom(absence.Nom);
            frmModificationAbsence.SetPrenom(absence.Prenom);
            frmModificationAbsence.SetDateDebut(absence.Date_de_debut);
            frmModificationAbsence.SetDateFin(absence.Date_de_fin);
            frmModificationAbsence.SetIdMotif(absence.Idmotif);
            frmModificationAbsence.SetMotif(absence.Motif);
            // Ouvre la fenêtre frmModificationPersonnel
            frmModificationAbsence.ShowDialog();
        }
        
        /// <summary>
        /// Demande pour annuler la modification d'un personnel 
        /// </summary>
        public void AnnulerUpdatePersonnel()
        {
            frmModificationPersonnel.Hide();
            frmListePersonnel = new frmListePersonnel(this);
            frmListePersonnel.ShowDialog();
        }

        /// <summary>
        /// Demande pour annuler la modification d'une absence
        /// </summary>
        public void AnnulerUpdateAbsence()
        {
            frmModificationAbsence.Hide();
            frmGererAbsence = new frmGererAbsence(this);
            frmGererAbsence.RemplirListeAbsence(savePersonnel);
            frmGererAbsence.SetNom(savePersonnel.Nom);
            frmGererAbsence.SetPrenom(savePersonnel.Prenom);
            frmGererAbsence.SetIdPersonnel(savePersonnel.Idpersonnel);
            Console.WriteLine("Nom :" + savePersonnel.Nom);
            Console.WriteLine("Prenom :" + savePersonnel.Prenom);
            frmGererAbsence.ShowDialog();
        }

        /// <summary>
        /// Demande pour retourner à la liste des personnels
        /// </summary>
        public void RetourListePerso()
        {
            frmGererAbsence.Hide();
            frmListePersonnel = new frmListePersonnel(this);
            frmListePersonnel.ShowDialog();
        }

        /// <summary>
        /// Enregistre les modifications d'un personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public void EnrUpdatePersonnel(string nom, string prenom, string tel, string mail)
        {
            Service service = (Service)frmModificationPersonnel.bdgService.List[frmModificationPersonnel.bdgService.Position];
            Personnel personnel = new Personnel(frmModificationPersonnel.GetIdPersonnel(), nom, prenom, tel, mail, service.Idservice, service.Nom);
            AccesDonnees.UpdatePersonnel(personnel);
            frmModificationPersonnel.Hide();
            frmListePersonnel = new frmListePersonnel(this);
            frmListePersonnel.ShowDialog();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        public void AddAbsence(int idpersonnel, string nom, string prenom, DateTime datedebut, DateTime datefin)
        {
            Console.WriteLine(frmGererAbsence.GetIdPersonnel());
            Motif motif = (Motif)frmGererAbsence.bdgMotif.List[frmGererAbsence.bdgMotif.Position];
            Personnel personnel = new Personnel(frmGererAbsence.GetIdPersonnel(), null, null, null, null, 0, null);
            Absence absence = new Absence(idpersonnel, nom, prenom, datedebut, datefin, motif.Idmotif, motif.Libelle);
            AccesDonnees.AddAbsence(absence);
            frmGererAbsence.RemplirListeAbsence(personnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        public void DelAbsence()
        {
            Absence absence = (Absence)frmGererAbsence.bdgAbsence.List[frmGererAbsence.bdgAbsence.Position];
            Personnel personnel = new Personnel(frmGererAbsence.GetIdPersonnel(), null, null, null, null, 0, null);
            if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AccesDonnees.DelAbsence(absence);
                frmGererAbsence.RemplirListeAbsence(personnel);
            } 
        }

        /// <summary>
        /// Enregistre les modifications d'une absence
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        public void EnrUpdateAbsence(DateTime datedebut, DateTime datefin)
        {
            frmModificationAbsence frm = frmModificationAbsence;
            Motif motif = (Motif)frm.bdgMotif.List[frm.bdgMotif.Position];
            Absence absence = new Absence(frm.GetIdPersonnel(), frm.GetNom(), frm.GetPrenom(), frm.GetDateDebut(), frm.GetDateFin(), motif.Idmotif, motif.Libelle);
            AccesDonnees.UpdateAbsence(absence, datedebut, datefin);
            frmModificationAbsence.Hide();
            frmGererAbsence = new frmGererAbsence(this);
            Personnel personnel = new Personnel(frm.GetIdPersonnel(), frm.GetNom(), frm.GetPrenom(), null, null, 0, null);
            frmGererAbsence.RemplirListeAbsence(personnel);
            frmGererAbsence.SetNom(frmModificationAbsence.GetNom());
            frmGererAbsence.SetPrenom(frmModificationAbsence.GetPrenom());
            frmGererAbsence.ShowDialog();
        }
    }
}
