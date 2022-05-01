﻿using Quizify.Entities;
using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuizifyIU
{
    public partial class HacerExamen2 : Form
    {
        private int id= 0,cont =0;
        private NuevoServicio servicio;
        List<int> preguntas_asociadas = new List<int>();
        List<dynamic> respuestas = new List<dynamic>{ };
        Dictionary<int,int> res = new Dictionary<int, int>();    
        private int op_correcta = -1;
        Boolean Test = false;
        private Alumno usuario;
        int counter;
        int minutes;
        DateTime start;
        DateTime endTime;
        Stopwatch stopwatch = new Stopwatch();

        Examen examen;

        public HacerExamen2(NuevoServicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            this.servicio = servicio;
            preguntas_asociadas = examen.GetPreguntasAsociadas();
            counter = examen.tiempo;
            stopwatch.Start();
            //tiempo_barra();
            //tiempo();
            for(int i = 0; i < preguntas_asociadas.Count; i += 3)
            {
                res.Add(preguntas_asociadas[i], -1);
            }
            
            if (examen.GetVolverAtras()==0) anterior.Visible = false;
            interfaz();

            label1.Text =preguntas_asociadas[cont].ToString();
            label1.Text = preguntas_asociadas[cont+1].ToString();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            
            guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
            cont -=3;
            
            interfaz();
        }

        private void siguiete_Click(object sender, EventArgs e)
        {
            guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
            if(siguiente.Text == "Finalizar examen")
            {
                respuestas.Add(examen.GetId());//id
                respuestas.Add(usuario.GetCorreo());
                for (int i = 0; i < preguntas_asociadas.Count; i+=3) 
                {
                    respuestas.Add(preguntas_asociadas[i]);
                    respuestas.Add(preguntas_asociadas[i + 1]);
                    respuestas.Add(res[preguntas_asociadas[i]]);
                }
                servicio.SubirRespuestas(respuestas);
                DialogResult answer = MessageBox.Show(this, "examen añadido correctamente.",
                                                            "Exito", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                cont += 3;
                interfaz();
            }

            
        }

        private void interfaz()
        {
            indice();
            bloquear();
            if (servicio.GetTipoPregunta(preguntas_asociadas[cont]) == "test")
            {
                Test = true;
                PreguntaTest preg = servicio.GetPreguntaById(preguntas_asociadas[cont], preguntas_asociadas[cont + 1]);
                enunciado.Text = preg.GetEnunciado().ToString();
                visible(preg);
                op_correcta = -1;
                correctaVF.Visible = false;
                label1.Text = res.ContainsKey(preguntas_asociadas[cont]).ToString();
                
                
                if (res.ContainsKey(preguntas_asociadas[cont]) && res[preguntas_asociadas[cont]] !=-1) 
                {
                    res.TryGetValue(preguntas_asociadas[cont], out op_correcta);

                    switch (op_correcta)
                    {  
                        case 0 : correcta0.Checked = true; 
                            break;
                        case 1 : correcta1.Checked = true; 
                            break;
                        case 2 : correcta2.Checked = true; 
                            break;
                        case 3 : correcta3.Checked = true; 
                            break;
                        case 4 : correcta4.Checked = true; 
                            break;
                    }
                    
                    label1.Text = op_correcta.ToString();


                }
                else {correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false; }

            }
            else
            {
                PreguntaVF preg = servicio.GetPreguntaById(preguntas_asociadas[cont], preguntas_asociadas[cont + 1]);
                enunciado.Text = preg.GetEnunciado().ToString();
                Test =false;
                opc0.Visible = false; letraA.Visible = false; correcta0.Visible = false;
                opc1.Visible = false; letraB.Visible = false; correcta1.Visible = false;
                opc2.Visible = false; letraC.Visible = false; correcta2.Visible = false;
                opc3.Visible = false; letraD.Visible = false; correcta3.Visible = false;
                opc4.Visible = false; letraE.Visible = false; correcta4.Visible = false;
                opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
                correctaVF.Visible = true;
                verdadero0.Checked = false; falso1.Checked = false;
                op_correcta = -1;
                if (res.ContainsKey(preguntas_asociadas[cont]) && res[preguntas_asociadas[cont]] != -1)
                {
                    res.TryGetValue(preguntas_asociadas[cont], out op_correcta);
                    if (op_correcta == 0 ) verdadero0.Checked = true; 
                    else if(op_correcta == 1) falso1.Checked = true;
                    
                    label1.Text = op_correcta.ToString();
                }
              
            }

        }

        private void correct(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (Test)
            {
                op_correcta = radioButton.Name.Last();
            }
            else op_correcta = radioButton.Name.Last();
            switch (op_correcta)
            {
                case 48: op_correcta=0; break;
                case 49: op_correcta = 1; break;
                case 50: op_correcta = 2 ; break;
                case 51: op_correcta = 3; break;
                case 52: op_correcta = 4; break;
            }

            label1.Text = op_correcta.ToString();

        }

        private void borrar_seleccion_Click(object sender, EventArgs e)
        {
            
            verdadero0.Checked = false; falso1.Checked = false; correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            op_correcta = -1;
        }

        private void guardar(int id, int version, int correcta)
        { 
            if (res.ContainsKey(id)) res[id] = correcta;
            else res.Add(id, correcta);

        }

        private void visible(PreguntaTest preg)
        {
            if (preg.GetOpcA() != "")
            {
                opc0.Text = preg.GetOpcA().ToString();
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

                            }
                            else { opc4.Visible = false; letraE.Visible = false; correcta4.Visible = false; }
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

        private void HacerExamen2_Load(object sender, EventArgs e)
        {
            /* minutes = examen.tiempo; //countdown time
             start = DateTime.UtcNow; // Use UtcNow instead of Now
             endTime = start.AddMinutes(minutes); //endTime is a member, not a local variable
            //timer1.Enabled = true;*/
        }

        public void bloquear()
        {
            if (cont <= 0) { anterior.Enabled = false; }
            else anterior.Enabled = true; if (cont >= preguntas_asociadas.Count-3) { siguiente.Text = "Finalizar examen"; }
            else siguiente.Text = "Siguiente";
        }
        
        private TimeSpan tiempo()
        {
            
            string s = "24:00:00";
            string temp = examen.GetTiempo().ToString();
            if (!string.IsNullOrEmpty(temp))
                s = temp;
            TimeSpan a = TimeSpan.Parse(s);
            return a;
        }

        private void tiempoRestante_MouseMove(object sender, MouseEventArgs e)
        {
            //tiempoRestante.Text=tiempo().ToString();
            TimeSpan ts = stopwatch.Elapsed;
            TimeSpan maximo = tiempo();
            label3.Text = maximo.Subtract(ts).ToString("hh\\:mm\\:ss");
            //ts.ToString("mm\\:ss\\.ff");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = tiempo().ToString();
            TimeSpan ts = stopwatch.Elapsed;
            TimeSpan maximo = tiempo();
            label3.Text = maximo.Subtract(ts).ToString("hh\\:mm\\:ss");
            //ts.ToString("mm\\:ss\\.ff");
            if (label3.Text == "00:00:00")
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
            indice();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < res.Count; i++)
            {
                if(dataGridView1.SelectedCells[0].Value.ToString().Equals("Pregunta "+ (i+1).ToString()))
                {
                    guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
                    cont = i*3 ;
                    interfaz();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text== "Ocultar indice")
            {
                dataGridView1.Visible = false;
                button1.Text = "Mostrar indice";
            }
            else
            {
                dataGridView1.Visible = true;
            }
        }

        private void indice()
        {
            BindingList<object> bindinglist = new BindingList<object>();
            int cuen = 0;
            for (int i = 1; i <= res.Count; i++)
            {
                if (res[preguntas_asociadas[cuen]] != -1)
                {
                    bindinglist.Add(new
                    {
                        ds_pregunta = "Pregunta " + i.ToString(),
                        ds_contestada = "◉",
                    });
                }
                else
                {
                    bindinglist.Add(new
                    {
                        ds_pregunta = "Pregunta " + i.ToString(),
                        ds_contestada = "○"
                    });
                }
                cuen += 3;
            }
            dataGridView1.DataSource = bindinglist;
        }
        
    }
}
