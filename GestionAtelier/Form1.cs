using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using GestionAtelier.App_code;

namespace GestionAtelier
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DEPAUL17;Initial Catalog=BD_GLAtelier;Integrated Security=True");

        private void btnEffacer_Click_1(object sender, EventArgs e)
        {
            Identifiant.Clear();
            Mdp.Clear();

            //On met l'accent sur l'identifiant
            Identifiant.Focus();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            String idGer, mdpGer; 

            idGer = Identifiant.Text;
            mdpGer = Mdp.Text;

            try
            {
                String querry = "SELECT * FROM Gerant WHERE idGer = '" + Identifiant.Text + "' AND mdpGer = '" + Mdp.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn); 

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    idGer = Identifiant.Text; mdpGer = Mdp.Text;

                    //La page qui doit ensuite être chargée
                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();
                }
                else if (Identifiant.Text == "" || Mdp.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Identifiant.Clear();
                    Mdp.Clear();

                    // On met l'accent sur l'identifiant
                    Identifiant.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Voulez-vous quitter ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void txtBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void Mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
