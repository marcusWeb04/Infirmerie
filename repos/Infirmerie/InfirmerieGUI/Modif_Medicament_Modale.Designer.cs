namespace InfirmerieGUI
{
    partial class Modif_Medicament_Modale
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
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(12, 54);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(658, 58);
            this.labelBienvenue.TabIndex = 57;
            this.labelBienvenue.Text = "Êtes-vous sûr(e) ?";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBienvenue.Click += new System.EventHandler(this.labelBienvenue_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.ForeColor = System.Drawing.Color.White;
            this.buttonNo.Location = new System.Drawing.Point(9, 164);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(310, 80);
            this.buttonNo.TabIndex = 58;
            this.buttonNo.Text = "Non";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.ForeColor = System.Drawing.Color.White;
            this.buttonYes.Location = new System.Drawing.Point(362, 164);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(310, 80);
            this.buttonYes.TabIndex = 59;
            this.buttonYes.Text = "Oui";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // Modif_Medicament_Modale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 253);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.labelBienvenue);
            this.Name = "Modif_Medicament_Modale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modif_Medicament_Modal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
    }
}