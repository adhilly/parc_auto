namespace Parc_Auto.Forms
{
    partial class FAjouterVoiture
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
            this.cb_FSupprimerVoiture = new System.Windows.Forms.ComboBox();
            this.bt_FSuprimerVoiture_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Immatricualtion :";
            // 
            // cb_FSupprimerVoiture
            // 
            this.cb_FSupprimerVoiture.FormattingEnabled = true;
            this.cb_FSupprimerVoiture.Location = new System.Drawing.Point(101, 22);
            this.cb_FSupprimerVoiture.Name = "cb_FSupprimerVoiture";
            this.cb_FSupprimerVoiture.Size = new System.Drawing.Size(121, 21);
            this.cb_FSupprimerVoiture.TabIndex = 1;
            // 
            // bt_FSuprimerVoiture_Supprimer
            // 
            this.bt_FSuprimerVoiture_Supprimer.Location = new System.Drawing.Point(123, 84);
            this.bt_FSuprimerVoiture_Supprimer.Name = "bt_FSuprimerVoiture_Supprimer";
            this.bt_FSuprimerVoiture_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_FSuprimerVoiture_Supprimer.TabIndex = 2;
            this.bt_FSuprimerVoiture_Supprimer.Text = "Supprimer";
            this.bt_FSuprimerVoiture_Supprimer.UseVisualStyleBackColor = true;
            // 
            // FAjouterVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 140);
            this.Controls.Add(this.bt_FSuprimerVoiture_Supprimer);
            this.Controls.Add(this.cb_FSupprimerVoiture);
            this.Controls.Add(this.label1);
            this.Name = "FAjouterVoiture";
            this.Text = "Supprimer une Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FSupprimerVoiture;
        private System.Windows.Forms.Button bt_FSuprimerVoiture_Supprimer;

    }
}