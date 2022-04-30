using Quizify.Entities;
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
    public partial class CrearCurso : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public CrearCurso(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            registrarCurso();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            AbrirFormCurso(new CursoForm(servicio, usuario));
        }

        private void AbrirFormCurso(object formCurso)
        {
            if (this.panelCrearCurso.Controls.Count > 0)
                this.panelCrearCurso.Controls.RemoveAt(0);
            Form fC = formCurso as Form;
            fC.TopLevel = false;
            fC.Dock = DockStyle.Fill;
            this.panelCrearCurso.Controls.Add(fC);
            this.panelCrearCurso.Tag = fC;
            fC.Show();
        }

        private void registrarCurso()
        {
            string codigo = codCursoBox.Text;
            string nombre = nombreCursoBox.Text;
            string autor = usuario.nombre;
            int numAl = 0;
            int numMaxAl = (int)maxAlumnos.Value;
            DateTime fechaCreado = DateTime.Now;
            string contraseña = boxContraseña.Text;

            if (servicio.ExisteCurso(codigo))
            {
                DialogResult avisoCursoRepe = MessageBox.Show(this, "El curso con el código " + codigo + " ya existe.", "Curso repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //ojo que esto es temporal para hacer el video de CSO!!
                List<string> a = new List<string>{};
                Curso newCurso = new Curso(codigo, nombre, autor, numAl, numMaxAl, fechaCreado, contraseña,a);
                servicio.AddCurso(newCurso);
                DialogResult confirmar = MessageBox.Show(this, "Tu curso ha sido creado con éxito.", "Curso registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
