﻿namespace Parc_Auto.Forms
{
    partial class FLouerVoiture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_FLouerVoiture_voiture = new System.Windows.Forms.ComboBox();
            this.cb_FLouerVoiture_personne = new System.Windows.Forms.ComboBox();
            this.bt_FLouerVoiture_fermer = new System.Windows.Forms.Button();
            this.bt_FLouerVoiture_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Louer une voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personne :";
            // 
            // cb_FLouerVoiture_voiture
            // 
            this.cb_FLouerVoiture_voiture.FormattingEnabled = true;
            this.cb_FLouerVoiture_voiture.Location = new System.Drawing.Point(257, 112);
            this.cb_FLouerVoiture_voiture.Name = "cb_FLouerVoiture_voiture";
            this.cb_FLouerVoiture_voiture.Size = new System.Drawing.Size(121, 21);
            this.cb_FLouerVoiture_voiture.TabIndex = 3;
            // 
            // cb_FLouerVoiture_personne
            // 
            this.cb_FLouerVoiture_personne.FormattingEnabled = true;
            this.cb_FLouerVoiture_personne.Location = new System.Drawing.Point(257, 166);
            this.cb_FLouerVoiture_personne.Name = "cb_FLouerVoiture_personne";
            this.cb_FLouerVoiture_personne.Size = new System.Drawing.Size(121, 21);
            this.cb_FLouerVoiture_personne.TabIndex = 4;
            // 
            // bt_FLouerVoiture_fermer
            // 
            this.bt_FLouerVoiture_fermer.Location = new System.Drawing.Point(134, 246);
            this.bt_FLouerVoiture_fermer.Name = "bt_FLouerVoiture_fermer";
            this.bt_FLouerVoiture_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FLouerVoiture_fermer.TabIndex = 5;
            this.bt_FLouerVoiture_fermer.Text = "Fermer";
            this.bt_FLouerVoiture_fermer.UseVisualStyleBackColor = true;
            this.bt_FLouerVoiture_fermer.Click += new System.EventHandler(this.bt_FLouerVoiture_fermer_Click);
            // 
            // bt_FLouerVoiture_valider
            // 
            this.bt_FLouerVoiture_valider.Location = new System.Drawing.Point(372, 246);
            this.bt_FLouerVoiture_valider.Name = "bt_FLouerVoiture_valider";
            this.bt_FLouerVoiture_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_FLouerVoiture_valider.TabIndex = 6;
            this.bt_FLouerVoiture_valider.Text = "Valider";
            this.bt_FLouerVoiture_valider.UseVisualStyleBackColor = true;
            this.bt_FLouerVoiture_valider.Click += new System.EventHandler(this.bt_FLouerVoiture_valider_Click);
            // 
            // FLouerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 292);
            this.Controls.Add(this.bt_FLouerVoiture_valider);
            this.Controls.Add(this.bt_FLouerVoiture_fermer);
            this.Controls.Add(this.cb_FLouerVoiture_personne);
            this.Controls.Add(this.cb_FLouerVoiture_voiture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FLouerVoiture";
            this.Text = "Louer une Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_FLouerVoiture_voiture;
        private System.Windows.Forms.ComboBox cb_FLouerVoiture_personne;
        private System.Windows.Forms.Button bt_FLouerVoiture_fermer;
        private System.Windows.Forms.Button bt_FLouerVoiture_valider;
    }
}