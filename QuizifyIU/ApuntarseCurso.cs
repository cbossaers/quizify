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
    public partial class ApuntarseCurso : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public ApuntarseCurso(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            comprobarDatos();
        }

        private void comprobarDatos()
        {
            //Habría que comprobar que un alumno no está apuntado en el mismo curso 2 veces
            string alumno = usuario.correo;
            string codigo = codBox.Text;
            string contra = contraBox.Text;
            Curso cursoApuntado = servicio.GetCurso(codigo);
            string profesor = cursoApuntado.autor;
            if (servicio.ExisteCurso(codigo))
            {
                if (!contra.Equals(cursoApuntado.GetContraseña()))
                {
                    DialogResult avisoContraInc = MessageBox.Show(this, "La contraseña introducida es incorrecta.", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cursoLleno(codigo))
                {
                    DialogResult avisoCursoLLeno = MessageBox.Show(this, "El curso ya está lleni", "Curso lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    servicio.AddAlumnoACurso(alumno, codigo, profesor);
                    DialogResult apuntadoCorrecto = MessageBox.Show(this, "Has sido apuntado correctamente al curso con código " + codigo + ".", "Alumno apuntado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (apuntadoCorrecto == DialogResult.OK) this.Close();
                }
            }
            else
            {
                DialogResult avisoNoExist = MessageBox.Show(this, "El curso con el código " + codigo + " no existe.", "Curso no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool cursoLleno(string codigo)
        {
            bool lleno = false;
            Curso cursoApuntado = servicio.GetCurso(codigo);
            if (cursoApuntado.GetMaxAlumnos() == cursoApuntado.GetNumAlumnos()) lleno = true;
            return lleno;
        }
    }
}
