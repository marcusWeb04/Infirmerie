namespace InfirmerieGUI
{
    partial class Modif_Medicament
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
            this.buttonDummyAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.buttonDummyAdd);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.textBoxLib);
            this.panel2.Controls.Add(this.labelBienvenue);
            this.panel2.Controls.Add(this.buttonRetour);
            this.panel2.Controls.Add(this.labelRecherche);
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 739);
            this.panel2.TabIndex = 24;
            // 
            // buttonDummyAdd
            // 
            this.buttonDummyAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.buttonDummyAdd.FlatAppearance.BorderSize = 0;
            this.buttonDummyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDummyAdd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDummyAdd.ForeColor = System.Drawing.Color.White;
            this.buttonDummyAdd.Location = new System.Drawing.Point(946, 659);
            this.buttonDummyAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDummyAdd.Name = "buttonDummyAdd";
            this.buttonDummyAdd.Size = new System.Drawing.Size(289, 80);
            this.buttonDummyAdd.TabIndex = 66;
            this.buttonDummyAdd.Text = "Modifier";
            this.buttonDummyAdd.UseVisualStyleBackColor = false;
            this.buttonDummyAdd.Click += new System.EventHandler(this.buttonDummyAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(490, 659);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(289, 80);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxLib
            // 
            this.textBoxLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLib.Location = new System.Drawing.Point(490, 374);
            this.textBoxLib.Multiline = true;
            this.textBoxLib.Name = "textBoxLib";
            this.textBoxLib.Size = new System.Drawing.Size(289, 64);
            this.textBoxLib.TabIndex = 22;
            this.textBoxLib.TextChanged += new System.EventHandler(this.textBoxLib_TextChanged);
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
            this.labelBienvenue.Text = "Détails Médicament";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonRetour.Size = new System.Drawing.Size(289, 80);
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
            this.labelRecherche.Location = new System.Drawing.Point(490, 321);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(289, 50);
            this.labelRecherche.TabIndex = 16;
            this.labelRecherche.Text = "Libellé :";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRecherche.Click += new System.EventHandler(this.labelRecherche_Click);
            // 
            // Modif_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.panel2);
            this.Name = "Modif_Medicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modif_Medicament";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLib;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDummyAdd;
    }
}