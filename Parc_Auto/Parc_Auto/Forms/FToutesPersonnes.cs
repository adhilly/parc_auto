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

    public partial class FToutesPersonnes : Form
    {
        private Personne unePersonne; 
        public FToutesPersonnes()
        {
            InitializeComponent();
        }

        public FToutesPersonnes(Personne personne)
        {
            unePersonne = personne;
        }

        private void bt_FToutesPersonnes_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
