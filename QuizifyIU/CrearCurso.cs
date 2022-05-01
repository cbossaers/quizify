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
        private NuevoServicio servicio;
        private dynamic usuario;
        public CrearCurso(NuevoServicio servicio, dynamic user)
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
            string autor = usuario.GetCorreo();
            int numMaxAl = (int)maxAlumnos.Value;
            string contraseña = boxContraseña.Text;

            try {
                Curso newCurso = new Curso(codigo, nombre, autor, 0, numMaxAl, DateTime.Now, contraseña, new List<string>());

                servicio.AddCurso(newCurso);

                DialogResult confirmar = MessageBox.Show(this, "Tu curso ha sido creado con éxito.", "Curso registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) { DialogResult avisoCursoRepe = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
