﻿using System;
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
    public partial class FLouerVoiture : Form
    {
        private Voiture uneVoiture;
        public FLouerVoiture()
        {
            InitializeComponent();
        }
        public FLouerVoiture(Voiture voiture)
        {
            uneVoiture = voiture;
            InitializeComponent();
        }

        private void bt_FLouerVoiture_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_FLouerVoiture_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
