using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU
{
    public partial class registrarse : Form
    {
        private NuevoServicio servicio;

        //Variables para habilitar/deshabilitar el botón "Confirmar"
        private Boolean emailCorrecto = false;
        private Boolean nombreCorrecto = false;
        private Boolean contraCorrecto = false;
        private Boolean apellidoCorrecto = false;
        private Boolean tipoCorrecto = false;

        public registrarse(NuevoServicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void registrarse_Load(object sender, EventArgs e)
        {

        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            registeredUser();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string email = emailBox.Texts;
            if (email == "") emailCorrecto = false;
            else emailCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string nombre = nombreBox.Texts;
            if (nombre == "") nombreCorrecto = false;
            else nombreCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        private void apellidosBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string apellidos = apellidosBox.Texts;
            if (apellidos == "") apellidoCorrecto = false;
            else apellidoCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;

        }

        private void contraBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string contra = contraBox.Texts;
            if (contra == "") contraCorrecto = false;
            else contraCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        public void registeredUser()
        {
            string nombre = nombreBox.Texts;
            string apellidos = apellidosBox.Texts;
            string email = emailBox.Texts;
            string contra = contraBox.Texts;
            string tipoUser = tipoUsuario.Text;

            if (tipoUser.Equals("Profesor")) {
                try { servicio.AddProfesor(new Profesor(email, contra, nombre, apellidos)); }
                catch (Exception ex) { 
                    DialogResult answer = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    return; 
                }
            } else {
                try { servicio.AddAlumno(new Alumno(email, contra, nombre, apellidos)); }
                catch (Exception ex) { DialogResult answer = MessageBox.Show(this, ex.Message.ToString(), 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return; }
            }

            DialogResult confirmar = MessageBox.Show(this, "Tu cuenta ha sido registrada con éxito.", "Cuenta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (confirmar == DialogResult.OK) this.Close();
        }

        private void tipoUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tipoUsuario.Text == "") bConfirmar.Enabled = false;
            else tipoCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        private void bConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                registeredUser();
            }
        }

        
    }
}
