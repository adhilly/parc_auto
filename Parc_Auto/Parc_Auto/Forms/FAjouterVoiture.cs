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
    public partial class FAjouterVoiture : Form
    {
        private List<Voiture> lesVoitures;

        public FAjouterVoiture()
        {
            InitializeComponent();
            lesVoitures = new List<Voiture>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccueil accueil = new frmAccueil();
                accueil.UneAgence.setParcVoitures(lesVoitures);
                accueil.Show();
                this.Hide();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                
                string categorie = tb_FAjouterVoiture_Categorie.Text;
                string date = tb_FAjouterVoiture_DateMiseService.Text;
                bool louee = false;
                if (rb_FAjouterVoiture_Oui.Checked)
                    louee = true;
                string immatriculation = tb_FAjouterVoiture_Immatriculation.Text;
                string loueur = tb_FAjouterVoiture_Loueur.Text;
                string nom = tb_FAjouterVoiture_Nom.Text;
                int puissance = int.Parse(tb_FAjouterVoiture_Puissance.Text);
                Voiture uneVoiture= new Voiture(categorie, date, louee, immatriculation, loueur, nom, puissance);
                lesVoitures.Add(uneVoiture);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
=======
            string categorie = tb_FAjouterVoiture_Categorie.Text;
            string date = tb_FAjouterVoiture_DateMiseService.Text;
            bool louee;
            string immatriculation = tb_FAjouterVoiture_Immatriculation.Text;
            string loueur = tb_FAjouterVoiture_Loueur.Text;
            string nom = tb_FAjouterVoiture_Nom.Text;
            int puissance = int.Parse(tb_FAjouterVoiture_Puissance.Text);
            Voiture uneVoiture = new Voiture();
>>>>>>> 4ce9ccf14bac43a64686edd42477a48b81fde3b9
        }
    }
}
