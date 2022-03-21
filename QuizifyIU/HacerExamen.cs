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
    public partial class HacerExamen : Form
    {
        private Servicio servicio;
        private int id;
        private Portal control;
        
        private dynamic usuario;

        public HacerExamen(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            //Examen exam = servicio.GetExamenById(id);
            //descripcion.Text = exam.GetDescripcion().ToString();
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)  empezar.Enabled = true; 
            if (!checkBox1.Checked) empezar.Enabled = false; 
        }

        private void empezar_Click(object sender, EventArgs e)
        {
            using (HacerExamen2 ventanaAlta = new HacerExamen2(servicio,usuario))
                ventanaAlta.ShowDialog();
            /*control.GetContainerControl()

            control.Controls.RemoveAt(0);
            Form fHE = new HacerExamen(servicio, control) as Form;
            fHE.TopLevel = false;
            fHE.Dock = DockStyle.Fill;
            control.Controls.Add(fHE);
            //this.panelContenedor.Tag = fHE;
            fHE.Show();*/
        }
    }
}
