using MediaTek86.connexion;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    public class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// /// </summary>
        private static string connectionString = "server=localhost;user id=admin;password=wHIwAcI3DijYBRvO;database=mediatek86;SslMode=none";

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable r ";
            req += "where r.login=@login and r.pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne le personnel provenant de la BDD
        /// </summary>
        /// <returns>liste du personnel</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select idpersonnel, p.nom as nom, prenom, tel, mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p JOIN service s ON p.idservice = s.idservice ";
            req += "order by nom";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by nom";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel provenant de la BDD
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public static List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select p.idpersonnel, p.nom as nom, p.prenom as prenom, a.datedebut as datedebut, a.datefin as datefin, m.libelle as motif, m.idmotif as idmotif ";
            req += "from personnel p JOIN absence a ON p.idpersonnel = a.idpersonnel JOIN motif m ON a.idmotif = m.idmotif ";
            req += "where p.idpersonnel = @idpersonnel ";
            req += "order by datedebut desc";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            while (curs.Read())
            {
                Absence absence = new Absence((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (DateTime)curs.Field("datedebut"), (DateTime)curs.Field("datefin"), (int)curs.Field("idmotif"), (string)curs.Field("motif"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns></returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "select * from motif order by libelle";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Motif motif = new Motif((int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curs.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
            req += "values (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absence absence)
        {
            string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
            req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Date_de_debut);
            parameters.Add("@datefin", absence.Date_de_fin);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprime la totalité des absences d'un personel
        /// </summary>
        /// <param name="personnel"></param>
        public static void DelAllAbsence(Personnel personnel)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void DelAbsence(Absence absence)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel and idmotif = @idmotif and datedebut = @datedebut and datefin = @datefin;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@datedebut", absence.Date_de_debut);
            parameters.Add("@datefin", absence.Date_de_fin);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="newdatedebut"></param>
        /// <param name="newdatefin"></param>
        public static void UpdateAbsence(Absence absence, DateTime newdatedebut, DateTime newdatefin)
        {
            string req = "update absence set datedebut = @newdatedebut, datefin = @newdatefin, idmotif = @idmotif ";
            req += "where idpersonnel = @idpersonnel and datedebut = @datedebut and datefin = @datefin;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@newdatedebut", newdatedebut);
            parameters.Add("@newdatefin", newdatefin);
            parameters.Add("@datedebut", absence.Date_de_debut);
            parameters.Add("@datefin", absence.Date_de_fin);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }

}
