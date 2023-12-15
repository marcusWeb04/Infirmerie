namespace InfirmerieGUI
{
    partial class StatsGraphe
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelStatistiques = new System.Windows.Forms.Label();
            this.labelStatseleve = new System.Windows.Forms.Label();
            this.labelStatsvisite = new System.Windows.Forms.Label();
            this.labelStatsmedic = new System.Windows.Forms.Label();
            this.labelStatsvisiteeleve = new System.Windows.Forms.Label();
            this.labelStatstempsvisite = new System.Windows.Forms.Label();
            this.labelStatsmedicvisite = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelAnnee);
            this.panel2.Controls.Add(this.labelStatstempsvisite);
            this.panel2.Controls.Add(this.labelStatsmedicvisite);
            this.panel2.Controls.Add(this.labelStatsmedic);
            this.panel2.Controls.Add(this.labelStatsvisiteeleve);
            this.panel2.Controls.Add(this.labelStatsvisite);
            this.panel2.Controls.Add(this.labelStatseleve);
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 739);
            this.panel2.TabIndex = 26;
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.Location = new System.Drawing.Point(0, 659);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(323, 80);
            this.buttonRetour.TabIndex = 13;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelStatistiques
            // 
            this.labelStatistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStatistiques.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatistiques.ForeColor = System.Drawing.Color.Black;
            this.labelStatistiques.Location = new System.Drawing.Point(97, 115);
            this.labelStatistiques.Name = "labelStatistiques";
            this.labelStatistiques.Size = new System.Drawing.Size(1229, 58);
            this.labelStatistiques.TabIndex = 23;
            this.labelStatistiques.Text = "Statistiques";
            this.labelStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatseleve
            // 
            this.labelStatseleve.BackColor = System.Drawing.Color.Transparent;
            this.labelStatseleve.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatseleve.ForeColor = System.Drawing.Color.Black;
            this.labelStatseleve.Location = new System.Drawing.Point(7, 270);
            this.labelStatseleve.Name = "labelStatseleve";
            this.labelStatseleve.Size = new System.Drawing.Size(320, 40);
            this.labelStatseleve.TabIndex = 27;
            this.labelStatseleve.Text = "Nombre d\'élèves : (nb)";
            this.labelStatseleve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatsvisite
            // 
            this.labelStatsvisite.BackColor = System.Drawing.Color.Transparent;
            this.labelStatsvisite.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatsvisite.ForeColor = System.Drawing.Color.Black;
            this.labelStatsvisite.Location = new System.Drawing.Point(5, 310);
            this.labelStatsvisite.Name = "labelStatsvisite";
            this.labelStatsvisite.Size = new System.Drawing.Size(338, 40);
            this.labelStatsvisite.TabIndex = 28;
            this.labelStatsvisite.Text = "Nombre de visites : (nb)";
            this.labelStatsvisite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatsmedic
            // 
            this.labelStatsmedic.BackColor = System.Drawing.Color.Transparent;
            this.labelStatsmedic.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatsmedic.ForeColor = System.Drawing.Color.Black;
            this.labelStatsmedic.Location = new System.Drawing.Point(3, 390);
            this.labelStatsmedic.Name = "labelStatsmedic";
            this.labelStatsmedic.Size = new System.Drawing.Size(509, 40);
            this.labelStatsmedic.TabIndex = 30;
            this.labelStatsmedic.Text = "Nombre de médicament : (nb)";
            this.labelStatsmedic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatsvisiteeleve
            // 
            this.labelStatsvisiteeleve.BackColor = System.Drawing.Color.Transparent;
            this.labelStatsvisiteeleve.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatsvisiteeleve.ForeColor = System.Drawing.Color.Black;
            this.labelStatsvisiteeleve.Location = new System.Drawing.Point(3, 350);
            this.labelStatsvisiteeleve.Name = "labelStatsvisiteeleve";
            this.labelStatsvisiteeleve.Size = new System.Drawing.Size(467, 40);
            this.labelStatsvisiteeleve.TabIndex = 29;
            this.labelStatsvisiteeleve.Text = "Nombre de visites par élève : (nb)";
            this.labelStatsvisiteeleve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatstempsvisite
            // 
            this.labelStatstempsvisite.BackColor = System.Drawing.Color.Transparent;
            this.labelStatstempsvisite.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatstempsvisite.ForeColor = System.Drawing.Color.Black;
            this.labelStatstempsvisite.Location = new System.Drawing.Point(3, 470);
            this.labelStatstempsvisite.Name = "labelStatstempsvisite";
            this.labelStatstempsvisite.Size = new System.Drawing.Size(743, 40);
            this.labelStatstempsvisite.TabIndex = 32;
            this.labelStatstempsvisite.Text = "Durée moyenne d\'une visite : (nb)min";
            this.labelStatstempsvisite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatsmedicvisite
            // 
            this.labelStatsmedicvisite.BackColor = System.Drawing.Color.Transparent;
            this.labelStatsmedicvisite.Font = new System.Drawing.Font("Arial", 16F);
            this.labelStatsmedicvisite.ForeColor = System.Drawing.Color.Black;
            this.labelStatsmedicvisite.Location = new System.Drawing.Point(3, 430);
            this.labelStatsmedicvisite.Name = "labelStatsmedicvisite";
            this.labelStatsmedicvisite.Size = new System.Drawing.Size(662, 40);
            this.labelStatsmedicvisite.TabIndex = 31;
            this.labelStatsmedicvisite.Text = "Nombre de médicament par visite : (nb)";
            this.labelStatsmedicvisite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAnnee
            // 
            this.labelAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAnnee.Font = new System.Drawing.Font("Arial", 24F);
            this.labelAnnee.ForeColor = System.Drawing.Color.Black;
            this.labelAnnee.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelAnnee.Location = new System.Drawing.Point(3, 216);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(575, 58);
            this.labelAnnee.TabIndex = 27;
            this.labelAnnee.Text = "Statistiques de l\'année (nb)";
            this.labelAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAnnee.Click += new System.EventHandler(this.label7_Click);
            // 
            // StatsGraphe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.labelStatistiques);
            this.Controls.Add(this.panel2);
            this.Name = "StatsGraphe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatsGraphe";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelStatistiques;
        private System.Windows.Forms.Label labelStatsmedic;
        private System.Windows.Forms.Label labelStatsvisiteeleve;
        private System.Windows.Forms.Label labelStatsvisite;
        private System.Windows.Forms.Label labelStatseleve;
        private System.Windows.Forms.Label labelStatstempsvisite;
        private System.Windows.Forms.Label labelStatsmedicvisite;
        private System.Windows.Forms.Label labelAnnee;
    }
}