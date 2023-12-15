namespace InfirmerieGUI
{
    partial class Statistique
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonConsulter = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelStatistiques = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // buttonConsulter
            // 
            this.buttonConsulter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonConsulter.FlatAppearance.BorderSize = 0;
            this.buttonConsulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsulter.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsulter.ForeColor = System.Drawing.Color.White;
            this.buttonConsulter.Location = new System.Drawing.Point(420, 443);
            this.buttonConsulter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConsulter.Name = "buttonConsulter";
            this.buttonConsulter.Size = new System.Drawing.Size(262, 64);
            this.buttonConsulter.TabIndex = 20;
            this.buttonConsulter.Text = "Consulter";
            this.buttonConsulter.UseVisualStyleBackColor = false;
            this.buttonConsulter.Click += new System.EventHandler(this.buttonConsulter_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxRecherche.Location = new System.Drawing.Point(721, 443);
            this.textBoxRecherche.Multiline = true;
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(262, 64);
            this.textBoxRecherche.TabIndex = 21;
            // 
            // labelAnnee
            // 
            this.labelAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAnnee.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.ForeColor = System.Drawing.Color.Black;
            this.labelAnnee.Location = new System.Drawing.Point(627, 321);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(262, 50);
            this.labelAnnee.TabIndex = 16;
            this.labelAnnee.Text = "Année :";
            this.labelAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatistiques
            // 
            this.labelStatistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelStatistiques.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatistiques.ForeColor = System.Drawing.Color.Black;
            this.labelStatistiques.Location = new System.Drawing.Point(97, 115);
            this.labelStatistiques.Name = "labelStatistiques";
            this.labelStatistiques.Size = new System.Drawing.Size(1229, 58);
            this.labelStatistiques.TabIndex = 19;
            this.labelStatistiques.Text = "Statistiques";
            this.labelStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Controls.Add(this.labelAnnee);
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 739);
            this.panel2.TabIndex = 22;
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.buttonConsulter);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.labelStatistiques);
            this.Controls.Add(this.panel2);
            this.Name = "Statistique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistique";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonConsulter;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.Label labelStatistiques;
        private System.Windows.Forms.Panel panel2;
    }
}