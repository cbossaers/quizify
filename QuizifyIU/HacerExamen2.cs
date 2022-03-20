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
        int id= 0,cont =0;
        private Servicio servicio;
        List<int> preguntas_asociadas = new List<int>();
        List<int> respuestas = new List<int>();
        Pregunta pregunta;
        int op_correcta = 0;
        
        public HacerExamen2(Servicio servicio)
        {
            InitializeComponent();
            //Examen examen = servicio.GetExamenById(id);
            //preguntas_asociadas = examen.preguntas_asociadas; 
            this.servicio = servicio;
            interfaz();
            
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
            cont=-3;
            interfaz();
        }

        private void siguiete_Click(object sender, EventArgs e)
        {
            correct();
            guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
            cont += 3;
            interfaz();
            
        }

        private void interfaz()
        {
            //pregunta = servicio.GetPreguntaById(preguntas_asociadas[cont], preguntas_asociadas[cont+1]);
            
            if (servicio.GetTipoPregunta(cont) == "test")
            {
                PreguntaTest preg = servicio.GetPreguntaById(preguntas_asociadas[cont], preguntas_asociadas[cont + 1]);
                //PreguntaTest preg = servicio.GetPreguntaTestById(1,1);
                enunciado.Text = preg.GetEnunciado().ToString();
                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
                visible(preg);
                correctaVF.Visible = false;

                
            }
            else
            {
                opc0.Visible = false; letraA.Visible = false; correcta0.Visible = false;
                opc1.Visible = false; letraB.Visible = false; correcta1.Visible = false;
                opc2.Visible = false; letraC.Visible = false; correcta2.Visible = false;
                opc3.Visible = false; letraD.Visible = false; correcta3.Visible = false;
                opc4.Visible = false; letraE.Visible = false; correcta4.Visible = false;
                opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
                correctaVF.Visible = true;

            }



        }
        private void visible(PreguntaTest preg)
        {
            if (preg.GetOpcA() != "")
            {
                opc0.Text=preg.GetOpcA().ToString();
                opc0.Visible = true; letraA.Visible = true; correcta0.Visible = true;

                if (preg.GetOpcB() != "")
                {
                    opc1.Text = preg.GetOpcB().ToString();
                    opc1.Visible = true; letraB.Visible = true; correcta1.Visible = true;

                    if (preg.GetOpcC() != "")
                    {
                        opc2.Text = preg.GetOpcC().ToString();
                        opc2.Visible = true; letraC.Visible = true; correcta2.Visible = true;

                        if (preg.GetOpcD() != "")
                        {
                            opc3.Text = preg.GetOpcD().ToString();
                            opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;

                            if (preg.GetOpcE() != "")
                            {
                                opc4.Text = preg.GetOpcE().ToString();
                                opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;

                            }else { opc4.Visible = false; letraE.Visible = false; correcta4.Visible = false; }
                        }
                        else { opc3.Visible = false; letraD.Visible = false; correcta3.Visible = false; }

                    }
                    else { opc2.Visible = false; letraC.Visible = false; correcta2.Visible = false; }

                }
                else { opc1.Visible = false; letraB.Visible = false; correcta1.Visible = false; }

            }
            else { opc0.Visible = false; letraA.Visible = false; correcta0.Visible = false; }

            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;



        }
        private void guardar(int id, int version, int correcta)
        {
            respuestas.Add(id);
            respuestas.Add(version);
            respuestas.Add(correcta);
        }

        private void borrar_seleccion_Click(object sender, EventArgs e)
        {
            op_correcta = 0;
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
        }

        private void correct()
        {
            if (correcta0.Checked) { op_correcta = 1; }
            else {
                if (correcta1.Checked) { op_correcta = 2; }
                else {
                    if (correcta2.Checked) { op_correcta = 3; }
                    else {
                        if (correcta3.Checked) { op_correcta = 4; }
                        else {
                            if (correcta4.Checked) { op_correcta = 5; }
                            else
                            {
                                op_correcta = 0;
                            }
                        }
                    }
                }
            }

        }
        
    }
}
