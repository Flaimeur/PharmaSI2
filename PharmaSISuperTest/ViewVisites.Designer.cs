
namespace PharmaSISuperTest
{
    partial class ViewVisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisites));
            this.produit = new System.Windows.Forms.MenuStrip();
            this.Back = new System.Windows.Forms.ToolStripMenuItem();
            this.consultation = new System.Windows.Forms.ToolStripMenuItem();
            this.praticien = new System.Windows.Forms.ToolStripMenuItem();
            this.produitt = new System.Windows.Forms.ToolStripMenuItem();
            this.saisie = new System.Windows.Forms.ToolStripMenuItem();
            this.creecompterendu = new System.Windows.Forms.ToolStripMenuItem();
            this.deconexion = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelPraticien = new System.Windows.Forms.Label();
            this.cbRapports = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
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
            this.Back,
            this.consultation,
            this.produitt,
            this.saisie,
            this.deconexion});
            this.produit.Location = new System.Drawing.Point(0, 0);
            this.produit.Name = "produit";
            this.produit.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.produit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produit.Size = new System.Drawing.Size(1283, 30);
            this.produit.TabIndex = 40;
            this.produit.Text = "menuStrip2";
            // 
            // Back
            // 
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Image = global::PharmaSISuperTest.Properties.Resources.back;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(78, 28);
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
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
            this.consultation.Click += new System.EventHandler(this.consultation_Click);
            // 
            // praticien
            // 
            this.praticien.Name = "praticien";
            this.praticien.Size = new System.Drawing.Size(140, 26);
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
            this.creecompterendu});
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
            // deconexion
            // 
            this.deconexion.ForeColor = System.Drawing.Color.White;
            this.deconexion.Image = global::PharmaSISuperTest.Properties.Resources.logout_01;
            this.deconexion.Name = "deconexion";
            this.deconexion.Size = new System.Drawing.Size(136, 28);
            this.deconexion.Text = "Déconnexion";
            this.deconexion.Click += new System.EventHandler(this.deconexion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.pictureBox2.Image = global::PharmaSISuperTest.Properties.Resources.Icon;
            this.pictureBox2.Location = new System.Drawing.Point(584, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = global::PharmaSISuperTest.Properties.Resources.Box_connexion;
            this.pictureBox9.Location = new System.Drawing.Point(55, 43);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1172, 697);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 53;
            this.pictureBox9.TabStop = false;
            // 
            // labelPraticien
            // 
            this.labelPraticien.AutoSize = true;
            this.labelPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.labelPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPraticien.ForeColor = System.Drawing.Color.White;
            this.labelPraticien.Location = new System.Drawing.Point(79, 222);
            this.labelPraticien.Name = "labelPraticien";
            this.labelPraticien.Size = new System.Drawing.Size(369, 25);
            this.labelPraticien.TabIndex = 55;
            this.labelPraticien.Text = "Sélectionner un rapport de visite :";
            // 
            // cbRapports
            // 
            this.cbRapports.FormattingEnabled = true;
            this.cbRapports.Location = new System.Drawing.Point(468, 226);
            this.cbRapports.Name = "cbRapports";
            this.cbRapports.Size = new System.Drawing.Size(199, 21);
            this.cbRapports.TabIndex = 56;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(689, 228);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(105, 19);
            this.btnAfficher.TabIndex = 57;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(84, 265);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(1126, 434);
            this.txtDetails.TabIndex = 58;
            this.txtDetails.Text = "";
            // 
            // ViewVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1283, 760);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.cbRapports);
            this.Controls.Add(this.labelPraticien);
            this.Controls.Add(this.produit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVisites";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.ViewVisites_Load);
            this.produit.ResumeLayout(false);
            this.produit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip produit;
        private System.Windows.Forms.ToolStripMenuItem consultation;
        private System.Windows.Forms.ToolStripMenuItem praticien;
        private System.Windows.Forms.ToolStripMenuItem produitt;
        private System.Windows.Forms.ToolStripMenuItem saisie;
        private System.Windows.Forms.ToolStripMenuItem creecompterendu;
        private System.Windows.Forms.ToolStripMenuItem deconexion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ToolStripMenuItem Back;
        private System.Windows.Forms.Label labelPraticien;
        private System.Windows.Forms.ComboBox cbRapports;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.RichTextBox txtDetails;
    }
}