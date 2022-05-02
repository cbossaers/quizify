﻿using System;
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
    public partial class Portal : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        private Portal control;
        

        public Portal(NuevoServicio servicio, Portal control, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            nombreIniciado.Text = user.nombre;
            usuario = user;
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno") { bMisPreguntas.Visible = false; bCrearQuiz.Visible = false; bCrearPregunta.Visible = false; }

        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormCrearPregunta(object formCrearPregunta)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fCP = formCrearPregunta as Form;
            fCP.TopLevel = false;
            fCP.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fCP);
            this.panelContenedor.Tag = fCP;
            fCP.Show();
        }
        private void AbrirFormCrearQuiz(object formCrearQuiz)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fCQ = formCrearQuiz as Form;
            fCQ.TopLevel = false;
            fCQ.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fCQ);
            this.panelContenedor.Tag = fCQ;
            fCQ.Show();
        }
        private void AbrirFormMisPreguntas(object formMisPreguntas)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fMP = formMisPreguntas as Form;
            fMP.TopLevel = false;
            fMP.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fMP);
            this.panelContenedor.Tag = fMP;
            fMP.Show();
        }
        private void AbrirFormMisExamenes(object formMisExamenes)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fME = formMisExamenes as Form;
            fME.TopLevel = false;
            fME.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fME);
            this.panelContenedor.Tag = fME;
            fME.Show();
        }
        private void AbrirFormHacerExamen(object formHacerExamen)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fHE = formHacerExamen as Form;
            fHE.TopLevel = false;
            fHE.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fHE);
            this.panelContenedor.Tag = fHE;
            fHE.Show();
        }

        private void AbrirFormCurso(object formCurso)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fC = formCurso as Form;
            fC.TopLevel = false;
            fC.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fC);
            this.panelContenedor.Tag = fC;
            fC.Show();
        }

        private void bCrearPregunta_Click(object sender, EventArgs e)
        {
            AbrirFormCrearPregunta(new CrearPregunta(servicio,usuario));
        }

        private void bCrearQuiz_Click(object sender, EventArgs e)
        {
            AbrirFormCrearQuiz(new CrearQuiz(servicio,usuario));
        }

        private void bMisPreguntas_Click(object sender, EventArgs e)
        {
            AbrirFormMisPreguntas(new MisPreguntas(servicio,usuario, this));
        }

        private void bMisExamenes_Click(object sender, EventArgs e)
        {
            AbrirFormMisExamenes(new MisExamenes(servicio,usuario));
        }

        /*private void bHacerExamen_Click(object sender, EventArgs e)
        {
            AbrirFormHacerExamen(new HacerExamen(servicio,usuario));
            /*using (HacerExamen2 ventanaAlta = new HacerExamen2(servicio))
                ventanaAlta.ShowDialog();
        }*/

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Principal(servicio);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void bAjustes_Click(object sender, EventArgs e)
        {
            DialogResult tobecontinued = MessageBox.Show(this, "Próximamente",
                                                            "", MessageBoxButtons.OK);
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            AbrirFormCurso(new CursoForm(servicio, usuario));
        }
        public void AbrirFormEditarPregunta(NuevoServicio servicio, Profesor usuario, Pregunta2 pregunta)
        {
            Object formCrearPregunta = new CrearPregunta(servicio, usuario, pregunta);
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fC = formCrearPregunta as Form;
            fC.TopLevel = false;
            fC.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fC);
            this.panelContenedor.Tag = fC;
            fC.Show();
        }
    }
}
