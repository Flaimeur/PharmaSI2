
namespace PharmaSISuperTest
{
    partial class Saisie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saisie));
            this.produit = new System.Windows.Forms.MenuStrip();
            this.Back = new System.Windows.Forms.ToolStripMenuItem();
            this.consultation = new System.Windows.Forms.ToolStripMenuItem();
            this.praticien = new System.Windows.Forms.ToolStripMenuItem();
            this.produitt = new System.Windows.Forms.ToolStripMenuItem();
            this.deconexion = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPraticien = new System.Windows.Forms.Label();
            this.comboBoxPraticien = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVisite = new System.Windows.Forms.DateTimePicker();
            this.textBoxRapport = new System.Windows.Forms.TextBox();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.buttonSauvegarder = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.praticien.Size = new System.Drawing.Size(140, 26);
            this.praticien.Text = "Praticien";
            // 
            // produitt
            // 
            this.produitt.ForeColor = System.Drawing.Color.White;
            this.produitt.Image = global::PharmaSISuperTest.Properties.Resources.Icon_3;
            this.produitt.Name = "produitt";
            this.produitt.Size = new System.Drawing.Size(97, 28);
            this.produitt.Text = "Produit";
            // 
            // deconexion
            // 
            this.deconexion.ForeColor = System.Drawing.Color.White;
            this.deconexion.Image = global::PharmaSISuperTest.Properties.Resources.logout_01;
            this.deconexion.Name = "deconexion";
            this.deconexion.Size = new System.Drawing.Size(136, 28);
            this.deconexion.Text = "Déconnexion";
            // 
            // labelPraticien
            // 
            this.labelPraticien.AutoSize = true;
            this.labelPraticien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.labelPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPraticien.ForeColor = System.Drawing.Color.White;
            this.labelPraticien.Location = new System.Drawing.Point(455, 249);
            this.labelPraticien.Name = "labelPraticien";
            this.labelPraticien.Size = new System.Drawing.Size(204, 25);
            this.labelPraticien.TabIndex = 41;
            this.labelPraticien.Text = "Nom du praticien :";
            // 
            // comboBoxPraticien
            // 
            this.comboBoxPraticien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPraticien.FormattingEnabled = true;
            this.comboBoxPraticien.Location = new System.Drawing.Point(455, 286);
            this.comboBoxPraticien.Name = "comboBoxPraticien";
            this.comboBoxPraticien.Size = new System.Drawing.Size(372, 21);
            this.comboBoxPraticien.TabIndex = 42;
            // 
            // dateTimePickerVisite
            // 
            this.dateTimePickerVisite.Location = new System.Drawing.Point(455, 357);
            this.dateTimePickerVisite.Name = "dateTimePickerVisite";
            this.dateTimePickerVisite.Size = new System.Drawing.Size(372, 20);
            this.dateTimePickerVisite.TabIndex = 44;
            // 
            // textBoxRapport
            // 
            this.textBoxRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxRapport.Location = new System.Drawing.Point(455, 482);
            this.textBoxRapport.Multiline = true;
            this.textBoxRapport.Name = "textBoxRapport";
            this.textBoxRapport.Size = new System.Drawing.Size(372, 119);
            this.textBoxRapport.TabIndex = 46;
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxDuree.Location = new System.Drawing.Point(455, 410);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(372, 20);
            this.textBoxDuree.TabIndex = 47;
            this.textBoxDuree.Text = "HH:mm";
            // 
            // buttonSauvegarder
            // 
            this.buttonSauvegarder.Location = new System.Drawing.Point(341, 633);
            this.buttonSauvegarder.Name = "buttonSauvegarder";
            this.buttonSauvegarder.Size = new System.Drawing.Size(283, 23);
            this.buttonSauvegarder.TabIndex = 49;
            this.buttonSauvegarder.Text = "Sauvegarder";
            this.buttonSauvegarder.UseVisualStyleBackColor = true;
            this.buttonSauvegarder.Click += new System.EventHandler(this.buttonSauvegarder_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(658, 633);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(283, 23);
            this.buttonRetour.TabIndex = 50;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click_1);
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
            this.pictureBox2.TabIndex = 52;
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
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(455, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Rapport :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Heure :";
            // 
            // Saisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1283, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonSauvegarder);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.textBoxRapport);
            this.Controls.Add(this.dateTimePickerVisite);
            this.Controls.Add(this.comboBoxPraticien);
            this.Controls.Add(this.labelPraticien);
            this.Controls.Add(this.produit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saisie";
            this.Text = "Saisie";
            this.Load += new System.EventHandler(this.Saisie_Load);
            this.produit.ResumeLayout(false);
            this.produit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip produit;
        private System.Windows.Forms.ToolStripMenuItem Back;
        private System.Windows.Forms.ToolStripMenuItem consultation;
        private System.Windows.Forms.ToolStripMenuItem praticien;
        private System.Windows.Forms.ToolStripMenuItem produitt;
        private System.Windows.Forms.ToolStripMenuItem deconexion;
        private System.Windows.Forms.Label labelPraticien;
        private System.Windows.Forms.ComboBox comboBoxPraticien;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisite;
        private System.Windows.Forms.TextBox textBoxRapport;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.Button buttonSauvegarder;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}