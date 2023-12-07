namespace InfirmerieGUI
{
    partial class Visite
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
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(104)))));
            this.buttonRechercher.FlatAppearance.BorderSize = 0;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.ForeColor = System.Drawing.Color.White;
            this.buttonRechercher.Location = new System.Drawing.Point(32, 374);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(262, 64);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(367, 374);
            this.textBoxRecherche.Multiline = true;
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(262, 64);
            this.textBoxRecherche.TabIndex = 25;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(3, 11);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(1229, 58);
            this.labelBienvenue.TabIndex = 23;
            this.labelBienvenue.Text = "Visite";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelBienvenue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBoxRecherche);
            this.panel2.Controls.Add(this.buttonRechercher);
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Controls.Add(this.labelRecherche);
            this.panel2.Location = new System.Drawing.Point(103, 92);
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
            // labelRecherche
            // 
            this.labelRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelRecherche.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecherche.ForeColor = System.Drawing.Color.Black;
            this.labelRecherche.Location = new System.Drawing.Point(367, 321);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(262, 50);
            this.labelRecherche.TabIndex = 16;
            this.labelRecherche.Text = "Date :";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 374);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 64);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(650, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mois :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(952, 374);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 64);
            this.textBox2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(952, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.panel2);
            this.Name = "Visite";
            this.Text = "Visite";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}