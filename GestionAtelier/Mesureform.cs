using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GestionAtelier.Model;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace GestionAtelier
{
    public partial class Mesureform : Form 
    {
        public int idPers;
        public string sexe;
        BD_GLAtelierEntities db = new BD_GLAtelierEntities();

        public Mesureform()
        {
            InitializeComponent();
        }

        private void Mesureform_Load(object sender, EventArgs e)
        {
            if (sexe == "Femme")
            {
                pnFemme1.Visible = true;
            }
            else
            {
                pnFemme1.Visible = false;

                //ou faire textBox1.ReadOnly = true;
                LTaille.ReadOnly = true;
                TBras.ReadOnly = true;
                HPoitrine.ReadOnly = true;

                /*
                LTaille.Enabled = false;
                TBras.Enabled = false;
                HPoitrine.Enabled = false;
                */

            }

            dgMesure.DataSource = db.mesure.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            // Obtenir une référence à la fenêtre
            Mesureform form = this;

            // Fermer la fenêtre
            form.Close();

        }
          
        private void btnEnregistrer_Click(object sender, EventArgs e) 
        {
             if (taille.Text == "" || stature.Text == "" || TPoitrine.Text == "" || TTaille1.Text == "" || THanche.Text == "" || LManche.Text == "" || TCou.Text == "" || LPantalon1.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs de mensuration!");
            }
            else if (sexe == "Femme")
            {
                Personne p = new Personne();
                p.NomPers = nom.Text;
                p.PrenomPers = prenom.Text;
                p.AdressePers = adresse.Text;
                p.TelPers = telephone.Text;
                db.Personne.Add(p);
                db.SaveChanges();
                mesure m = new mesure();

                // Ajouter une condition pour vérifier si les champs de mesure sont vides
                if (taille.Text != "" && stature.Text != "" && TPoitrine.Text != "" && TTaille1.Text != "" && THanche.Text != "" && LManche.Text != "" && TCou.Text != "" && LPantalon1.Text != "" && LTaille.Text != "" && TBras.Text != "" && HPoitrine.Text != "")
                {
                    m.taille = Convert.ToInt32(taille.Text);
                    m.stature = Convert.ToInt32(stature.Text);
                    m.tour_poitrine = Convert.ToInt32(TPoitrine.Text);
                    m.tour_taille = Convert.ToInt32(TTaille1.Text);
                    m.tour_hanche = Convert.ToInt32(THanche.Text);
                    m.long_manche = Convert.ToInt32(LManche.Text);
                    m.tour_cou = Convert.ToInt32(TCou.Text);
                    m.long_pant = Convert.ToInt32(LPantalon1.Text);
                    m.long_dev = Convert.ToInt32(LTaille.Text);
                    m.tour_bras = Convert.ToInt32(TBras.Text);
                    m.hauteur_poitrine = Convert.ToInt32(HPoitrine.Text);

                    // On fait la migration de la clé primaire
                    m.idPers = idPers;
                    db.mesure.Add(m);

                    //Pour synchroniser
                    db.SaveChanges();

                    // On appelle la fonction effacer
                    effacer();
                }
            }
            else
            {
                Personne p = new Personne();
                p.NomPers = nom.Text;
                p.PrenomPers = prenom.Text;
                p.AdressePers = adresse.Text;
                p.TelPers = telephone.Text;
                db.Personne.Add(p);
                db.SaveChanges();
                mesure m = new mesure();
                // Ajouter une condition pour vérifier si les champs de mesure sont vides
                if (taille.Text != "" && stature.Text != "" && TPoitrine.Text != "" && TTaille1.Text != "" && THanche.Text != "" && LManche.Text != "" && TCou.Text != "" && LPantalon1.Text != "")
                {
                    m.taille = Convert.ToInt32(taille.Text);
                    m.stature = Convert.ToInt32(stature.Text);
                    m.tour_poitrine = Convert.ToInt32(TPoitrine.Text);
                    m.tour_taille = Convert.ToInt32(TTaille1.Text);
                    m.tour_hanche = Convert.ToInt32(THanche.Text);
                    m.long_manche = Convert.ToInt32(LManche.Text);
                    m.tour_cou = Convert.ToInt32(TCou.Text);
                    m.long_pant = Convert.ToInt32(LPantalon1.Text);

                    // On fait la migration de la clé primaire
                    m.idPers = idPers;
                    db.mesure.Add(m);

                    //Pour synchroniser
                    db.SaveChanges();

                    // On appelle la fonction effacer
                    effacer();
                }
            }
        }

        private void effacer()
        {
            taille.Text = string.Empty;
            stature.Text = string.Empty;
            TPoitrine.Text = string.Empty;
            TTaille1.Text = string.Empty;
            THanche.Text = string.Empty; 
            LManche.Text = string.Empty;
            TCou.Text = string.Empty;
            LPantalon1.Text = string.Empty;
            LTaille.Text = string.Empty;
            TBras.Text = string.Empty;
            HPoitrine.Text = string.Empty;
            dgMesure.DataSource = db.mesure.ToList();
            taille.Focus();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if(sexe == "Femme")
            {
                //int? id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());

                if (dgMesure.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un client", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int? id = null;
                    if (dgMesure.CurrentRow.Cells[0].Value != null)
                    {
                        id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());
                    }
                    taille.Text = dgMesure.CurrentRow.Cells[1].Value.ToString();
                    stature.Text = dgMesure.CurrentRow.Cells[2].Value.ToString();
                    TPoitrine.Text = dgMesure.CurrentRow.Cells[3].Value.ToString();
                    TTaille1.Text = dgMesure.CurrentRow.Cells[4].Value.ToString();
                    THanche.Text = dgMesure.CurrentRow.Cells[5].Value.ToString();
                    LManche.Text = dgMesure.CurrentRow.Cells[6].Value.ToString();
                    TCou.Text = dgMesure.CurrentRow.Cells[7].Value.ToString();
                    LPantalon1.Text = dgMesure.CurrentRow.Cells[8].Value.ToString();
                    LTaille.Text = dgMesure.CurrentRow.Cells[9].Value.ToString();
                    TBras.Text = dgMesure.CurrentRow.Cells[10].Value.ToString();
                    HPoitrine.Text = dgMesure.CurrentRow.Cells[11].Value.ToString();
                }
            }
            else
            {
                //int? id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());

                if (dgMesure.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un client à modifier.", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int? id = null;
                    if (dgMesure.CurrentRow.Cells[0].Value != null)
                    {
                        id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());
                    }
                    taille.Text = dgMesure.CurrentRow.Cells[1].Value.ToString();
                    stature.Text = dgMesure.CurrentRow.Cells[2].Value.ToString();
                    TPoitrine.Text = dgMesure.CurrentRow.Cells[3].Value.ToString();
                    TTaille1.Text = dgMesure.CurrentRow.Cells[4].Value.ToString();
                    THanche.Text = dgMesure.CurrentRow.Cells[5].Value.ToString();
                    LManche.Text = dgMesure.CurrentRow.Cells[6].Value.ToString();
                    TCou.Text = dgMesure.CurrentRow.Cells[7].Value.ToString();
                    LPantalon1.Text = dgMesure.CurrentRow.Cells[8].Value.ToString();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //int? id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());
            //Personne p = db.Personne.Find(id);
            int? id = null;
            if (dgMesure.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                if (dgMesure.CurrentRow.Cells[0].Value != null)
                {
                    id = int.Parse(dgMesure.CurrentRow.Cells[0].Value.ToString());
                }
                if (taille.Text == "" || stature.Text == "" || TPoitrine.Text == "" || TTaille1.Text == "" || THanche.Text == "" || LManche.Text == ""
                    || TCou.Text == "" || LPantalon1.Text == "" || LTaille.Text == "" || TBras.Text == "" || HPoitrine.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs de mensuration pour la modification!");
                }
                else if (sexe == "Femme")
                {
                    mesure m = db.mesure.Find(id);
                    m.taille = Convert.ToInt32(taille.Text);
                    m.stature = Convert.ToInt32(stature.Text);
                    m.tour_poitrine = Convert.ToInt32(TPoitrine.Text);
                    m.tour_taille = Convert.ToInt32(TTaille1.Text);
                    m.tour_hanche = Convert.ToInt32(THanche.Text);
                    m.long_manche = Convert.ToInt32(LManche.Text);
                    m.tour_cou = Convert.ToInt32(TCou.Text);
                    m.long_pant = Convert.ToInt32(LPantalon1.Text);
                    m.long_dev = Convert.ToInt32(LTaille.Text);
                    m.tour_bras = Convert.ToInt32(TBras.Text);
                    m.hauteur_poitrine = Convert.ToInt32(HPoitrine.Text);
                }
                else
                {
                    mesure m = db.mesure.Find(id);
                    m.taille = Convert.ToInt32(taille.Text);
                    m.stature = Convert.ToInt32(stature.Text);
                    m.tour_poitrine = Convert.ToInt32(TPoitrine.Text);
                    m.tour_taille = Convert.ToInt32(TTaille1.Text);
                    m.tour_hanche = Convert.ToInt32(THanche.Text);
                    m.long_manche = Convert.ToInt32(LManche.Text);
                    m.tour_cou = Convert.ToInt32(TCou.Text);
                    m.long_pant = Convert.ToInt32(LPantalon1.Text);
                }

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void btnfacture_Click(object sender, EventArgs e)
        {
            Factureform form1 = new Factureform();
            //form1.idPers = int.Parse(dgFacture.CurrentRow.Cells[0].Value.ToString());
            form1.ShowDialog();
        }
    }
}
