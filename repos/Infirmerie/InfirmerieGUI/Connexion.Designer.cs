namespace InfirmerieGUI
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMotdepasse = new System.Windows.Forms.TextBox();
            this.labelMotdepasse = new System.Windows.Forms.Label();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.buttonSeconnecter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxMotdepasse
            // 
            this.textBoxMotdepasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMotdepasse.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxMotdepasse.Location = new System.Drawing.Point(550, 500);
            this.textBoxMotdepasse.MaxLength = 32;
            this.textBoxMotdepasse.Multiline = true;
            this.textBoxMotdepasse.Name = "textBoxMotdepasse";
            this.textBoxMotdepasse.Size = new System.Drawing.Size(323, 59);
            this.textBoxMotdepasse.TabIndex = 15;
            this.textBoxMotdepasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMotdepasse.WordWrap = false;
            // 
            // labelMotdepasse
            // 
            this.labelMotdepasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelMotdepasse.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotdepasse.Location = new System.Drawing.Point(550, 446);
            this.labelMotdepasse.Name = "labelMotdepasse";
            this.labelMotdepasse.Size = new System.Drawing.Size(323, 44);
            this.labelMotdepasse.TabIndex = 14;
            this.labelMotdepasse.Text = "Mot de passe :";
            this.labelMotdepasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelIdentifiant.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(550, 302);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(323, 44);
            this.labelIdentifiant.TabIndex = 13;
            this.labelIdentifiant.Text = "Identifiant :";
            this.labelIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdentifiant.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxIdentifiant.Location = new System.Drawing.Point(550, 356);
            this.textBoxIdentifiant.MaxLength = 32;
            this.textBoxIdentifiant.Multiline = true;
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(323, 59);
            this.textBoxIdentifiant.TabIndex = 12;
            this.textBoxIdentifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdentifiant.WordWrap = false;
            // 
            // labelConnexion
            // 
            this.labelConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelConnexion.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(550, 138);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(323, 116);
            this.labelConnexion.TabIndex = 11;
            this.labelConnexion.Text = "Connexion";
            this.labelConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSeconnecter
            // 
            this.buttonSeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonSeconnecter.FlatAppearance.BorderSize = 0;
            this.buttonSeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeconnecter.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeconnecter.ForeColor = System.Drawing.Color.White;
            this.buttonSeconnecter.Location = new System.Drawing.Point(550, 656);
            this.buttonSeconnecter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSeconnecter.Name = "buttonSeconnecter";
            this.buttonSeconnecter.Size = new System.Drawing.Size(323, 80);
            this.buttonSeconnecter.TabIndex = 9;
            this.buttonSeconnecter.Text = "Se connecter";
            this.buttonSeconnecter.UseVisualStyleBackColor = false;
            this.buttonSeconnecter.Click += new System.EventHandler(this.buttonSeconnecter_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(427, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 730);
            this.panel1.TabIndex = 10;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.textBoxMotdepasse);
            this.Controls.Add(this.labelMotdepasse);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.labelConnexion);
            this.Controls.Add(this.buttonSeconnecter);
            this.Controls.Add(this.panel1);
            this.Name = "Connexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMotdepasse;
        private System.Windows.Forms.Label labelMotdepasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Button buttonSeconnecter;
        private System.Windows.Forms.Panel panel1;
    }
}

