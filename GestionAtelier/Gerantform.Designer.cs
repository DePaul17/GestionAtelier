﻿namespace GestionAtelier
{
    partial class Gerantform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerantform));
            this.btnVider = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtmdp = new System.Windows.Forms.Label();
            this.txtidentifiant = new System.Windows.Forms.TextBox();
            this.identifiant = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.txtgerant = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.Client_Form = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.TextBox();
            this.dgGerant = new System.Windows.Forms.DataGridView();
            this.Gerant_form = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGerant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVider
            // 
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.Location = new System.Drawing.Point(326, 566);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(98, 37);
            this.btnVider.TabIndex = 67;
            this.btnVider.Text = "&Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.DarkViolet;
            this.btnChoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.Location = new System.Drawing.Point(477, 609);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(86, 38);
            this.btnChoisir.TabIndex = 66;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(374, 609);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(97, 38);
            this.btnSupprimer.TabIndex = 65;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Khaki;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(284, 609);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(84, 38);
            this.btnModifier.TabIndex = 64;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Teal;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(201, 609);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 38);
            this.btnAjouter.TabIndex = 63;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtmdp
            // 
            this.txtmdp.AutoSize = true;
            this.txtmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdp.Location = new System.Drawing.Point(199, 489);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(123, 24);
            this.txtmdp.TabIndex = 60;
            this.txtmdp.Text = "Mot de passe";
            // 
            // txtidentifiant
            // 
            this.txtidentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentifiant.Location = new System.Drawing.Point(203, 454);
            this.txtidentifiant.Multiline = true;
            this.txtidentifiant.Name = "txtidentifiant";
            this.txtidentifiant.Size = new System.Drawing.Size(335, 32);
            this.txtidentifiant.TabIndex = 70;
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant.Location = new System.Drawing.Point(199, 417);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(88, 24);
            this.identifiant.TabIndex = 58;
            this.identifiant.Text = "Identifiant";
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(203, 370);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(335, 28);
            this.telephone.TabIndex = 57;
            // 
            // txttelephone
            // 
            this.txttelephone.AutoSize = true;
            this.txttelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone.Location = new System.Drawing.Point(199, 343);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(103, 24);
            this.txttelephone.TabIndex = 56;
            this.txttelephone.Text = "Téléphone";
            // 
            // adresse
            // 
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse.Location = new System.Drawing.Point(203, 305);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(335, 28);
            this.adresse.TabIndex = 55;
            // 
            // txtadresse
            // 
            this.txtadresse.AutoSize = true;
            this.txtadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadresse.Location = new System.Drawing.Point(199, 271);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(80, 24);
            this.txtadresse.TabIndex = 54;
            this.txtadresse.Text = "Adresse";
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(203, 230);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(335, 28);
            this.prenom.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Prénom";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(203, 158);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(335, 28);
            this.nom.TabIndex = 51;
            // 
            // txtgerant
            // 
            this.txtgerant.AutoSize = true;
            this.txtgerant.BackColor = System.Drawing.Color.Teal;
            this.txtgerant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgerant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtgerant.Location = new System.Drawing.Point(296, 87);
            this.txtgerant.Name = "txtgerant";
            this.txtgerant.Size = new System.Drawing.Size(121, 37);
            this.txtgerant.TabIndex = 50;
            this.txtgerant.Text = "Gerant";
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(199, 131);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(51, 24);
            this.txtnom.TabIndex = 49;
            this.txtnom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(534, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fashion Atelier";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(12, 553);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(154, 57);
            this.btnQuitter.TabIndex = 47;
            this.btnQuitter.Text = "    &Déconnexion";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Client_Form
            // 
            this.Client_Form.BackColor = System.Drawing.Color.Olive;
            this.Client_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Form.Location = new System.Drawing.Point(17, 170);
            this.Client_Form.Name = "Client_Form";
            this.Client_Form.Size = new System.Drawing.Size(154, 57);
            this.Client_Form.TabIndex = 45;
            this.Client_Form.Text = "&Client";
            this.Client_Form.UseVisualStyleBackColor = false;
            this.Client_Form.Click += new System.EventHandler(this.Client_Form_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Menu";
            // 
            // mdp
            // 
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(203, 529);
            this.mdp.Multiline = true;
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(335, 31);
            this.mdp.TabIndex = 68;
            this.mdp.UseSystemPasswordChar = true;
            // 
            // dgGerant
            // 
            this.dgGerant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGerant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgGerant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGerant.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGerant.Location = new System.Drawing.Point(569, 158);
            this.dgGerant.Name = "dgGerant";
            this.dgGerant.Size = new System.Drawing.Size(544, 476);
            this.dgGerant.TabIndex = 69;
            this.dgGerant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGerant_CellContentClick);
            // 
            // Gerant_form
            // 
            this.Gerant_form.BackColor = System.Drawing.Color.Olive;
            this.Gerant_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerant_form.Location = new System.Drawing.Point(17, 289);
            this.Gerant_form.Name = "Gerant_form";
            this.Gerant_form.Size = new System.Drawing.Size(154, 57);
            this.Gerant_form.TabIndex = 71;
            this.Gerant_form.Text = "&Gerant";
            this.Gerant_form.UseVisualStyleBackColor = false;
            // 
            // btnParametre
            // 
            this.btnParametre.BackColor = System.Drawing.Color.Olive;
            this.btnParametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.Location = new System.Drawing.Point(17, 417);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(154, 57);
            this.btnParametre.TabIndex = 100;
            this.btnParametre.Text = "        &Paramètres";
            this.btnParametre.UseVisualStyleBackColor = false;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.LightBlue;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(788, 115);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(145, 37);
            this.btnRechercher.TabIndex = 104;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(903, 122);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 105;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Olive;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(30, 431);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 101;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(20, 566);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 94;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Olive;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 299);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Olive;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(0, 87);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 560);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 92);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Gerantform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1125, 646);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Gerant_form);
            this.Controls.Add(this.dgGerant);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtidentifiant);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.txtgerant);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.Client_Form);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1141, 685);
            this.MinimumSize = new System.Drawing.Size(1141, 685);
            this.Name = "Gerantform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion Atelier";
            this.Load += new System.EventHandler(this.Gerantform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGerant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label txtmdp;
        private System.Windows.Forms.TextBox txtidentifiant;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label txttelephone;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label txtadresse;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label txtgerant;
        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button Client_Form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.DataGridView dgGerant;
        private System.Windows.Forms.Button Gerant_form;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnRechercher;
    }
}