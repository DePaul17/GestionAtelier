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
    public partial class Factureform : Form
    {
        public int idPers;
        BD_GLAtelierEntities db = new BD_GLAtelierEntities();

        public Factureform()
        {
            InitializeComponent();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            dgFacture.DataSource = db.Facture.ToList();
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantite.Text == "" || designation.Text == "" || pu.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs pour la facture !");
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

                    Facture f = new Facture();

                    // Ajouter une condition pour vérifier si les champs de mesure sont vides
                    if (quantite.Text != "" && designation.Text != "" && pu.Text != "")
                    {
                        f.qteF = Convert.ToInt32(quantite.Text);
                        f.designationF = designation.Text;
                        f.prixUnitF = Convert.ToInt32(pu.Text);
                        f.montantF = f.qteF * f.prixUnitF;
                        f.DateHeureF = DateTime.Now;

                        // On fait la migration de la clé primaire
                        f.idPers = idPers;
                        db.Facture.Add(f);

                        db.SaveChanges();

                        // On appelle la fonction effacer
                        effacer();
                    }
                }

                MessageBox.Show("Facture ajouté.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la sauvegarde des données : " + ex.Message + "Si l'erreur persiste, veuillez vous rapprocher de l'administrateur système");
                // Autres actions à prendre en cas d'erreur
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            // Obtenir une référence à la fenêtre 
            Factureform form = this;

            // Fermer la fenêtre
            form.Close();
        }

        private void effacer()
        {
            quantite.Text = string.Empty;
            designation.Text = string.Empty;
            pu.Text = string.Empty;
            dgFacture.DataSource = db.mesure.ToList();
            quantite.Focus();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //On recharge le DataGridView
            //dgFacture.Refresh();

            /*On rafraichit la fenetre
            this.Invalidate();
            this.Update();*/
            Factureform form = this;
            form.Refresh();
        }
    }
}
