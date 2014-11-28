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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
        }

        private void rb_FAjouterVoiture_Oui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_FAjouterVoiture_Non_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
