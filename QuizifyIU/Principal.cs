using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void biniciarS_Click(object sender, EventArgs e)
        {
            
        }

        private void bregistrarse_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarse(new registrarse());
        }

        private void AbrirFormRegistrarse(object formRegistrarse)
        {
            registrarse formr = new registrarse();
            formr.ShowDialog();
        }


    }
}
