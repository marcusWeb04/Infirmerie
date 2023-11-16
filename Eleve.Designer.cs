namespace InfirmerieGUI
{
    partial class Eleve
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.labelBienvenue = new System.Windows.Forms.Label();
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
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(0, 659);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(323, 80);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(134)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.Location = new System.Drawing.Point(912, 659);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(323, 80);
            this.buttonRetour.TabIndex = 13;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonRechercher.FlatAppearance.BorderSize = 0;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.ForeColor = System.Drawing.Color.White;
            this.buttonRechercher.Location = new System.Drawing.Point(420, 443);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(262, 64);
            this.buttonRechercher.TabIndex = 14;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(721, 443);
            this.textBoxRecherche.Multiline = true;
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(262, 64);
            this.textBoxRecherche.TabIndex = 15;
            // 
            // labelRecherche
            // 
            this.labelRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelRecherche.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecherche.ForeColor = System.Drawing.Color.Black;
            this.labelRecherche.Location = new System.Drawing.Point(627, 321);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(262, 50);
            this.labelRecherche.TabIndex = 16;
            this.labelRecherche.Text = "Recherche :";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(88, 115);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(1238, 58);
            this.labelBienvenue.TabIndex = 9;
            this.labelBienvenue.Text = "Élèves";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Controls.Add(this.buttonAjouter);
            this.panel2.Controls.Add(this.labelRecherche);
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 739);
            this.panel2.TabIndex = 18;
            // 
            // Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.panel2);
            this.Name = "Eleve";
            this.Text = "Eleve";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Panel panel2;
    }
}