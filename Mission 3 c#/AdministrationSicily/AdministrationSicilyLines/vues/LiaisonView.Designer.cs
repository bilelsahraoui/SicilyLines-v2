namespace AdministrationSicilyLines.vues
{
    partial class LiaisonView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiaisonView));
            this.BTNModif = new System.Windows.Forms.Button();
            this.BTNSuppr = new System.Windows.Forms.Button();
            this.LBLiaison = new System.Windows.Forms.ListBox();
            this.BTNAffichTarif = new System.Windows.Forms.Button();
            this.CBportD = new System.Windows.Forms.ComboBox();
            this.CBportA = new System.Windows.Forms.ComboBox();
            this.TBduree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNAjout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNModif
            // 
            this.BTNModif.Location = new System.Drawing.Point(649, 41);
            this.BTNModif.Name = "BTNModif";
            this.BTNModif.Size = new System.Drawing.Size(109, 39);
            this.BTNModif.TabIndex = 1;
            this.BTNModif.Text = "Modifier";
            this.BTNModif.UseVisualStyleBackColor = true;
            this.BTNModif.Click += new System.EventHandler(this.BTNModif_Click);
            // 
            // BTNSuppr
            // 
            this.BTNSuppr.Location = new System.Drawing.Point(649, 86);
            this.BTNSuppr.Name = "BTNSuppr";
            this.BTNSuppr.Size = new System.Drawing.Size(109, 39);
            this.BTNSuppr.TabIndex = 2;
            this.BTNSuppr.Text = "Supprimer";
            this.BTNSuppr.UseVisualStyleBackColor = true;
            this.BTNSuppr.Click += new System.EventHandler(this.BTNSuppr_Click);
            // 
            // LBLiaison
            // 
            this.LBLiaison.FormattingEnabled = true;
            this.LBLiaison.ItemHeight = 16;
            this.LBLiaison.Location = new System.Drawing.Point(12, 24);
            this.LBLiaison.Name = "LBLiaison";
            this.LBLiaison.Size = new System.Drawing.Size(617, 260);
            this.LBLiaison.TabIndex = 3;
            // 
            // BTNAffichTarif
            // 
            this.BTNAffichTarif.Location = new System.Drawing.Point(649, 131);
            this.BTNAffichTarif.Name = "BTNAffichTarif";
            this.BTNAffichTarif.Size = new System.Drawing.Size(109, 39);
            this.BTNAffichTarif.TabIndex = 4;
            this.BTNAffichTarif.Text = "Afficher Tarif";
            this.BTNAffichTarif.UseVisualStyleBackColor = true;
            this.BTNAffichTarif.Click += new System.EventHandler(this.BTNAffichTarif_Click);
            // 
            // CBportD
            // 
            this.CBportD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBportD.FormattingEnabled = true;
            this.CBportD.Location = new System.Drawing.Point(12, 342);
            this.CBportD.Name = "CBportD";
            this.CBportD.Size = new System.Drawing.Size(121, 24);
            this.CBportD.TabIndex = 5;
            this.CBportD.SelectedIndexChanged += new System.EventHandler(this.CBportD_SelectedIndexChanged);
            // 
            // CBportA
            // 
            this.CBportA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBportA.FormattingEnabled = true;
            this.CBportA.Location = new System.Drawing.Point(165, 342);
            this.CBportA.Name = "CBportA";
            this.CBportA.Size = new System.Drawing.Size(121, 24);
            this.CBportA.TabIndex = 6;
            // 
            // TBduree
            // 
            this.TBduree.Location = new System.Drawing.Point(314, 342);
            this.TBduree.Name = "TBduree";
            this.TBduree.Size = new System.Drawing.Size(100, 22);
            this.TBduree.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port de Départ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port d\'Arrivée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Durée";
            // 
            // BTNAjout
            // 
            this.BTNAjout.Location = new System.Drawing.Point(466, 334);
            this.BTNAjout.Name = "BTNAjout";
            this.BTNAjout.Size = new System.Drawing.Size(83, 30);
            this.BTNAjout.TabIndex = 11;
            this.BTNAjout.Text = "Ajouter";
            this.BTNAjout.UseVisualStyleBackColor = true;
            this.BTNAjout.Click += new System.EventHandler(this.BTNAjout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Format (hh:mm:ss)";
            // 
            // LiaisonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNAjout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBduree);
            this.Controls.Add(this.CBportA);
            this.Controls.Add(this.CBportD);
            this.Controls.Add(this.BTNAffichTarif);
            this.Controls.Add(this.LBLiaison);
            this.Controls.Add(this.BTNSuppr);
            this.Controls.Add(this.BTNModif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 460);
            this.MinimumSize = new System.Drawing.Size(800, 460);
            this.Name = "LiaisonView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration Liaison";
            this.Load += new System.EventHandler(this.LiaisonView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNModif;
        private System.Windows.Forms.Button BTNSuppr;
        private System.Windows.Forms.ListBox LBLiaison;
        private System.Windows.Forms.Button BTNAffichTarif;
        private System.Windows.Forms.ComboBox CBportD;
        private System.Windows.Forms.ComboBox CBportA;
        private System.Windows.Forms.TextBox TBduree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNAjout;
        private System.Windows.Forms.Label label5;
    }
}