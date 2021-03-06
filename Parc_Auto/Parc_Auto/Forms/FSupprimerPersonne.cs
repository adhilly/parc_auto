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
    public partial class FSupprimerPersonne : Form
    {
        private Agence uneAgence;
        public FSupprimerPersonne()
        {
            InitializeComponent();
        }
        public FSupprimerPersonne(Agence uneAgence)
        {
            InitializeComponent();
            this.uneAgence = uneAgence;
            foreach (Personne item in uneAgence.getLesPersonnes())
            {
                cb_FSupprimerPersonne_nom.Items.Add(item.getNom());
            }
        }

        private void bt_FSupprimerPersonne_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void bt_FSupprimerPersonne_supprimer_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Personne personneAsupprimer = new Personne();
        //        foreach (Personne item in uneAgence.getLesPersonnes())
        //        {
        //            if (cb_FSupprimerPersonne_nom.SelectedItem == item.getNom())
        //                personneAsupprimer = item;
        //        }
        //        uneAgence.getLesPersonnes().Remove(personneAsupprimer);
        //        cb_FSupprimerPersonne_nom.Items.Clear();
        //        foreach (Personne item in uneAgence.getLesPersonnes())
        //        {
        //            cb_FSupprimerPersonne_nom.Items.Add(item.getNom());
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //    }
        //}
        }
    }
