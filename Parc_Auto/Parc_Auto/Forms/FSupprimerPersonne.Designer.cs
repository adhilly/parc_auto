namespace Parc_Auto.Forms
{
    partial class FSupprimerPersonne
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
            this.cb_FSupprimerPersonne_nom = new System.Windows.Forms.ComboBox();
            this.bt_FSupprimerPersonne_supprimer = new System.Windows.Forms.Button();
            this.bt_FSupprimerPersonne_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer une personne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // cb_FSupprimerPersonne_nom
            // 
            this.cb_FSupprimerPersonne_nom.FormattingEnabled = true;
            this.cb_FSupprimerPersonne_nom.Location = new System.Drawing.Point(53, 103);
            this.cb_FSupprimerPersonne_nom.Name = "cb_FSupprimerPersonne_nom";
            this.cb_FSupprimerPersonne_nom.Size = new System.Drawing.Size(121, 21);
            this.cb_FSupprimerPersonne_nom.TabIndex = 2;
            // 
            // bt_FSupprimerPersonne_supprimer
            // 
            this.bt_FSupprimerPersonne_supprimer.Location = new System.Drawing.Point(126, 186);
            this.bt_FSupprimerPersonne_supprimer.Name = "bt_FSupprimerPersonne_supprimer";
            this.bt_FSupprimerPersonne_supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_FSupprimerPersonne_supprimer.TabIndex = 3;
            this.bt_FSupprimerPersonne_supprimer.Text = "Supprimer";
            this.bt_FSupprimerPersonne_supprimer.UseVisualStyleBackColor = true;
            // 
            // bt_FSupprimerPersonne_fermer
            // 
            this.bt_FSupprimerPersonne_fermer.Location = new System.Drawing.Point(385, 186);
            this.bt_FSupprimerPersonne_fermer.Name = "bt_FSupprimerPersonne_fermer";
            this.bt_FSupprimerPersonne_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FSupprimerPersonne_fermer.TabIndex = 4;
            this.bt_FSupprimerPersonne_fermer.Text = "Fermer";
            this.bt_FSupprimerPersonne_fermer.UseVisualStyleBackColor = true;
            // 
            // FSupprimerPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 260);
            this.Controls.Add(this.bt_FSupprimerPersonne_fermer);
            this.Controls.Add(this.bt_FSupprimerPersonne_supprimer);
            this.Controls.Add(this.cb_FSupprimerPersonne_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSupprimerPersonne";
            this.Text = "Supprimer une Personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FSupprimerPersonne_nom;
        private System.Windows.Forms.Button bt_FSupprimerPersonne_supprimer;
        private System.Windows.Forms.Button bt_FSupprimerPersonne_fermer;
    }
}