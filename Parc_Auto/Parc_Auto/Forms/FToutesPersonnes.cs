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
        private List<Personne> unePersonne;

        public FToutesPersonnes()
        {
            InitializeComponent();
        }
        public FToutesPersonnes(List<Personne> unePersonne)
        {
            InitializeComponent();
            this.unePersonne = unePersonne;

        }
    }
}
