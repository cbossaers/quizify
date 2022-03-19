using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quizify.Entities;
using Quizify.Services;
using System.Linq;
using System.Threading.Tasks;

namespace QuizifyIU
{
    public partial class CrearPregunta : Form
    {
        private Servicio servicio;
        private string opcionCorrecta;
        private int numeroDeOpciones = 3;
        private bool cambioDificultad = false;
        private bool cambioTipoPregunta = false;
        private Fabrica fabrica = new Fabrica();
        private List<dynamic> lista = new List<dynamic> { };
        private PreguntaTest preguntaTest;
        private PreguntaVF preguntaVF;
        private List<dynamic> listaVF = new List<dynamic> { };
        public CrearPregunta(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void CambiaTipoPregunta(object sender, EventArgs e)
        {
            cambioTipoPregunta = true;
            HabilitarCrear();
            if (tipoPregunta.Text == "Test")
            {
                letraA.Visible = true; letraB.Visible = true; letraC.Visible = true;
                opc0.Visible = true; opc1.Visible = true; opc2.Visible = true;
                botonAdd.Visible = true; botonBorrar.Visible = true;
                correctaTest.Visible = true; correctaVF.Visible = false;
                verdadero0.Checked = false; falso1.Checked = false;
                opcionCorrecta = null;
            }
            else
            {
                letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
                opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
                botonAdd.Visible = false; botonBorrar.Visible = false;
                correctaTest.Visible = false; correctaVF.Visible = true;
                correcta3.Visible = false; correcta4.Visible = false;
                opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
                opcionCorrecta = null;
            }
        }

        private void BorrarOp(object sender, EventArgs e)
        {
            if (opc4.Visible == true)
            {
                opc4.Visible = false; letraE.Visible = false; correcta4.Visible = false;
                numeroDeOpciones--;
                if (correcta4.Checked == true) opcionCorrecta = null;
            }
            else if (opc3.Visible == true)
            {
                opc3.Visible = false; letraD.Visible = false; correcta3.Visible = false;
                numeroDeOpciones--;
                if (correcta3.Checked == true) opcionCorrecta = null;
            }
        }

        private void AddOpc(object sender, EventArgs e)
        {
            if(opc3.Visible != true)
            {
                opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;
                numeroDeOpciones++;
            }
            else if(opc4.Visible != true)
            {
                opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;
                numeroDeOpciones++;
            }
            
        }

        private void MarcarCorrecta(object sender, EventArgs e)
        {
            //TF: 0 True 1 False, Test: 0A 1B 2C 3D 4E
            RadioButton radioButton = (RadioButton)sender;
            opcionCorrecta = radioButton.Name.Last().ToString();
        }

        private void EvCrearPregunta(object sender, EventArgs e)
        {
            if (enunciado.Text == "")
            {
                MessageBox.Show(this, "No se ha introducido un enunciado", "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            else if (opcionCorrecta == null)
            {
                MessageBox.Show(this, "No se ha seleccionado una opción correcta", "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
            if (tipoPregunta.Text == "Test")
            {
                if(ComprobarOpcionesRellenadas(numeroDeOpciones) == true)
                {
                    lista.Add(opc0.Text); lista.Add(opc1.Text); lista.Add(opc2.Text);
                    if (numeroDeOpciones == 4) lista.Add(opc3.Text);
                    if (numeroDeOpciones == 5) lista.Add(opc4.Text);
                }
                //id?? autor?? tema?? versión y lista al revés??
                preguntaTest = fabrica.Crear_pregunta("test", 12345, enunciado.Text, int.Parse(opcionCorrecta), "pepe", "tema3", 1,lista);
                servicio.AddPreguntaTest(preguntaTest);
            }
            else
            {
                listaVF.Add("verdadero"); listaVF.Add("falso");
                preguntaVF = fabrica.Crear_pregunta("vf", 123456, enunciado.Text, int.Parse(opcionCorrecta), "carlos", "tema1", 1,listaVF);
                servicio.AddPreguntaVF(preguntaVF);
            }
        }

        private void EvCambiarDificultad(object sender, EventArgs e)
        {
            cambioDificultad = true;
            HabilitarCrear();
        }
        private void HabilitarCrear()
        {
            if(cambioTipoPregunta == true && cambioDificultad == true)
            {
                crear.Enabled = true;
            }
        }
        private bool ComprobarOpcionesRellenadas(int numOpc)
        {
            if(numOpc >= 3)
            {
                if (opc0.Text == "" || opc1.Text == "" || opc2.Text == "") {
                    MessageBox.Show(this, "No se ha rellenado las tres primeras opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if(numOpc >= 4){
                if (opc3.Text == "")
                {
                    MessageBox.Show(this, "No se ha rellenado la opción D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if(numOpc == 5){
                if (opc4.Text == "")
                {
                    MessageBox.Show(this, "No se ha rellenado la opción E", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        
    }
}
