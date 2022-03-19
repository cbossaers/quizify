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
    public partial class HacerExamen2 : Form
    {
        int id,cont =0;
        private Servicio servicio;
        List<int> preguntas_asociadas = new List<int>();
        Pregunta pregunta;
        
        public HacerExamen2(Servicio servicio,int id)
        {
            InitializeComponent();
            Examen examen = servicio.GetExamenById(id);
            preguntas_asociadas = examen.preguntas_asociadas; 
            this.servicio = servicio;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont++;
        }

        public void interfaz()
        {
            pregunta = servicio.GetPreguntaTestById(preguntas_asociadas[cont],0);
            
            if(pregunta.GetTipo() == "Test")
            {

                letraA.Visible = true; letraB.Visible = true; letraC.Visible = true;
                opc0.Visible = true; opc1.Visible = true; opc2.Visible = true;
                correctaTest.Visible = true; correctaVF.Visible = false;
                verdadero0.Checked = false; falso1.Checked = false;
                if (preguntas_asociadas.Count >= 4)
                {
                    opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;
                }
                else if(preguntas_asociadas.Count >= 5)
                {
                    opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;
                }
            }
            else
            {
                letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
                opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
                correctaTest.Visible = false; correctaVF.Visible = true;
                correcta3.Visible = false; correcta4.Visible = false;
                opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            }
            
        }
        
        
    }
}
