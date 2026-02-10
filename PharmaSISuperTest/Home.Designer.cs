
namespace PharmaSISuperTest
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.produit = new System.Windows.Forms.MenuStrip();
            this.consultation = new System.Windows.Forms.ToolStripMenuItem();
            this.praticien = new System.Windows.Forms.ToolStripMenuItem();
            this.produitt = new System.Windows.Forms.ToolStripMenuItem();
            this.saisie = new System.Windows.Forms.ToolStripMenuItem();
            this.creecompterendu = new System.Windows.Forms.ToolStripMenuItem();
            this.voircompterendu = new System.Windows.Forms.ToolStripMenuItem();
            this.deconexion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.Color.Transparent;
            this.produit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.GripMargin = new System.Windows.Forms.Padding(2);
            this.produit.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.produit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultation,
            this.produitt,
            this.saisie,
            this.deconexion});
            this.produit.Location = new System.Drawing.Point(0, 0);
            this.produit.Name = "produit";
            this.produit.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.produit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produit.Size = new System.Drawing.Size(1283, 30);
            this.produit.TabIndex = 39;
            this.produit.Text = "menuStrip2";
            // 
            // consultation
            // 
            this.consultation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.praticien});
            this.consultation.ForeColor = System.Drawing.Color.White;
            this.consultation.Image = global::PharmaSISuperTest.Properties.Resources.Icon_2;
            this.consultation.Name = "consultation";
            this.consultation.Size = new System.Drawing.Size(134, 28);
            this.consultation.Text = "Consultation";
            // 
            // praticien
            // 
            this.praticien.Name = "praticien";
            this.praticien.Size = new System.Drawing.Size(180, 26);
            this.praticien.Text = "Praticien";
            this.praticien.Click += new System.EventHandler(this.praticien_Click);
            // 
            // produitt
            // 
            this.produitt.ForeColor = System.Drawing.Color.White;
            this.produitt.Image = global::PharmaSISuperTest.Properties.Resources.Icon_3;
            this.produitt.Name = "produitt";
            this.produitt.Size = new System.Drawing.Size(97, 28);
            this.produitt.Text = "Produit";
            this.produitt.Click += new System.EventHandler(this.produitt_Click);
            // 
            // saisie
            // 
            this.saisie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creecompterendu,
            this.voircompterendu});
            this.saisie.ForeColor = System.Drawing.Color.White;
            this.saisie.Image = global::PharmaSISuperTest.Properties.Resources.Icon_10;
            this.saisie.Name = "saisie";
            this.saisie.Size = new System.Drawing.Size(86, 28);
            this.saisie.Text = "Saisie";
            // 
            // creecompterendu
            // 
            this.creecompterendu.Name = "creecompterendu";
            this.creecompterendu.Size = new System.Drawing.Size(221, 26);
            this.creecompterendu.Text = "Créer compte-rendu";
            this.creecompterendu.Click += new System.EventHandler(this.creecompterendu_Click);
            // 
            // voircompterendu
            // 
            this.voircompterendu.Name = "voircompterendu";
            this.voircompterendu.Size = new System.Drawing.Size(221, 26);
            this.voircompterendu.Text = "Voir compte-rendu";
            this.voircompterendu.Click += new System.EventHandler(this.voircompterendu_Click);
            // 
            // deconexion
            // 
            this.deconexion.ForeColor = System.Drawing.Color.White;
            this.deconexion.Image = global::PharmaSISuperTest.Properties.Resources.logout_01;
            this.deconexion.Name = "deconexion";
            this.deconexion.Size = new System.Drawing.Size(136, 28);
            this.deconexion.Text = "Déconnexion";
            this.deconexion.Click += new System.EventHandler(this.deconexion_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(503, 311);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(277, 51);
            this.statusLabel.TabIndex = 40;
            this.statusLabel.Text = "Bonjour ... 👋\r\n";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.pictureBox2.Image = global::PharmaSISuperTest.Properties.Resources.Icon;
            this.pictureBox2.Location = new System.Drawing.Point(583, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = global::PharmaSISuperTest.Properties.Resources.Box_connexion;
            this.pictureBox9.Location = new System.Drawing.Point(105, 82);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1072, 597);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1283, 760);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.produit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.produit.ResumeLayout(false);
            this.produit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem consultation;
        private System.Windows.Forms.ToolStripMenuItem praticien;
        private System.Windows.Forms.ToolStripMenuItem produitt;
        private System.Windows.Forms.ToolStripMenuItem saisie;
        private System.Windows.Forms.MenuStrip produit;
        private System.Windows.Forms.ToolStripMenuItem deconexion;
        private System.Windows.Forms.ToolStripMenuItem creecompterendu;
        private System.Windows.Forms.ToolStripMenuItem voircompterendu;
        private System.Windows.Forms.Label statusLabel;
    }
}