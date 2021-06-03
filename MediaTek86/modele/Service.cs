using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe Service
    /// </summary>
    public class Service
    {
        private int idservice;
        private string nom;

        /// <summary>
        /// Retourne idservice
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// Retourne nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.nom;
        }

    }
}
