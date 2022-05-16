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
        private NuevoServicio servicio;
        private dynamic usuario;
        private Boolean nombreCorrecto = false;
        private Boolean codCorrecto = false;
        private Boolean contraCorrecto = false;
        public ApuntarseCurso(NuevoServicio servicio, dynamic user)
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
            try
            {
                string alumno = usuario.correo;
                string codigo = codBox.Text;
                string contra = contraBox.Text;
                string profe = correoProfeBox.Text;
                Curso cursoApuntado = servicio.GetCurso(codigo, profe);
                if (cursoApuntado.GetContraseña() == contra)
                {
                    servicio.AddAlumnoACurso(alumno, codigo, profe);
                    DialogResult apuntadoCorrecto = MessageBox.Show(this, "Has sido apuntado correctamente al curso con código " + codigo + ".", "Alumno apuntado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (apuntadoCorrecto == DialogResult.OK) Principal.formportal.abrirNieto(new CursoForm(servicio, usuario));
                }
                else
                {
                    DialogResult avisoContraInc = MessageBox.Show(this, "La contraseña introducida es incorrecta.", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { DialogResult avisoNoExist = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return; }
        }

        private void codBox_TextChanged(object sender, EventArgs e)
        {
            bApuntarse.Enabled = false;
            string codigo = codBox.Text;
            if (codigo == "") codCorrecto = false;
            else codCorrecto = true;
            if (nombreCorrecto && codCorrecto && contraCorrecto)
                bApuntarse.Enabled = true;
        }

        private void correoProfeBox_TextChanged(object sender, EventArgs e)
        {
            bApuntarse.Enabled = false;
            string profe = correoProfeBox.Text;
            if (profe == "") codCorrecto = false;
            else codCorrecto = true;
            if (nombreCorrecto && codCorrecto && contraCorrecto)
                bApuntarse.Enabled = true;
        }

        private void contraBox_TextChanged(object sender, EventArgs e)
        {
            bApuntarse.Enabled = false;
            string contra = contraBox.Text;
            if (contra == "") codCorrecto = false;
            else codCorrecto = true;
            if (nombreCorrecto && codCorrecto && contraCorrecto)
                bApuntarse.Enabled = true;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CursoForm(servicio, usuario));
        }
    }
}
