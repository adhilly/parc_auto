using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using System.Xml.Serialization;

namespace Parc_Auto
{
    public partial class frmAccueil : Form
    {
        private Agence uneAgence;
<<<<<<< HEAD

        public Agence UneAgence
        {
            get { return uneAgence; }
            set { uneAgence = value; }
        }

=======
>>>>>>> 4ce9ccf14bac43a64686edd42477a48b81fde3b9
        public frmAccueil()
        {
            InitializeComponent();
            uneAgence = new Agence();
            
        }

        #region Sérialisation / Désérialisation Binaire
        /// <summary>
        /// Méthode de désérialisation binaire
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void importerBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On affiche une fenêtre permettant de choisir un fichier à charger
            OpenFileDialog FileDialogBin = new OpenFileDialog();
            FileDialogBin.Title = "Choisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            //Si l'utilisateur clique sur "Charger"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier à charger
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream unFlux = null;
                BinaryFormatter fs;
                try
                {
                    //On ouvre un flux binaire
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Open);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    //On vide la collection avant de récupérer le contenu désérialiser
                    uneAgence = (Agence)fs.Deserialize(unFlux);
                    //On affiche un message indiquant le succès de la désérialisation
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    unFlux.Close();
                }
            }
        }

        /// <summary>
        /// Méthode de sérialisation binaire
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exporterBinaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On affiche une fenêtre permettant de saisir un fichier dans lequel sauvegarder
            SaveFileDialog FileDialogBin = new SaveFileDialog();
            FileDialogBin.Title = "Saisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            //Si l'utilisateur clique sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet choisi dans lequel on remplace \ par \\
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                //On crée un flux binaire de sortie
                FileStream unFlux = null;
                BinaryFormatter fs;
                String nom_fichier = nomFichier;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Create);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    fs.Serialize(unFlux, uneAgence);
                    //S'il n'y a pas eu d'erreurs on affiche un message qui en informe l'utilisateur
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("/n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    unFlux.Close();
                }

        #endregion
            }
        }

        #region Sérialisation / Désérialisation XML
        /// <summary>
        /// Méthode de désérialisation XML
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void importerXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialogXML = new OpenFileDialog();
            fileDialogXML.Title = "Choisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream stream = null;
                XmlSerializer serializer;
                Directory.SetCurrentDirectory(chemin);
                if (File.Exists(nomFichier))
                {
                    try
                    {
                        stream = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
                        serializer = new XmlSerializer(typeof(Agence));
                        uneAgence = (Agence)serializer.Deserialize(stream);
                        stream.Close();
                        MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Méthode de désérialisation XML
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void exporterXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialogXML = new SaveFileDialog();
            fileDialogXML.Title = "Saisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream stream = null;
                XmlSerializer serializer;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    stream = new FileStream(nomFichier, FileMode.Create);
                    serializer = new XmlSerializer(typeof(Agence));
                    serializer.Serialize(stream, uneAgence);
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
        }
        #endregion

        private Voiture uneVoiture;
        private Personne unePersonne;

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FAjouterVoiture unFajouterVoiture = new Forms.FAjouterVoiture();
            unFajouterVoiture.ShowDialog();
            this.Hide();
        }


        private void ajouterUneLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            Forms.FLouerVoiture unLouerVoiture = new Forms.FLouerVoiture(uneVoiture);
            unLouerVoiture.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            Forms.FSupprimerVoiture unSupprimerVoiture = new Forms.FSupprimerVoiture(uneVoiture);
            unSupprimerVoiture.ShowDialog();
        }

        private void supprimerUneLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            Forms.FRendreVoiture rendreUneVoiture = new Forms.FRendreVoiture(uneVoiture);
            rendreUneVoiture.ShowDialog();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            Forms.FToutesVoitures toutesVoiture = new Forms.FToutesVoitures(uneVoiture);
            toutesVoiture.ShowDialog();
        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unePersonne = new Personne();
            Forms.FToutesPersonnes toutesPersonnes = new Forms.FToutesPersonnes(unePersonne);
            toutesPersonnes.ShowDialog();
        }

        private void supprimerUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Forms.FSupprimerPersonne unSupprimerPersonne = new Forms.FSupprimerPersonne();
=======
            unePersonne = new Personne();
            Forms.FSupprimerPersonne unSupprimerPersonne = new Forms.FSupprimerPersonne(unePersonne);
>>>>>>> 4ce9ccf14bac43a64686edd42477a48b81fde3b9
            unSupprimerPersonne.ShowDialog();
        }
        private void ajouterUnePersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Forms.FrmAjouterPersonne ajouterPersonne = new Forms.FrmAjouterPersonne();
=======
            unePersonne = new Personne();
            Forms.FrmAjouterPersonne ajouterPersonne = new Forms.FrmAjouterPersonne(unePersonne);
>>>>>>> 4ce9ccf14bac43a64686edd42477a48b81fde3b9
            ajouterPersonne.ShowDialog();
        }















    }
}
