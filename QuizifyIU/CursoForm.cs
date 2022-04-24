using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CursoForm : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public CursoForm(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            AbrirFormCrearCurso(new CrearCurso(servicio, usuario));
        }

        private void AbrirFormCrearCurso(object formCrearCurso)
        {
            if (this.panelCurso.Controls.Count > 0)
                this.panelCurso.Controls.RemoveAt(0);
            Form fCC = formCrearCurso as Form;
            fCC.TopLevel = false;
            fCC.Dock = DockStyle.Fill;
            this.panelCurso.Controls.Add(fCC);
            this.panelCurso.Tag = fCC;
            fCC.Show();
        }
    }
}
