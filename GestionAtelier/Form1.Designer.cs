namespace GestionAtelier
{
    partial class Login_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBienvenue = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.Label();
            this.Identifiant = new System.Windows.Forms.TextBox();
            this.Mdp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fashion Atelier";
            // 
            // txtBienvenue
            // 
            this.txtBienvenue.AutoSize = true;
            this.txtBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienvenue.Location = new System.Drawing.Point(577, 22);
            this.txtBienvenue.Name = "txtBienvenue";
            this.txtBienvenue.Size = new System.Drawing.Size(261, 55);
            this.txtBienvenue.TabIndex = 16;
            this.txtBienvenue.Text = "Bienvenue";
            this.txtBienvenue.Click += new System.EventHandler(this.txtBienvenue_Click);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.AutoSize = true;
            this.txtIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifiant.Location = new System.Drawing.Point(461, 124);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(88, 24);
            this.txtIdentifiant.TabIndex = 17;
            this.txtIdentifiant.Text = "Identifiant";
            // 
            // txtMdp
            // 
            this.txtMdp.AutoSize = true;
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(461, 250);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(123, 24);
            this.txtMdp.TabIndex = 18;
            this.txtMdp.Text = "Mot de passe";
            // 
            // Identifiant
            // 
            this.Identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifiant.Location = new System.Drawing.Point(465, 167);
            this.Identifiant.Multiline = true;
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.PasswordChar = '•';
            this.Identifiant.Size = new System.Drawing.Size(435, 29);
            this.Identifiant.TabIndex = 19;
            // 
            // Mdp
            // 
            this.Mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdp.Location = new System.Drawing.Point(465, 298);
            this.Mdp.Multiline = true;
            this.Mdp.Name = "Mdp";
            this.Mdp.PasswordChar = '•';
            this.Mdp.Size = new System.Drawing.Size(435, 28);
            this.Mdp.TabIndex = 20;
            this.Mdp.TextChanged += new System.EventHandler(this.Mdp_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Teal;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(785, 415);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 52);
            this.btnValider.TabIndex = 21;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.SystemColors.Control;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(667, 415);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(99, 52);
            this.btnEffacer.TabIndex = 22;
            this.btnEffacer.Text = "    &Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(314, 563);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(133, 50);
            this.btnQuitter.TabIndex = 23;
            this.btnQuitter.Text = "  &Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Teal;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(326, 575);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-31, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 225);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 650);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Teal;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(877, 423);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(675, 427);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // Login_Form
            // 
            this.ClientSize = new System.Drawing.Size(1125, 646);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.Mdp);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtBienvenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1141, 685);
            this.MinimumSize = new System.Drawing.Size(1141, 685);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion Atelier";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtBienvenue;
        private System.Windows.Forms.Label txtIdentifiant;
        private System.Windows.Forms.Label txtMdp;
        private System.Windows.Forms.TextBox Identifiant;
        private System.Windows.Forms.TextBox Mdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

