using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAtelier.Model;

namespace GestionAtelier
{
    public partial class Parametreform : Form
    {
        public Parametreform()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Login_Form form1 = new Login_Form();
            form1.Show();
            this.Hide();
        }

        private void Gerant_Form_Click(object sender, EventArgs e)
        {
            Gerantform form2 = new Gerantform();
            form2.Show();
            this.Hide();
        }

        private void Client_Form_Click(object sender, EventArgs e)
        {
            Clientform form3 = new Clientform();
            form3.Show();
            this.Hide();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {

            if (cbbMode.Text == "Claire")
            {
                // On récupère le formulaire courant
                Login_Form form = new Login_Form();
                Menuform form1 = new Menuform();
                Clientform form2 =  new Clientform();
                Gerantform form3 =  new Gerantform();
                Parametreform form4 = new Parametreform();
                form4.Show();

                // On change la couleur de fond du formulaire en noir 
                form.BackColor = Color.White;
                form1.BackColor = Color.White;
                form2.BackColor = Color.White;
                form3.BackColor = Color.White;
                form4.BackColor = Color.White;
            }
            else
            {

                    // Changer la couleur d'arrière-plan en noir
                    this.BackColor = Color.Black;

                    // Changer la couleur de police en blanc
                    this.ForeColor = Color.White;
            }
        }

        private void btnAppliquer1_Click(object sender, EventArgs e)
        {
            if(cbbLangue.Text == "Français")
            {
                Parametreform form4 = new Parametreform();
                form4.Show();
                this.Hide();
            }
            else
            {
                //Changer la culture actuelle(Français) en anglais
                CultureInfo englishCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = englishCulture;
                Thread.CurrentThread.CurrentUICulture = englishCulture;
 
                //Changer le formulaire et le texte du controle en anglais
                foreach (Form f in Application.OpenForms)
                {
                ComponentResourceManager resources = new ComponentResourceManager(f.GetType());
                resources.ApplyResources(f, "$this", englishCulture);

                    foreach (Control c in f.Controls)
                    {
                        resources.ApplyResources(c, c.Name, englishCulture);
                    }
                }
            }
        }


        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if(message.Text == "")
            {
                MessageBox.Show("Merci de remplir ce champ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                message.Clear();
                MessageBox.Show("✔️ Merci pour votre nessage !");
            }
        }
    }
}
