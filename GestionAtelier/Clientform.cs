using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAtelier.Model;


namespace GestionAtelier 
{
    public partial class Clientform : Form
    {
        BD_GLAtelierEntities db = new BD_GLAtelierEntities();
        public Clientform()
        {
            InitializeComponent();
        }

        private void Clientform_Load(object sender, EventArgs e)
        {
          dgClient.DataSource = db.Client.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtcni.Text == "" || cbbSexe.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
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
                Client c = new Client();
                c.CNIClient = txtcni.Text;
                c.SexeClient = cbbSexe.Text;

                // On fait la migration de la clé primaire
                c.idPers = p.idPers;
                db.Client.Add(c);

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void effacer()
        {
            nom.Text = string.Empty;
            prenom.Text = string.Empty;
            adresse.Text = string.Empty;
            telephone.Text = string.Empty;
            txtcni.Text = string.Empty;
            cbbSexe.Text = string.Empty;
            dgClient.DataSource = db.Client.ToList();
            nom.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Login_Form form1 = new Login_Form();
            form1.Show();
            this.Hide();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            nom.Clear();
            prenom.Clear();
            adresse.Clear();
            telephone.Clear();
            txtcni.Clear();
            cbbSexe.Text = string.Empty;

            //On met l'accent sur l'identifiant
            nom.Focus();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez choisir le client", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? id = null;
                if (dgClient.CurrentRow.Cells[0].Value != null)
                {
                    id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
                }
                txtcni.Text = dgClient.CurrentRow.Cells[1].Value.ToString();
                cbbSexe.Text = dgClient.CurrentRow.Cells[2].Value.ToString();
                var p = db.Personne.Find(id);
                nom.Text = p.NomPers;
                prenom.Text = p.PrenomPers;
                adresse.Text = p.AdressePers;
                telephone.Text = p.TelPers;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtcni.Text == "" || cbbSexe.Text == "")
            {
                MessageBox.Show("Aucun client choisi!");
            }
            else
            {
                int? id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
                Personne p = db.Personne.Find(id);
                p.NomPers = nom.Text;
                p.PrenomPers = prenom.Text;
                p.AdressePers = adresse.Text;
                p.TelPers = telephone.Text;

                Client c = db.Client.Find(id);
                c.CNIClient = txtcni.Text;
                c.SexeClient = cbbSexe.Text;

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtcni.Text == "" || cbbSexe.Text == "")
            {
                MessageBox.Show("Veuillez choisir le client");
            }
            else
            {
                int? id = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
                Personne p = db.Personne.Find(id);
                db.Personne.Remove(p);

                Client c = db.Client.Find(id);
                db.Client.Remove(c);

                mesure m = db.mesure.Find(id);
                if (m != null)
                    db.mesure.Remove(m);
                
                Facture f = db.Facture.Find(id);
                if(f != null)
                    db.Facture.Remove(f);

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void Gerant_Form_Click(object sender, EventArgs e)
        {
            Gerantform form2 = new Gerantform();
            form2.Show();
            this.Hide();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            Parametreform form4 = new Parametreform();
            form4.Show();
            this.Hide();
        }

        private void Client_Form_Click(object sender, EventArgs e)
        {

        }

        private void btnMesure_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtcni.Text == "" || cbbSexe.Text == "")
            {
                MessageBox.Show("Aucun client choisi!");
            }
            else
            {
                Mesureform form1 = new Mesureform();
                form1.idPers = int.Parse(dgClient.CurrentRow.Cells[0].Value.ToString());
                form1.sexe = cbbSexe.Text;
                form1.ShowDialog();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var recherche = db.Personne.ToList();

            if (!string.IsNullOrEmpty(nom.Text))
            {
                recherche = recherche.Where(s => s.NomPers != null).ToList();
                recherche = recherche.Where(s => s.NomPers.ToUpper().Contains(nom.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(prenom.Text))
            {
                recherche = recherche.Where(s => s.PrenomPers != null).ToList();
                recherche = recherche.Where(s => s.PrenomPers.ToUpper().Contains(prenom.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(adresse.Text))
            {
                recherche = recherche.Where(s => s.AdressePers != null).ToList();
                recherche = recherche.Where(s => s.AdressePers.ToUpper().Contains(adresse.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(telephone.Text))
            {
                recherche = recherche.Where(s => s.TelPers != null).ToList();
                recherche = recherche.Where(s => s.TelPers.ToUpper().Contains(telephone.Text.ToUpper())).ToList();
            }

            dgClient.DataSource = recherche.ToList();
        }
    }
}
