using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAtelier
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Client_Form_Click(object sender, EventArgs e)
        {
            Clientform form2 = new Clientform();
            form2.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Login_Form form1 = new Login_Form();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Menuform_Load(object sender, EventArgs e)
        {

        }

        private void Gerant_Form_Click(object sender, EventArgs e)
        {
            Gerantform form3 = new Gerantform();
            form3.Show();
            this.Hide();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            Parametreform form4 = new Parametreform();
            form4.Show();
            this.Hide();
        }
    }
}
