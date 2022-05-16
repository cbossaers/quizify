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
        

        //Variables para habilitar/deshabilitar el botón "Crear"
        private Boolean nombreCorrecto = false;
        private Boolean codCorrecto = false;
        private Boolean maxCorrecto = false;
        private Boolean contraCorrecto = false;

        public CrearCurso(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            bCrearCurso.Enabled = false;
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            registrarCurso();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CursoForm(servicio, usuario));
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
            } catch (Exception ex) { DialogResult avisoCursoRepe = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        }

        private void nombreCursoBox_TextChanged(object sender, EventArgs e)
        {
            bCrearCurso.Enabled = false;
            string nombre = nombreCursoBox.Text;
            if (nombre == "") nombreCorrecto = false;
            else nombreCorrecto = true;
            if (nombreCorrecto && codCorrecto && maxCorrecto && contraCorrecto)
                bCrearCurso.Enabled = true;
        }

        private void codCursoBox_TextChanged(object sender, EventArgs e)
        {
            bCrearCurso.Enabled = false;
            string codigo = codCursoBox.Text;
            if (codigo == "") codCorrecto = false;
            else codCorrecto = true;
            if (nombreCorrecto && codCorrecto && maxCorrecto && contraCorrecto)
                bCrearCurso.Enabled = true;
        }

        private void boxContraseña_TextChanged(object sender, EventArgs e)
        {
            bCrearCurso.Enabled = false;
            string contra = boxContraseña.Text;
            if (contra == "") codCorrecto = false;
            else contraCorrecto = true;
            if (nombreCorrecto && codCorrecto && maxCorrecto && contraCorrecto)
                bCrearCurso.Enabled = true; 
        }

        private void maxAlumnos_ValueChanged(object sender, EventArgs e)
        {
            bCrearCurso.Enabled = false;
            int valor = (int)maxAlumnos.Value;
            if (valor <= 0) maxCorrecto = false;
            else maxCorrecto = true;
            if (nombreCorrecto && codCorrecto && maxCorrecto && contraCorrecto)
                bCrearCurso.Enabled = true;
        }
    }
}
