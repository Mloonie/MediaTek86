using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Création d'un motif
    /// </summary>
    public class Motif
    {
        // Déclaration des propriétés
        private int idmotif;
        private string libelle;
        
        /// <summary>
        /// Retourne idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// Retourne libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
