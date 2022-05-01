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
        private NuevoServicio servicio;
        private dynamic usuario;
        public CursoForm(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;

            if (servicio.GetTipoEntidad(user) == "alumno")
            {
                bGestionarCurso.Enabled = false;
                bCrearCurso.Enabled = false;
            }
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            AbrirFormCrearCurso(new CrearCurso(servicio, usuario));
        }

        private void bGestionarCurso_Click(object sender, EventArgs e)
        {
            AbrirFormGestionarCurso(new GestionarCurso(servicio, usuario));
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            AbrirFormApuntarseCurso();
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
        private void AbrirFormApuntarseCurso()
        {
            ApuntarseCurso formApuntarse = new ApuntarseCurso(servicio, usuario);
            formApuntarse.ShowDialog();
        }
        private void AbrirFormGestionarCurso(object formGestionarCurso)
        {
            if (this.panelCurso.Controls.Count > 0)
                this.panelCurso.Controls.RemoveAt(0);
            Form fGC = formGestionarCurso as Form;
            fGC.TopLevel = false;
            fGC.Dock = DockStyle.Fill;
            this.panelCurso.Controls.Add(fGC);
            this.panelCurso.Tag = fGC;
            fGC.Show();
        }
    }
}
