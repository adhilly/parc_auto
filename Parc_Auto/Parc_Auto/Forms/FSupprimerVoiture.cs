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
    public partial class FSupprimerVoiture : Form
    {
        private Agence uneAgence;

        public FSupprimerVoiture()
        {
            InitializeComponent();
        }

        public FSupprimerVoiture(Agence uneAgence)
        {
            InitializeComponent();
            this.uneAgence = uneAgence;

            foreach (Voiture item in uneAgence.getParcVoitures())
            {
                cb_FSupprimerVoiture_immatriculation.Items.Add(item.getNom());
            }
        }

        private void bt_FSupprimerVoiture_fermer_Click(object sender, EventArgs e)
        {

        }

        private void bt_FSupprimerVoiture_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Voiture voitureASupprimer = new Voiture();
                foreach (Voiture item in uneAgence.getParcVoitures())
                {
                    if (cb_FSupprimerVoiture_immatriculation.SelectedItem == item.getNom())
                        voitureASupprimer = item;
                }
                uneAgence.getParcVoitures().Remove(voitureASupprimer);
                cb_FSupprimerVoiture_immatriculation.Items.Clear();
                foreach (Personne item in uneAgence.getLesPersonnes())
                {
                    cb_FSupprimerVoiture_immatriculation.Items.Add(item.getNom());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bt_FSupprimerVoiture_supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_FSupprimerVoiture_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
