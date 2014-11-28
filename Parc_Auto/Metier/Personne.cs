using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
     public class Personne
    {
        /// <summary>
        /// propriétés
        /// </summary>
        private string nom;
        private string prenom;
        private string ville;

        /// <summary>
        /// accesseurs et muttateurs
        /// </summary>
        /// <returns></returns>
        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        public string getVille()
        {
            return ville;
        }
        public void setVille(string ville)
        {
            this.ville = ville;
        }

        public Personne() { }

        public Personne(string nom, string prenom, string ville) {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }

    }
}
