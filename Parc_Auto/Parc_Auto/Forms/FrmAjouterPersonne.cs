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
        private List<Personne> lesPersonnes;
        public FrmAjouterPersonne()
        {
            InitializeComponent();
            lesPersonnes = new List<Personne>();
        }

        private void bt_FAJouterPersonne_Fermer_Click(object sender, EventArgs e)
        {
            frmAccueil accueil = new frmAccueil();
            accueil.UneAgence.setLesPersonnes(lesPersonnes);
            accueil.Show();
            this.Hide();
        }

        private void bt_FAJouterPersonne_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tb_FAJouterPersonne_Nom.Text;
                string prenom = tb_FAJouterPersonne_Prenom.Text;
                string ville = tb_FAJouterPersonne_Ville.Text;
                Personne unePersonne = new Personne(nom, prenom, ville);
                lesPersonnes.Add(unePersonne);
                tb_FAJouterPersonne_Nom.Clear();
                tb_FAJouterPersonne_Prenom.Clear();
                tb_FAJouterPersonne_Ville.Clear();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
