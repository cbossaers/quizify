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
        Examen examen;

        public HacerExamen(Servicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            this.examen = examen;
            
            rellenar();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)  empezar.Enabled = true; 
            if (!checkBox1.Checked) empezar.Enabled = false; 
        }

        private void empezar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new HacerExamen2(servicio, usuario,examen);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
            /*control.GetContainerControl()

            control.Controls.RemoveAt(0);
            Form fHE = new HacerExamen(servicio, control) as Form;
            fHE.TopLevel = false;
            fHE.Dock = DockStyle.Fill;
            control.Controls.Add(fHE);
            //this.panelContenedor.Tag = fHE;
            fHE.Show();*/
        }
        private void rellenar()
        {
            descripcion.Text = examen.GetDescripcion().ToString();
            nombre_quiz.Text = examen.GetTitulo().ToString();   
            if (examen.GetIntentos()!=null)
            {
                label3.Text = "Tiene "+ examen.GetIntentos().ToString() +" intentos";
            }
            if (examen.GetVolverAtras() == 0)
            {
                label4.Text = "No se podra volver a la pregunta anterior";
            }
            else { label4.Text = "Si se podra volver a la pregunta anterior"; }
            if (examen.GetErroresRestan() == 0)
            {
                label5.Text = "Los errores no restan";
            }
            else { label5.Text = "Los errores restan";  }
            if (examen.GetMostrarResultados() == 0)
            {
                label6.Text = "No se mostraran las soluciones al finalizar el examen";
            }else { label6.Text = "Se le mostraran las soluciones al finalizar el examen"; }
        }

    }
}
