namespace Parc_Auto.Forms
{
    partial class FToutesPersonnes
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
            this.bt_FToutesPersonnes_Fermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_FToutesPersonnes_Nom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_FToutesPersonnes_TrierSur = new System.Windows.Forms.ComboBox();
            this.dgv_FToutesPersonnes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FToutesPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_FToutesPersonnes_Fermer
            // 
            this.bt_FToutesPersonnes_Fermer.Location = new System.Drawing.Point(262, 429);
            this.bt_FToutesPersonnes_Fermer.Name = "bt_FToutesPersonnes_Fermer";
            this.bt_FToutesPersonnes_Fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FToutesPersonnes_Fermer.TabIndex = 0;
            this.bt_FToutesPersonnes_Fermer.Text = "Fermer";
            this.bt_FToutesPersonnes_Fermer.UseVisualStyleBackColor = true;
            this.bt_FToutesPersonnes_Fermer.Click += new System.EventHandler(this.bt_FToutesPersonnes_Fermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la personne :";
            // 
            // cb_FToutesPersonnes_Nom
            // 
            this.cb_FToutesPersonnes_Nom.FormattingEnabled = true;
            this.cb_FToutesPersonnes_Nom.Location = new System.Drawing.Point(126, 30);
            this.cb_FToutesPersonnes_Nom.Name = "cb_FToutesPersonnes_Nom";
            this.cb_FToutesPersonnes_Nom.Size = new System.Drawing.Size(121, 21);
            this.cb_FToutesPersonnes_Nom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trier sur :";
            // 
            // cb_FToutesPersonnes_TrierSur
            // 
            this.cb_FToutesPersonnes_TrierSur.FormattingEnabled = true;
            this.cb_FToutesPersonnes_TrierSur.Location = new System.Drawing.Point(400, 30);
            this.cb_FToutesPersonnes_TrierSur.Name = "cb_FToutesPersonnes_TrierSur";
            this.cb_FToutesPersonnes_TrierSur.Size = new System.Drawing.Size(121, 21);
            this.cb_FToutesPersonnes_TrierSur.TabIndex = 4;
            // 
            // dgv_FToutesPersonnes
            // 
            this.dgv_FToutesPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FToutesPersonnes.Location = new System.Drawing.Point(12, 57);
            this.dgv_FToutesPersonnes.Name = "dgv_FToutesPersonnes";
            this.dgv_FToutesPersonnes.Size = new System.Drawing.Size(581, 359);
            this.dgv_FToutesPersonnes.TabIndex = 5;
            // 
            // FToutesPersonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 464);
            this.Controls.Add(this.dgv_FToutesPersonnes);
            this.Controls.Add(this.cb_FToutesPersonnes_TrierSur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_FToutesPersonnes_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_FToutesPersonnes_Fermer);
            this.Name = "FToutesPersonnes";
            this.Text = "Toutes les Personnes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FToutesPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_FToutesPersonnes_Fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FToutesPersonnes_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FToutesPersonnes_TrierSur;
        private System.Windows.Forms.DataGridView dgv_FToutesPersonnes;
    }
}