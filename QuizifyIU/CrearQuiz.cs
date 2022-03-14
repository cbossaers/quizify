using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CrearQuiz : Form
    {
        public CrearQuiz()
        {
            InitializeComponent();
        }

        private void a1_Click(object sender, EventArgs e)
        {
            a1.Enabled = false;
            b1.Enabled = true;
            b1.Focus();
            

        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            a1.Enabled = true;
            a1.Focus();
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; b1.Enabled = false; a1.Enabled = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; a1.Enabled = true; b1.Enabled = false; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fCP = new MisExamenes() as Form;
            fCP.TopLevel = false;
            fCP.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fCP);
            this.panelContenedor.Tag = fCP;
            fCP.Show();*/
        }
    }
}
