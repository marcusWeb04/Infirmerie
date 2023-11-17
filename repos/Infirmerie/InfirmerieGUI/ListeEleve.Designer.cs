namespace InfirmerieGUI
{
    partial class ListeEleve
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
            this.bD_UtilisateursDataSet = new InfirmerieGUI.BD_UtilisateursDataSet();
            this.bDUtilisateursDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD_UtilisateursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUtilisateursDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_UtilisateursDataSet
            // 
            this.bD_UtilisateursDataSet.DataSetName = "BD_UtilisateursDataSet";
            this.bD_UtilisateursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDUtilisateursDataSetBindingSource
            // 
            this.bDUtilisateursDataSetBindingSource.DataSource = this.bD_UtilisateursDataSet;
            this.bDUtilisateursDataSetBindingSource.Position = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DataSource = this.bDUtilisateursDataSetBindingSource;
            this.dgv.Location = new System.Drawing.Point(37, 140);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1164, 399);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelBienvenue.Font = new System.Drawing.Font("Arial", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenue.Location = new System.Drawing.Point(3, 11);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(1229, 58);
            this.labelBienvenue.TabIndex = 10;
            this.labelBienvenue.Text = "Élèves";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBienvenue.Click += new System.EventHandler(this.labelBienvenue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.buttonModifier);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonRetour);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.labelBienvenue);
            this.panel1.Location = new System.Drawing.Point(94, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 739);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.buttonModifier.FlatAppearance.BorderSize = 0;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(912, 659);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(323, 80);
            this.buttonModifier.TabIndex = 16;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(435, 659);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 80);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter une visite";
            this.button1.UseVisualStyleBackColor = false;
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
            this.buttonRetour.TabIndex = 14;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // ListeEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.panel1);
            this.Name = "ListeEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeEleve";
            ((System.ComponentModel.ISupportInitialize)(this.bD_UtilisateursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDUtilisateursDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bDUtilisateursDataSetBindingSource;
        private BD_UtilisateursDataSet bD_UtilisateursDataSet;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button button1;
    }
}