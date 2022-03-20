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
        private Servicio servicio;

        //Variables para habilitar/deshabilitar el botón "Confirmar"
        private Boolean existeUser = false;
        private Boolean emailCorrecto = false;
        private Boolean nombreCorrecto = false;
        private Boolean contraCorrecto = false;
        private Boolean apellidoCorrecto = false;
        private Boolean tipoCorrecto = false;

        public registrarse(Servicio servicio)
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
            string email = emailBox.Text;
            if (email == "") emailCorrecto = false;
            else emailCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string nombre = nombreBox.Text;
            if (nombre == "") nombreCorrecto = false;
            else nombreCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        private void apellidosBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string apellidos = apellidosBox.Text;
            if (apellidos == "") apellidoCorrecto = false;
            else apellidoCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;

        }

        private void contraBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string contra = contraBox.Text;
            if (contra == "") contraCorrecto = false;
            else contraCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }

        public void registeredUser()
        {
            string nombre = nombreBox.Text;
            string apellidos = apellidosBox.Text;
            string email = emailBox.Text;
            string contra = contraBox.Text;
            string tipoUser = tipoUsuario.Text;

            try
            {
                if (servicio.GetEntidadById(email) != null)
                {
                    _ = MessageBox.Show(this, "El email introducido ya está registrado, por favor, introduzca otro email.", "Email ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tipoUser.Equals("Profesor"))
                    {
                        Profesor newProfesor = new Profesor(email, contra, nombre, apellidos, "Ejemplo", 100, 15);
                        servicio.AddProfesor(newProfesor);
                        DialogResult confirmar = MessageBox.Show(this, "Tu cuenta ha sido registrada con éxito.", "Cuenta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (confirmar == DialogResult.OK) this.Close();
                    }
                    else if (tipoUser.Equals("Alumno"))
                    {
                        Alumno newAlumno = new Alumno(email, contra, nombre, apellidos, "Ejemplo");
                        servicio.AddAlumno(newAlumno);
                        DialogResult confirmar = MessageBox.Show(this, "Tu cuenta ha sido registrada con éxito.", "Cuenta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (confirmar == DialogResult.OK) this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(this, "El email introducido ya está registrado, por favor, introduzca otro email.", "Email ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void tipoUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tipoUsuario.Text == "") bConfirmar.Enabled = false;
            else tipoCorrecto = true;
            if (emailCorrecto && nombreCorrecto && apellidoCorrecto && contraCorrecto && tipoCorrecto)
                bConfirmar.Enabled = true;
        }
    }
}
