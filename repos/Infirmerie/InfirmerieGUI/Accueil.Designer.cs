namespace InfirmerieGUI
{
    partial class Accueil
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
            this.buttonVisites = new System.Windows.Forms.Button();
            this.buttonEleves = new System.Windows.Forms.Button();
            this.buttonMedicaments = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStatistiques = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVisites
            // 
            this.buttonVisites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonVisites.FlatAppearance.BorderSize = 0;
            this.buttonVisites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisites.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisites.ForeColor = System.Drawing.Color.White;
            this.buttonVisites.Location = new System.Drawing.Point(735, 330);
            this.buttonVisites.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVisites.Name = "buttonVisites";
            this.buttonVisites.Size = new System.Drawing.Size(323, 80);
            this.buttonVisites.TabIndex = 12;
            this.buttonVisites.Text = "Visites";
            this.buttonVisites.UseVisualStyleBackColor = false;
            this.buttonVisites.Click += new System.EventHandler(this.buttonVisites_Click_1);
            // 
            // buttonEleves
            // 
            this.buttonEleves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonEleves.FlatAppearance.BorderSize = 0;
            this.buttonEleves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEleves.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEleves.ForeColor = System.Drawing.Color.White;
            this.buttonEleves.Location = new System.Drawing.Point(229, 330);
            this.buttonEleves.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEleves.Name = "buttonEleves";
            this.buttonEleves.Size = new System.Drawing.Size(323, 80);
            this.buttonEleves.TabIndex = 11;
            this.buttonEleves.Text = "Élèves";
            this.buttonEleves.UseVisualStyleBackColor = false;
            this.buttonEleves.Click += new System.EventHandler(this.buttonEleves_Click);
            // 
            // buttonMedicaments
            // 
            this.buttonMedicaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonMedicaments.FlatAppearance.BorderSize = 0;
            this.buttonMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicaments.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicaments.ForeColor = System.Drawing.Color.White;
            this.buttonMedicaments.Location = new System.Drawing.Point(229, 475);
            this.buttonMedicaments.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMedicaments.Name = "buttonMedicaments";
            this.buttonMedicaments.Size = new System.Drawing.Size(323, 80);
            this.buttonMedicaments.TabIndex = 10;
            this.buttonMedicaments.Text = "Médicaments";
            this.buttonMedicaments.UseVisualStyleBackColor = false;
            this.buttonMedicaments.Click += new System.EventHandler(this.buttonMedicaments_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.ForeColor = System.Drawing.Color.White;
            this.buttonDeconnexion.Location = new System.Drawing.Point(483, 616);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(323, 80);
            this.buttonDeconnexion.TabIndex = 9;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(94, 86);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(1235, 58);
            this.labelBienvenue.TabIndex = 8;
            this.labelBienvenue.Text = "Bienvenue, <utilisateur>!";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(94, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 739);
            this.panel1.TabIndex = 13;
            // 
            // buttonStatistiques
            // 
            this.buttonStatistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonStatistiques.FlatAppearance.BorderSize = 0;
            this.buttonStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistiques.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistiques.ForeColor = System.Drawing.Color.White;
            this.buttonStatistiques.Location = new System.Drawing.Point(735, 475);
            this.buttonStatistiques.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStatistiques.Name = "buttonStatistiques";
            this.buttonStatistiques.Size = new System.Drawing.Size(323, 80);
            this.buttonStatistiques.TabIndex = 14;
            this.buttonStatistiques.Text = "Statistiques";
            this.buttonStatistiques.UseVisualStyleBackColor = false;
            this.buttonStatistiques.Click += new System.EventHandler(this.buttonStatistiques_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonStatistiques);
            this.Controls.Add(this.buttonVisites);
            this.Controls.Add(this.buttonEleves);
            this.Controls.Add(this.buttonMedicaments);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.panel1);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisites;
        private System.Windows.Forms.Button buttonEleves;
        private System.Windows.Forms.Button buttonMedicaments;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStatistiques;
    }
}