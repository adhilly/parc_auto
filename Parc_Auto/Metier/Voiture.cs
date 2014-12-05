using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    [Serializable]
    public class Voiture
    {

        //propriétés de la classe voiture
        private string categorie;
        private string dateMiseService;
        private bool estLouee;
        private string immatriculation;
        private string loueur;
        private string nom;
        private int puissance;

        /// <summary>
        /// accesseurs et muttateurs
        /// </summary>
        /// <returns></returns>
        public string getCategorie()
        {
            return categorie;
        }
        public void setCategorie(string categorie)
        {
            this.categorie = categorie;
        }
        public string getDateMiseService()
        {
            return dateMiseService;
        }
        public void setDateMiseService(string dateMiseService)
        {
            this.dateMiseService = dateMiseService;
        }
        public bool getEstLouee()
        {
            return estLouee;
        }
        public void setEstLouee(bool estLouee)
        {
            this.estLouee = estLouee;
        }
        public string getImmatriculation()
        {
            return immatriculation;
        }
        public void setImmatriculation(string immatriculation)
        {
            this.immatriculation = immatriculation;
        }
        public string getLoueur()
        {
            return loueur;
        }
        public void setLoueur(string loueur)
        {
            this.loueur = loueur;
        }
        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public int getPuissance()
        {
            return puissance;
        }
        public void setPuissance(int puissance)
        {
            this.puissance = puissance;
        }

        /// <summary>
        /// constructeur vide
        /// </summary>
        public Voiture()
        {

        }
        /// <summary>
        /// constructeur avec paramètres
        /// </summary>
        /// <param name="categorie"></param>
        /// <param name="dateMiseService"></param>
        /// <param name="estLouee"></param>
        /// <param name="immatriculation"></param>
        /// <param name="loueur"></param>
        /// <param name="nom"></param>
        /// <param name="puissance"></param>
        public Voiture(string categorie, string dateMiseService, bool estLouee, string immatriculation, string loueur, string nom, int puissance)
        {
            this.categorie = categorie;
            this.dateMiseService = dateMiseService;
            this.estLouee = estLouee;
            this.immatriculation = immatriculation;
            this.loueur = loueur;
            this.nom = nom;
            this.puissance = puissance;
        }

    }
}
