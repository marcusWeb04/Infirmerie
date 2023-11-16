namespace InfirmerieGUI
{
    partial class Ajout_Eleve
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
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxClasse = new System.Windows.Forms.TextBox();
            this.textBoxDateDeNaissance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxTelEleve = new System.Windows.Forms.TextBox();
            this.textBoxComSante = new System.Windows.Forms.TextBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonDummyAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxTiersTemps = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelParent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(526, 150);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(388, 58);
            this.labelBienvenue.TabIndex = 9;
            this.labelBienvenue.Text = "Ajout d\'élève";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBienvenue.Click += new System.EventHandler(this.labelBienvenue_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrenom.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxPrenom.Location = new System.Drawing.Point(455, 361);
            this.textBoxPrenom.MaxLength = 32;
            this.textBoxPrenom.Multiline = true;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(240, 59);
            this.textBoxPrenom.TabIndex = 14;
            this.textBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrenom.WordWrap = false;
            // 
            // textBoxClasse
            // 
            this.textBoxClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClasse.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxClasse.Location = new System.Drawing.Point(749, 361);
            this.textBoxClasse.MaxLength = 32;
            this.textBoxClasse.Multiline = true;
            this.textBoxClasse.Name = "textBoxClasse";
            this.textBoxClasse.Size = new System.Drawing.Size(240, 59);
            this.textBoxClasse.TabIndex = 15;
            this.textBoxClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxClasse.WordWrap = false;
            // 
            // textBoxDateDeNaissance
            // 
            this.textBoxDateDeNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateDeNaissance.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxDateDeNaissance.Location = new System.Drawing.Point(1038, 361);
            this.textBoxDateDeNaissance.MaxLength = 32;
            this.textBoxDateDeNaissance.Multiline = true;
            this.textBoxDateDeNaissance.Name = "textBoxDateDeNaissance";
            this.textBoxDateDeNaissance.Size = new System.Drawing.Size(240, 59);
            this.textBoxDateDeNaissance.TabIndex = 16;
            this.textBoxDateDeNaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateDeNaissance.WordWrap = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom* :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNom.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxNom.Location = new System.Drawing.Point(162, 361);
            this.textBoxNom.MaxLength = 32;
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(240, 59);
            this.textBoxNom.TabIndex = 13;
            this.textBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNom.WordWrap = false;
            // 
            // textBoxTelEleve
            // 
            this.textBoxTelEleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelEleve.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxTelEleve.Location = new System.Drawing.Point(162, 491);
            this.textBoxTelEleve.MaxLength = 32;
            this.textBoxTelEleve.Multiline = true;
            this.textBoxTelEleve.Name = "textBoxTelEleve";
            this.textBoxTelEleve.Size = new System.Drawing.Size(240, 59);
            this.textBoxTelEleve.TabIndex = 21;
            this.textBoxTelEleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTelEleve.WordWrap = false;
            // 
            // textBoxComSante
            // 
            this.textBoxComSante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComSante.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxComSante.Location = new System.Drawing.Point(749, 491);
            this.textBoxComSante.MaxLength = 32;
            this.textBoxComSante.Multiline = true;
            this.textBoxComSante.Name = "textBoxComSante";
            this.textBoxComSante.Size = new System.Drawing.Size(529, 158);
            this.textBoxComSante.TabIndex = 23;
            this.textBoxComSante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxComSante.WordWrap = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.Location = new System.Drawing.Point(94, 728);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(310, 80);
            this.buttonRetour.TabIndex = 29;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonDummyAdd
            // 
            this.buttonDummyAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.buttonDummyAdd.FlatAppearance.BorderSize = 0;
            this.buttonDummyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDummyAdd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDummyAdd.ForeColor = System.Drawing.Color.White;
            this.buttonDummyAdd.Location = new System.Drawing.Point(1018, 727);
            this.buttonDummyAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDummyAdd.Name = "buttonDummyAdd";
            this.buttonDummyAdd.Size = new System.Drawing.Size(310, 80);
            this.buttonDummyAdd.TabIndex = 30;
            this.buttonDummyAdd.Text = "Ajouter";
            this.buttonDummyAdd.UseVisualStyleBackColor = false;
            this.buttonDummyAdd.Click += new System.EventHandler(this.buttonDummyAdd_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(455, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prénom* :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label8.Font = new System.Drawing.Font("Arial", 15F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(455, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 34);
            this.label8.TabIndex = 41;
            this.label8.Text = "*champ obligatoire";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.Font = new System.Drawing.Font("Arial", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(162, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 31);
            this.label7.TabIndex = 38;
            this.label7.Text = "Téléphone élève* :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxTiersTemps
            // 
            this.checkBoxTiersTemps.AutoSize = true;
            this.checkBoxTiersTemps.Location = new System.Drawing.Point(384, 615);
            this.checkBoxTiersTemps.Name = "checkBoxTiersTemps";
            this.checkBoxTiersTemps.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTiersTemps.TabIndex = 40;
            this.checkBoxTiersTemps.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label6.Font = new System.Drawing.Font("Arial", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(455, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Téléphone parent* :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tier
            // 
            this.tier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tier.Font = new System.Drawing.Font("Arial", 15F);
            this.tier.ForeColor = System.Drawing.Color.Black;
            this.tier.Location = new System.Drawing.Point(162, 589);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(240, 58);
            this.tier.TabIndex = 39;
            this.tier.Text = "Tiers temps :";
            this.tier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(749, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Classe* :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(749, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(529, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Commentaire santé :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1038, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date de naissance* :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTelParent
            // 
            this.textBoxTelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelParent.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxTelParent.Location = new System.Drawing.Point(455, 491);
            this.textBoxTelParent.MaxLength = 32;
            this.textBoxTelParent.Multiline = true;
            this.textBoxTelParent.Name = "textBoxTelParent";
            this.textBoxTelParent.Size = new System.Drawing.Size(240, 59);
            this.textBoxTelParent.TabIndex = 43;
            this.textBoxTelParent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTelParent.WordWrap = false;
            // 
            // Ajout_Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.textBoxTelParent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxTiersTemps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDummyAdd);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.textBoxComSante);
            this.Controls.Add(this.textBoxTelEleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDateDeNaissance);
            this.Controls.Add(this.textBoxClasse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelBienvenue);
            this.Name = "Ajout_Eleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ajout_Eleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxClasse;
        private System.Windows.Forms.TextBox textBoxDateDeNaissance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxTelEleve;
        private System.Windows.Forms.TextBox textBoxComSante;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonDummyAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxTiersTemps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelParent;
    }
}