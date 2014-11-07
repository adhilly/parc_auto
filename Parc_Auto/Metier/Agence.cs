using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metier
{
    public class Agence
    {
        /// <summary>
        /// propriétés 
        /// </summary>
        private List<Personne> lesPersonnes;
        private string nom;
        private List<Voiture> parcVoitures;

        /// <summary>
        /// accesseurs et mutateurs
        /// </summary>
        /// <returns></returns>
        public List<Personne> getLesPersonnes()
        {
            return lesPersonnes;
        }
        public void setLesPersonnes(List<Personne> lesPersonnes)
        {
            this.lesPersonnes = lesPersonnes;
        }
        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public List<Voiture> getParcVoitures()
        {
            return parcVoitures;
        }
        public void setParcVoitures(List<Voiture> parcVoitures)
        {
            this.parcVoitures = parcVoitures;
        }

        /// <summary>
        /// constructeur vide
        /// </summary>
        public Agence() { }

        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="lesPersonnes"></param>
        /// <param name="nom"></param>
        /// <param name="parcVoitures"></param>
        public Agence(List<Personne> lesPersonnes, string nom, List<Voiture> parcVoitures)
        {
            this.lesPersonnes = lesPersonnes;
            this.nom = nom;
            this.parcVoitures = parcVoitures;
        }

        /// <summary>
        /// ajout de personnes dans la liste
        /// </summary>
        /// <param name="unePersonne"></param>
        public void AjouterPersonne(Personne unePersonne)
        {
            lesPersonnes.Add(unePersonne);
        }

        /// <summary>
        /// ajout de voitures dans la liste
        /// </summary>
        /// <param name="uneVoiture"></param>
        public void AjouterVoiture(Voiture uneVoiture)
        {
            parcVoitures.Add(uneVoiture);
        }
        /// <summary>
        /// méthode permétant de louer une voiture
        /// </summary>
        /// <param name="immatriculation"></param>
        public void LouerVoiture(string immatriculation)
        {
            foreach (Voiture item in parcVoitures)
            {
                if (item.getImmatriculation() == immatriculation)
                    item.setEstLouee(true);
            }
        }
        /// <summary>
        /// méthode perméttant de rendre la voiture
        /// </summary>
        /// <param name="immatriculation"></param>
        public void RendreVoiture(string immatriculation)
        {
            foreach (Voiture item in parcVoitures)
            {
                if (item.getImmatriculation() == immatriculation)
                    item.setEstLouee(false);
            }
        }
    }
}
