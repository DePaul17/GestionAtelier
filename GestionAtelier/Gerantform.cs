using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAtelier.Model;
using GestionAtelier.App_code;

namespace GestionAtelier
{
    public partial class Gerantform : Form
    {
        BD_GLAtelierEntities db = new BD_GLAtelierEntities();
        public Gerantform()
        {
            InitializeComponent();
        }

        private void Client_Form_Click(object sender, EventArgs e)
        {
            Clientform form2 = new Clientform();
            form2.Show();
            this.Hide();
        }

        private void Gerantform_Load(object sender, EventArgs e)
        {
            dgGerant.DataSource = db.Gerant.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtidentifiant.Text == "" || mdp.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    Personne p = new Personne();
                    p.NomPers = nom.Text;
                    p.PrenomPers = prenom.Text;
                    p.AdressePers = adresse.Text;
                    p.TelPers = telephone.Text;
                    db.Personne.Add(p);
                    db.SaveChanges();
                    Gerant g = new Gerant();
                    g.idGer = txtidentifiant.Text;
                    g.mdpGer = Helpers.GetMd5Hash(md5Hash, mdp.Text);

                    // On fait la migration de la clé primaire
                    g.idPers = p.idPers;
                    db.Gerant.Add(g);

                    //Pour synchroniser
                    db.SaveChanges();

                    // On appelle la fonction effacer
                    effacer();
                }
            }
        }
        private void effacer()
        {
            nom.Text = string.Empty;
            prenom.Text = string.Empty;
            adresse.Text = string.Empty;
            telephone.Text = string.Empty;
            txtidentifiant.Text = string.Empty;
            mdp.Text = string.Empty;
            dgGerant.DataSource = db.Gerant.ToList();
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
            txtidentifiant.Clear();
            mdp.Clear();

            //On met l'accent sur l'identifiant
            nom.Focus();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgGerant.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez choisir le client", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int? id = null;
                if (dgGerant.CurrentRow.Cells[0].Value != null)
                {
                    id = int.Parse(dgGerant.CurrentRow.Cells[0].Value.ToString());
                }
                txtidentifiant.Text = dgGerant.CurrentRow.Cells[1].Value.ToString();
                mdp.Text = dgGerant.CurrentRow.Cells[2].Value.ToString();

                var p = db.Personne.Find(id);
                nom.Text = p.NomPers;
                prenom.Text = p.PrenomPers;
                adresse.Text = p.AdressePers;
                telephone.Text = p.TelPers;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtidentifiant.Text == "" || mdp.Text == "")
            {
                MessageBox.Show("Aucun client choisi!");
            }
            else
            {
                int? id = int.Parse(dgGerant.CurrentRow.Cells[0].Value.ToString());
                Personne p = db.Personne.Find(id);
                p.NomPers = nom.Text;
                p.PrenomPers = prenom.Text;
                p.AdressePers = adresse.Text;
                p.TelPers = telephone.Text;

                Gerant g = db.Gerant.Find(id);
                g.idGer = txtidentifiant.Text;
                g.mdpGer = mdp.Text;

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || telephone.Text == "" || txtidentifiant.Text == "" || mdp.Text == "")
            {
                MessageBox.Show("Veuillez choisir le client");
            }
            else
            {
                int? id = int.Parse(dgGerant.CurrentRow.Cells[0].Value.ToString());
                Personne p = db.Personne.Find(id);
                db.Personne.Remove(p);

                Gerant g = db.Gerant.Find(id);
                db.Gerant.Remove(g);

                //Pour synchroniser
                db.SaveChanges();

                // On appelle la fonction effacer
                effacer();
            }
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            Parametreform form4 = new Parametreform();
            form4.Show();
            this.Hide();
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

            dgGerant.DataSource = recherche.ToList();
        }

        private void dgGerant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
