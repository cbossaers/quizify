using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class registrarse : Form
    {
        public registrarse()
        {
            InitializeComponent();
        }

        private void registrarse_Load(object sender, EventArgs e)
        {

        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(this, "Tu cuenta ha sido registrada con éxito.", "Cuenta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (confirmar == DialogResult.OK) this.Close();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
