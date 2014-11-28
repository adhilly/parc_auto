namespace Parc_Auto.Forms
{
    partial class FToutesVoitures
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
            this.dgv_FToutesVoitures = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_FToutesVoitures_Nom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_FToutesVoitures_TrierSur = new System.Windows.Forms.ComboBox();
            this.bt_FToutesVoitures_Fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FToutesVoitures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_FToutesVoitures
            // 
            this.dgv_FToutesVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FToutesVoitures.Location = new System.Drawing.Point(15, 63);
            this.dgv_FToutesVoitures.Name = "dgv_FToutesVoitures";
            this.dgv_FToutesVoitures.Size = new System.Drawing.Size(608, 305);
            this.dgv_FToutesVoitures.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la personne :";
            // 
            // cb_FToutesVoitures_Nom
            // 
            this.cb_FToutesVoitures_Nom.FormattingEnabled = true;
            this.cb_FToutesVoitures_Nom.Location = new System.Drawing.Point(126, 36);
            this.cb_FToutesVoitures_Nom.Name = "cb_FToutesVoitures_Nom";
            this.cb_FToutesVoitures_Nom.Size = new System.Drawing.Size(138, 21);
            this.cb_FToutesVoitures_Nom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trier sur :";
            // 
            // cb_FToutesVoitures_TrierSur
            // 
            this.cb_FToutesVoitures_TrierSur.FormattingEnabled = true;
            this.cb_FToutesVoitures_TrierSur.Location = new System.Drawing.Point(393, 36);
            this.cb_FToutesVoitures_TrierSur.Name = "cb_FToutesVoitures_TrierSur";
            this.cb_FToutesVoitures_TrierSur.Size = new System.Drawing.Size(132, 21);
            this.cb_FToutesVoitures_TrierSur.TabIndex = 4;
            // 
            // bt_FToutesVoitures_Fermer
            // 
            this.bt_FToutesVoitures_Fermer.Location = new System.Drawing.Point(273, 397);
            this.bt_FToutesVoitures_Fermer.Name = "bt_FToutesVoitures_Fermer";
            this.bt_FToutesVoitures_Fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FToutesVoitures_Fermer.TabIndex = 5;
            this.bt_FToutesVoitures_Fermer.Text = "Fermer";
            this.bt_FToutesVoitures_Fermer.UseVisualStyleBackColor = true;
            this.bt_FToutesVoitures_Fermer.Click += new System.EventHandler(this.bt_FToutesPersonnes_Fermer_Click);
            // 
            // FToutesVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 432);
            this.Controls.Add(this.bt_FToutesVoitures_Fermer);
            this.Controls.Add(this.cb_FToutesVoitures_TrierSur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_FToutesVoitures_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_FToutesVoitures);
            this.Name = "FToutesVoitures";
            this.Text = "Toutes les Voitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FToutesVoitures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FToutesVoitures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FToutesVoitures_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FToutesVoitures_TrierSur;
        private System.Windows.Forms.Button bt_FToutesVoitures_Fermer;
    }
}