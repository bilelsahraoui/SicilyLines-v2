namespace AdministrationSicilyLines.vues
{
    partial class ModifLiaisonView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifLiaisonView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBidLiaison = new System.Windows.Forms.TextBox();
            this.TBnomPortD = new System.Windows.Forms.TextBox();
            this.TBnomPortA = new System.Windows.Forms.TextBox();
            this.TBduree = new System.Windows.Forms.TextBox();
            this.BTNValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant Liaison :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port de Départ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port d\'Arrivée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée :";
            // 
            // TBidLiaison
            // 
            this.TBidLiaison.Enabled = false;
            this.TBidLiaison.Location = new System.Drawing.Point(151, 46);
            this.TBidLiaison.Name = "TBidLiaison";
            this.TBidLiaison.Size = new System.Drawing.Size(126, 22);
            this.TBidLiaison.TabIndex = 4;
            // 
            // TBnomPortD
            // 
            this.TBnomPortD.Enabled = false;
            this.TBnomPortD.Location = new System.Drawing.Point(151, 86);
            this.TBnomPortD.Name = "TBnomPortD";
            this.TBnomPortD.Size = new System.Drawing.Size(126, 22);
            this.TBnomPortD.TabIndex = 5;
            // 
            // TBnomPortA
            // 
            this.TBnomPortA.Enabled = false;
            this.TBnomPortA.Location = new System.Drawing.Point(151, 126);
            this.TBnomPortA.Name = "TBnomPortA";
            this.TBnomPortA.Size = new System.Drawing.Size(126, 22);
            this.TBnomPortA.TabIndex = 6;
            // 
            // TBduree
            // 
            this.TBduree.Location = new System.Drawing.Point(151, 165);
            this.TBduree.Name = "TBduree";
            this.TBduree.Size = new System.Drawing.Size(126, 22);
            this.TBduree.TabIndex = 7;
            // 
            // BTNValider
            // 
            this.BTNValider.Location = new System.Drawing.Point(295, 190);
            this.BTNValider.Name = "BTNValider";
            this.BTNValider.Size = new System.Drawing.Size(111, 41);
            this.BTNValider.TabIndex = 8;
            this.BTNValider.Text = "Valider";
            this.BTNValider.UseVisualStyleBackColor = true;
            this.BTNValider.Click += new System.EventHandler(this.BTNValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Format (hh:mm:ss)";
            // 
            // ModifLiaisonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNValider);
            this.Controls.Add(this.TBduree);
            this.Controls.Add(this.TBnomPortA);
            this.Controls.Add(this.TBnomPortD);
            this.Controls.Add(this.TBidLiaison);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 310);
            this.MinimumSize = new System.Drawing.Size(450, 310);
            this.Name = "ModifLiaisonView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modification Liaison";
            this.Load += new System.EventHandler(this.ModifLiaisonView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBidLiaison;
        private System.Windows.Forms.TextBox TBnomPortD;
        private System.Windows.Forms.TextBox TBnomPortA;
        private System.Windows.Forms.TextBox TBduree;
        private System.Windows.Forms.Button BTNValider;
        private System.Windows.Forms.Label label5;
    }
}