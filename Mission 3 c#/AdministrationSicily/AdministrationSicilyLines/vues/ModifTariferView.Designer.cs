namespace AdministrationSicilyLines.vues
{
    partial class ModifTariferView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifTariferView));
            this.LBTarif = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBDate_Debut = new System.Windows.Forms.TextBox();
            this.TBDate_Fin = new System.Windows.Forms.TextBox();
            this.TBType = new System.Windows.Forms.TextBox();
            this.TBTarif = new System.Windows.Forms.TextBox();
            this.BTNModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBTarif
            // 
            this.LBTarif.FormattingEnabled = true;
            this.LBTarif.ItemHeight = 16;
            this.LBTarif.Location = new System.Drawing.Point(21, 23);
            this.LBTarif.Name = "LBTarif";
            this.LBTarif.Size = new System.Drawing.Size(629, 148);
            this.LBTarif.TabIndex = 0;
            this.LBTarif.SelectedIndexChanged += new System.EventHandler(this.LBTarif_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarif";
            // 
            // TBDate_Debut
            // 
            this.TBDate_Debut.Enabled = false;
            this.TBDate_Debut.Location = new System.Drawing.Point(21, 233);
            this.TBDate_Debut.Name = "TBDate_Debut";
            this.TBDate_Debut.Size = new System.Drawing.Size(100, 22);
            this.TBDate_Debut.TabIndex = 5;
            // 
            // TBDate_Fin
            // 
            this.TBDate_Fin.Enabled = false;
            this.TBDate_Fin.Location = new System.Drawing.Point(148, 233);
            this.TBDate_Fin.Name = "TBDate_Fin";
            this.TBDate_Fin.Size = new System.Drawing.Size(100, 22);
            this.TBDate_Fin.TabIndex = 6;
            // 
            // TBType
            // 
            this.TBType.Enabled = false;
            this.TBType.Location = new System.Drawing.Point(269, 233);
            this.TBType.Name = "TBType";
            this.TBType.Size = new System.Drawing.Size(100, 22);
            this.TBType.TabIndex = 7;
            // 
            // TBTarif
            // 
            this.TBTarif.Location = new System.Drawing.Point(395, 233);
            this.TBTarif.Name = "TBTarif";
            this.TBTarif.Size = new System.Drawing.Size(100, 22);
            this.TBTarif.TabIndex = 8;
            // 
            // BTNModif
            // 
            this.BTNModif.Location = new System.Drawing.Point(541, 222);
            this.BTNModif.Name = "BTNModif";
            this.BTNModif.Size = new System.Drawing.Size(76, 44);
            this.BTNModif.TabIndex = 9;
            this.BTNModif.Text = "Modifier";
            this.BTNModif.UseVisualStyleBackColor = true;
            this.BTNModif.Click += new System.EventHandler(this.BTNModif_Click);
            // 
            // ModifTariferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 288);
            this.Controls.Add(this.BTNModif);
            this.Controls.Add(this.TBTarif);
            this.Controls.Add(this.TBType);
            this.Controls.Add(this.TBDate_Fin);
            this.Controls.Add(this.TBDate_Debut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBTarif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 335);
            this.MinimumSize = new System.Drawing.Size(680, 335);
            this.Name = "ModifTariferView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage Tarif";
            this.Load += new System.EventHandler(this.ModifTariferView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBTarif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBDate_Debut;
        private System.Windows.Forms.TextBox TBDate_Fin;
        private System.Windows.Forms.TextBox TBType;
        private System.Windows.Forms.TextBox TBTarif;
        private System.Windows.Forms.Button BTNModif;
    }
}