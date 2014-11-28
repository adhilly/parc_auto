namespace Parc_Auto.Forms
{
    partial class FSupprimerVoiture
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
            this.cb_FSupprimerVoiture_immatriculation = new System.Windows.Forms.ComboBox();
            this.bt_FSupprimerVoiture_supprimer = new System.Windows.Forms.Button();
            this.bt_FSupprimerVoiture_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer une voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Immatriculation :";
            // 
            // cb_FSupprimerVoiture_immatriculation
            // 
            this.cb_FSupprimerVoiture_immatriculation.FormattingEnabled = true;
            this.cb_FSupprimerVoiture_immatriculation.Location = new System.Drawing.Point(274, 119);
            this.cb_FSupprimerVoiture_immatriculation.Name = "cb_FSupprimerVoiture_immatriculation";
            this.cb_FSupprimerVoiture_immatriculation.Size = new System.Drawing.Size(121, 21);
            this.cb_FSupprimerVoiture_immatriculation.TabIndex = 2;
            // 
            // bt_FSupprimerVoiture_supprimer
            // 
            this.bt_FSupprimerVoiture_supprimer.Location = new System.Drawing.Point(79, 215);
            this.bt_FSupprimerVoiture_supprimer.Name = "bt_FSupprimerVoiture_supprimer";
            this.bt_FSupprimerVoiture_supprimer.Size = new System.Drawing.Size(103, 23);
            this.bt_FSupprimerVoiture_supprimer.TabIndex = 3;
            this.bt_FSupprimerVoiture_supprimer.Text = "Supprimer";
            this.bt_FSupprimerVoiture_supprimer.UseVisualStyleBackColor = true;
            this.bt_FSupprimerVoiture_supprimer.Click += new System.EventHandler(this.bt_FSupprimerVoiture_supprimer_Click);
            // 
            // bt_FSupprimerVoiture_fermer
            // 
            this.bt_FSupprimerVoiture_fermer.Location = new System.Drawing.Point(445, 215);
            this.bt_FSupprimerVoiture_fermer.Name = "bt_FSupprimerVoiture_fermer";
            this.bt_FSupprimerVoiture_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FSupprimerVoiture_fermer.TabIndex = 4;
            this.bt_FSupprimerVoiture_fermer.Text = "Fermer";
            this.bt_FSupprimerVoiture_fermer.UseVisualStyleBackColor = true;
            this.bt_FSupprimerVoiture_fermer.Click += new System.EventHandler(this.bt_FSupprimerVoiture_fermer_Click);
            // 
            // FSupprimerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 272);
            this.Controls.Add(this.bt_FSupprimerVoiture_fermer);
            this.Controls.Add(this.bt_FSupprimerVoiture_supprimer);
            this.Controls.Add(this.cb_FSupprimerVoiture_immatriculation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FSupprimerVoiture";
            this.Text = "Supprimer une Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FSupprimerVoiture_immatriculation;
        private System.Windows.Forms.Button bt_FSupprimerVoiture_supprimer;
        private System.Windows.Forms.Button bt_FSupprimerVoiture_fermer;
    }
}