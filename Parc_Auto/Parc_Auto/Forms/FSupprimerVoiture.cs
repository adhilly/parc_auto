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
        private Voiture uneVoiture;
        public FSupprimerVoiture()
        {
            InitializeComponent();
        }
        public FSupprimerVoiture(Voiture voiture)
        {
            uneVoiture = voiture;
            InitializeComponent();
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
