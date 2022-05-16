﻿using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizifyIU;

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
            

            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                bGestionarCurso.Enabled = false;
                bCrearCurso.Enabled = false;
            }
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearCurso(servicio, usuario));
        }

        private void bGestionarCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new GestionarCurso(servicio, usuario));
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new ApuntarseCurso(servicio, usuario));
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
            fCC.BringToFront();
            fCC.Show();
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
            fGC.BringToFront();
            fGC.Show();
        }
    }
}
