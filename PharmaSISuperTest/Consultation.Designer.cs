
namespace PharmaSISuperTest
{
    partial class Consultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultation));
            this.dataGridViewPraticiens = new System.Windows.Forms.DataGridView();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.produit = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.praticien = new System.Windows.Forms.ToolStripMenuItem();
            this.produitt = new System.Windows.Forms.ToolStripMenuItem();
            this.saisie = new System.Windows.Forms.ToolStripMenuItem();
            this.creecompterendu = new System.Windows.Forms.ToolStripMenuItem();
            this.voircompterendu = new System.Windows.Forms.ToolStripMenuItem();
            this.deconexion = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPraticiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.produit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPraticiens
            // 
            this.dataGridViewPraticiens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.dataGridViewPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPraticiens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.dataGridViewPraticiens.Location = new System.Drawing.Point(288, 280);
            this.dataGridViewPraticiens.Name = "dataGridViewPraticiens";
            this.dataGridViewPraticiens.Size = new System.Drawing.Size(1040, 515);
            this.dataGridViewPraticiens.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = global::PharmaSISuperTest.Properties.Resources.Box_connexion;
            this.pictureBox9.Location = new System.Drawing.Point(222, 121);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1172, 697);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.pictureBox2.Image = global::PharmaSISuperTest.Properties.Resources.Icon;
            this.pictureBox2.Location = new System.Drawing.Point(750, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.Color.Transparent;
            this.produit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.GripMargin = new System.Windows.Forms.Padding(2);
            this.produit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.produitt,
            this.saisie,
            this.deconexion});
            this.produit.Location = new System.Drawing.Point(0, 0);
            this.produit.Name = "produit";
            this.produit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produit.Size = new System.Drawing.Size(1616, 29);
            this.produit.TabIndex = 40;
            this.produit.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.praticien});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::PharmaSISuperTest.Properties.Resources.Icon_2;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 25);
            this.toolStripMenuItem1.Text = "Consultation";
            // 
            // praticien
            // 
            this.praticien.Name = "praticien";
            this.praticien.Size = new System.Drawing.Size(140, 26);
            this.praticien.Text = "Praticien";
            // 
            // produitt
            // 
            this.produitt.ForeColor = System.Drawing.Color.White;
            this.produitt.Image = global::PharmaSISuperTest.Properties.Resources.Icon_3;
            this.produitt.Name = "produitt";
            this.produitt.Size = new System.Drawing.Size(89, 25);
            this.produitt.Text = "Produit";
            // 
            // saisie
            // 
            this.saisie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creecompterendu,
            this.voircompterendu});
            this.saisie.ForeColor = System.Drawing.Color.White;
            this.saisie.Image = global::PharmaSISuperTest.Properties.Resources.Icon_3;
            this.saisie.Name = "saisie";
            this.saisie.Size = new System.Drawing.Size(78, 25);
            this.saisie.Text = "Saisie";
            // 
            // creecompterendu
            // 
            this.creecompterendu.Name = "creecompterendu";
            this.creecompterendu.Size = new System.Drawing.Size(221, 26);
            this.creecompterendu.Text = "Créer compte-rendu";
            // 
            // voircompterendu
            // 
            this.voircompterendu.Name = "voircompterendu";
            this.voircompterendu.Size = new System.Drawing.Size(221, 26);
            this.voircompterendu.Text = "Voir compte-rendu";
            // 
            // deconexion
            // 
            this.deconexion.ForeColor = System.Drawing.Color.White;
            this.deconexion.Image = global::PharmaSISuperTest.Properties.Resources.logout_01;
            this.deconexion.Name = "deconexion";
            this.deconexion.Size = new System.Drawing.Size(128, 25);
            this.deconexion.Text = "Déconnexion";
            this.deconexion.Click += new System.EventHandler(this.deconexion_Click);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1616, 939);
            this.Controls.Add(this.produit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewPraticiens);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPraticiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.produit.ResumeLayout(false);
            this.produit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPraticiens;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip produit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem praticien;
        private System.Windows.Forms.ToolStripMenuItem produitt;
        private System.Windows.Forms.ToolStripMenuItem saisie;
        private System.Windows.Forms.ToolStripMenuItem creecompterendu;
        private System.Windows.Forms.ToolStripMenuItem voircompterendu;
        private System.Windows.Forms.ToolStripMenuItem deconexion;
    }
}