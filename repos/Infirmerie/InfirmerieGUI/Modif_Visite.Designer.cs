namespace InfirmerieGUI
{
    partial class Modif_Visite
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
            this.buttonDummyAdd = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.checkBoxParentsPrev = new System.Windows.Forms.CheckBox();
            this.tier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQteMedic = new System.Windows.Forms.TextBox();
            this.comboBoxMedic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComm = new System.Windows.Forms.TextBox();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSuite = new System.Windows.Forms.ComboBox();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeureArrivee = new System.Windows.Forms.TextBox();
            this.textBoxHeureDepart = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxClasse = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDummyAdd
            // 
            this.buttonDummyAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.buttonDummyAdd.FlatAppearance.BorderSize = 0;
            this.buttonDummyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDummyAdd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDummyAdd.ForeColor = System.Drawing.Color.White;
            this.buttonDummyAdd.Location = new System.Drawing.Point(1018, 686);
            this.buttonDummyAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDummyAdd.Name = "buttonDummyAdd";
            this.buttonDummyAdd.Size = new System.Drawing.Size(310, 80);
            this.buttonDummyAdd.TabIndex = 81;
            this.buttonDummyAdd.Text = "Ajouter";
            this.buttonDummyAdd.UseVisualStyleBackColor = false;
            this.buttonDummyAdd.Click += new System.EventHandler(this.buttonDummyAdd_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.Location = new System.Drawing.Point(94, 687);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(310, 80);
            this.buttonRetour.TabIndex = 80;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click_1);
            // 
            // checkBoxParentsPrev
            // 
            this.checkBoxParentsPrev.AutoSize = true;
            this.checkBoxParentsPrev.Location = new System.Drawing.Point(1167, 619);
            this.checkBoxParentsPrev.Name = "checkBoxParentsPrev";
            this.checkBoxParentsPrev.Size = new System.Drawing.Size(18, 17);
            this.checkBoxParentsPrev.TabIndex = 79;
            this.checkBoxParentsPrev.UseVisualStyleBackColor = true;
            // 
            // tier
            // 
            this.tier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tier.Font = new System.Drawing.Font("Arial", 15F);
            this.tier.ForeColor = System.Drawing.Color.Black;
            this.tier.Location = new System.Drawing.Point(895, 593);
            this.tier.Name = "tier";
            this.tier.Size = new System.Drawing.Size(240, 58);
            this.tier.TabIndex = 78;
            this.tier.Text = "Parents prévenus :";
            this.tier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.Font = new System.Drawing.Font("Arial", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(895, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 25);
            this.label7.TabIndex = 77;
            this.label7.Text = "Médicament/Qte :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQteMedic
            // 
            this.textBoxQteMedic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQteMedic.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxQteMedic.Location = new System.Drawing.Point(1218, 497);
            this.textBoxQteMedic.MaxLength = 32;
            this.textBoxQteMedic.Multiline = true;
            this.textBoxQteMedic.Name = "textBoxQteMedic";
            this.textBoxQteMedic.Size = new System.Drawing.Size(59, 59);
            this.textBoxQteMedic.TabIndex = 76;
            this.textBoxQteMedic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQteMedic.WordWrap = false;
            // 
            // comboBoxMedic
            // 
            this.comboBoxMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxMedic.FormattingEnabled = true;
            this.comboBoxMedic.Location = new System.Drawing.Point(900, 497);
            this.comboBoxMedic.Name = "comboBoxMedic";
            this.comboBoxMedic.Size = new System.Drawing.Size(300, 39);
            this.comboBoxMedic.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label6.Font = new System.Drawing.Font("Arial", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(544, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "Commentaire :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(163, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Motif* :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxComm
            // 
            this.textBoxComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComm.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxComm.Location = new System.Drawing.Point(544, 496);
            this.textBoxComm.MaxLength = 32;
            this.textBoxComm.Multiline = true;
            this.textBoxComm.Name = "textBoxComm";
            this.textBoxComm.Size = new System.Drawing.Size(320, 158);
            this.textBoxComm.TabIndex = 72;
            this.textBoxComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxComm.WordWrap = false;
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMotif.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxMotif.Location = new System.Drawing.Point(163, 493);
            this.textBoxMotif.MaxLength = 32;
            this.textBoxMotif.Multiline = true;
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(320, 158);
            this.textBoxMotif.TabIndex = 71;
            this.textBoxMotif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMotif.WordWrap = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label4.Font = new System.Drawing.Font("Arial", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1039, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Suite :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSuite
            // 
            this.comboBoxSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxSuite.FormattingEnabled = true;
            this.comboBoxSuite.Items.AddRange(new object[] {
            "Aucune",
            "Domicile",
            "Hôpital"});
            this.comboBoxSuite.Location = new System.Drawing.Point(1039, 381);
            this.comboBoxSuite.Name = "comboBoxSuite";
            this.comboBoxSuite.Size = new System.Drawing.Size(235, 39);
            this.comboBoxSuite.TabIndex = 69;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(526, 109);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(388, 58);
            this.labelBienvenue.TabIndex = 68;
            this.labelBienvenue.Text = "Modif Visite";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(747, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Heure départ* :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(456, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Heure arrivée* :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Date* :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHeureArrivee
            // 
            this.textBoxHeureArrivee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeureArrivee.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxHeureArrivee.Location = new System.Drawing.Point(747, 382);
            this.textBoxHeureArrivee.MaxLength = 32;
            this.textBoxHeureArrivee.Multiline = true;
            this.textBoxHeureArrivee.Name = "textBoxHeureArrivee";
            this.textBoxHeureArrivee.Size = new System.Drawing.Size(240, 59);
            this.textBoxHeureArrivee.TabIndex = 64;
            this.textBoxHeureArrivee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeureArrivee.WordWrap = false;
            // 
            // textBoxHeureDepart
            // 
            this.textBoxHeureDepart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeureDepart.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxHeureDepart.Location = new System.Drawing.Point(456, 382);
            this.textBoxHeureDepart.MaxLength = 32;
            this.textBoxHeureDepart.Multiline = true;
            this.textBoxHeureDepart.Name = "textBoxHeureDepart";
            this.textBoxHeureDepart.Size = new System.Drawing.Size(240, 59);
            this.textBoxHeureDepart.TabIndex = 63;
            this.textBoxHeureDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeureDepart.WordWrap = false;
            // 
            // textBoxDate
            // 
            this.textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDate.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxDate.Location = new System.Drawing.Point(163, 382);
            this.textBoxDate.MaxLength = 32;
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(240, 59);
            this.textBoxDate.TabIndex = 62;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDate.WordWrap = false;
            // 
            // textBoxAge
            // 
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAge.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxAge.Location = new System.Drawing.Point(1039, 268);
            this.textBoxAge.MaxLength = 32;
            this.textBoxAge.Multiline = true;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(240, 59);
            this.textBoxAge.TabIndex = 61;
            this.textBoxAge.Text = "Âge";
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAge.WordWrap = false;
            // 
            // textBoxClasse
            // 
            this.textBoxClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClasse.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxClasse.Location = new System.Drawing.Point(747, 268);
            this.textBoxClasse.MaxLength = 32;
            this.textBoxClasse.Multiline = true;
            this.textBoxClasse.Name = "textBoxClasse";
            this.textBoxClasse.ReadOnly = true;
            this.textBoxClasse.Size = new System.Drawing.Size(240, 59);
            this.textBoxClasse.TabIndex = 60;
            this.textBoxClasse.Text = "Classe";
            this.textBoxClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxClasse.WordWrap = false;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrenom.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxPrenom.Location = new System.Drawing.Point(456, 268);
            this.textBoxPrenom.MaxLength = 32;
            this.textBoxPrenom.Multiline = true;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.ReadOnly = true;
            this.textBoxPrenom.Size = new System.Drawing.Size(240, 59);
            this.textBoxPrenom.TabIndex = 59;
            this.textBoxPrenom.Text = "Prénom";
            this.textBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrenom.WordWrap = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNom.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxNom.Location = new System.Drawing.Point(163, 268);
            this.textBoxNom.MaxLength = 32;
            this.textBoxNom.Multiline = true;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(240, 59);
            this.textBoxNom.TabIndex = 58;
            this.textBoxNom.Text = "Nom";
            this.textBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNom.WordWrap = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(549, 687);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(309, 80);
            this.buttonDelete.TabIndex = 82;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Modif_Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDummyAdd);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.checkBoxParentsPrev);
            this.Controls.Add(this.tier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQteMedic);
            this.Controls.Add(this.comboBoxMedic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxComm);
            this.Controls.Add(this.textBoxMotif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSuite);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHeureArrivee);
            this.Controls.Add(this.textBoxHeureDepart);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxClasse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Modif_Visite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modif_Visite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDummyAdd;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.CheckBox checkBoxParentsPrev;
        private System.Windows.Forms.Label tier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQteMedic;
        private System.Windows.Forms.ComboBox comboBoxMedic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComm;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSuite;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeureArrivee;
        private System.Windows.Forms.TextBox textBoxHeureDepart;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxClasse;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonDelete;
    }
}