using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace Parc_Auto.Forms
{
    public partial class FrmAjouterPersonne : Form
    {
        private Personne unePersonne;
        private Agence agence;


        public FrmAjouterPersonne()
        {
            InitializeComponent();
            unePersonne = new Personne();
            agence = new Agence();
        }

        private void bt_FAJouterPersonne_Fermer_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil(agence);
            accueil.Show();
            FAjouterVoiture voiture = new FAjouterVoiture();
            voiture.Close();
        }

        private void bt_FAJouterPersonne_Ajouter_Click(object sender, EventArgs e)
        {
            try { 
            unePersonne.setNom(tb_FAJouterPersonne_Nom.Text);
            unePersonne.setPrenom(tb_FAJouterPersonne_Prenom.Text);
            unePersonne.setVille(tb_FAJouterPersonne_Ville.Text);
            agence.getLesPersonnes().Add(unePersonne);
                }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
