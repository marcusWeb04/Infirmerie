namespace InfirmerieGUI
{
    partial class Ajout_Medicament
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAjoutMedic = new System.Windows.Forms.Button();
            this.textBoxLib = new System.Windows.Forms.TextBox();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.buttonAjoutMedic);
            this.panel2.Controls.Add(this.textBoxLib);
            this.panel2.Controls.Add(this.labelBienvenue);
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Controls.Add(this.labelRecherche);
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 739);
            this.panel2.TabIndex = 23;
            // 
            // buttonAjoutMedic
            // 
            this.buttonAjoutMedic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonAjoutMedic.FlatAppearance.BorderSize = 0;
            this.buttonAjoutMedic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutMedic.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutMedic.ForeColor = System.Drawing.Color.White;
            this.buttonAjoutMedic.Location = new System.Drawing.Point(299, 374);
            this.buttonAjoutMedic.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAjoutMedic.Name = "buttonAjoutMedic";
            this.buttonAjoutMedic.Size = new System.Drawing.Size(289, 64);
            this.buttonAjoutMedic.TabIndex = 23;
            this.buttonAjoutMedic.Text = "Ajouter";
            this.buttonAjoutMedic.UseVisualStyleBackColor = false;
            this.buttonAjoutMedic.Click += new System.EventHandler(this.buttonAjoutMedic_Click);
            // 
            // textBoxLib
            // 
            this.textBoxLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLib.Location = new System.Drawing.Point(665, 374);
            this.textBoxLib.Multiline = true;
            this.textBoxLib.Name = "textBoxLib";
            this.textBoxLib.Size = new System.Drawing.Size(289, 64);
            this.textBoxLib.TabIndex = 22;
            this.textBoxLib.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(6, 58);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(1226, 58);
            this.labelBienvenue.TabIndex = 20;
            this.labelBienvenue.Text = "Ajout Médicament";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBienvenue.Click += new System.EventHandler(this.labelBienvenue_Click);
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
            // labelRecherche
            // 
            this.labelRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelRecherche.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecherche.ForeColor = System.Drawing.Color.Black;
            this.labelRecherche.Location = new System.Drawing.Point(665, 321);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(289, 50);
            this.labelRecherche.TabIndex = 16;
            this.labelRecherche.Text = "Libellé :";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRecherche.Click += new System.EventHandler(this.labelRecherche_Click);
            // 
            // Ajout_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.panel2);
            this.Name = "Ajout_Medicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout_Medicament";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.TextBox textBoxLib;
        private System.Windows.Forms.Button buttonAjoutMedic;
    }
}