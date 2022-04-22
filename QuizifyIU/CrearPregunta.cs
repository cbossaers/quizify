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
        private List<string> listaOpCorrecta = new List<String> {"0", "0", "0", "0", "0"};
        private int numeroDeOpciones = 3;
        private bool cambioDificultad = false;
        private bool cambioTipoPregunta = false;
        private bool crearquiz = false;
        private FabricaPreguntas fabrica = new FabricaPreguntas();
        private List<dynamic> lista = new List<dynamic> { };
        private PreguntaTest preguntaTest;
        private PreguntaVF preguntaVF;
        private PreguntaDesarrollo preguntaDesarrollo;
        private int dificultadNum;

        Examen examen;
        dynamic usuario;
        
        public CrearPregunta(Servicio servicio,dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = usuario;
            crearquiz = false;
        }
        public CrearPregunta(Servicio servicio, dynamic usuario,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.examen = examen;
            this.crearquiz= true;
            this.usuario = usuario;
        }

        private void CambiaTipoPregunta(object sender, EventArgs e)
        {
            cambioTipoPregunta = true;
            HabilitarCrear();
            if (tipoPregunta.Text == "Test")
            {
                VistaTest();
            }
            else if (tipoPregunta.Text == "Desarrollo")
            {
                VistaDesarrollo();
            }
            else if (tipoPregunta.Text == "Selección Múltiple")
            {
                VistaMultiple();
            }
            else
            {
                VistaVF();
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
            String numero = radioButton.Name.Last().ToString();
            opcionCorrecta = numero;
            
        }

        private void EvCrearPregunta(object sender, EventArgs e)
        {
            if (enunciado.Text == "")
            {
                MessageBox.Show(this, "No se ha introducido un enunciado", "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            else if (opcionCorrecta == null)
            {
                MessageBox.Show(this, "No se ha seleccionado una opción correcta", "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                return;
            }
            if(tipoPregunta.Text == "Desarrollo")
            {
                lista.Add(RespuestaTxt.Text);
                preguntaDesarrollo = fabrica.CrearPregunta("desarrollo", 12345, enunciado.Text, dificultadNum, usuario.GetCorreo(), "tema3", lista, 1);
                servicio.AddPreguntaDesarrollo(preguntaDesarrollo);

                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                VaciarCampos();
            }
            else if (tipoPregunta.Text == "Test")
            {
                if(ComprobarOpcionesRellenadas(numeroDeOpciones) == false){
                    return;
                }
                else
                {
                    lista.Add(opcionCorrecta);
                    lista.Add(opc0.Text); lista.Add(opc1.Text); lista.Add(opc2.Text);
                    if (numeroDeOpciones == 4) lista.Add(opc3.Text);
                    if (numeroDeOpciones == 5) lista.Add(opc4.Text);
                }
                preguntaTest = fabrica.CrearPregunta("test", 12345, enunciado.Text, dificultadNum, usuario.GetCorreo() , "tema3", lista,1);
                servicio.AddPreguntaTest(preguntaTest);
                
                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                /*if (crearquiz = true) {
                    List<int> lista = examen.GetPreguntasAsociadas();
                    lista.Add(preguntaTest.GetId());
                    lista.Add(preguntaTest.GetVersion());
                    lista.Add(1);
                    examen.SetPreguntasAsociadas(lista);

                    this.Hide();
                    var form2 = new CrearQuiz_2(servicio,usuario,examen);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }*/
                VaciarCampos();
            }
            else
            {
                preguntaVF = fabrica.CrearPregunta("vf", 120, enunciado.Text, dificultadNum, usuario.GetCorreo() , "tema1",lista, 1);
                servicio.AddPreguntaVF(preguntaVF);
                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                /*if (crearquiz = true)
                {
                    List<int> lista = examen.GetPreguntasAsociadas();
                    lista.Add(preguntaTest.GetId());
                    lista.Add(preguntaTest.GetVersion());
                    lista.Add(1);
                    examen.SetPreguntasAsociadas(lista);

                    this.Hide();
                    var form2 = new CrearQuiz_2(servicio, usuario, examen);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }*/
                VaciarCampos();
            }
        }

        private void EvCambiarDificultad(object sender, EventArgs e)
        {
            switch(dificultad.Text)
            {
                case("Fácil"): dificultadNum = 0; break;
                case ("Normal"): dificultadNum = 1; break;
                case ("Difícil"): dificultadNum = 2; break;
            }
            //lista.Add(dificultadNum);
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
        private void VaciarCampos(){
            enunciado.Text = "";
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = ""; RespuestaTxt.Text = "";
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            verdadero0.Checked = false; falso1.Checked = false;
            opcionCorrecta = null;
            lista.Clear();
            listaOpCorrecta.Clear();
        }
        public void VistaVF()
        {
            RespuestaTxt.Visible = false; RespuestaTxt.Text = "";
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            botonAdd.Visible = false; botonBorrar.Visible = false;
            correctaTest.Visible = false; correctaVF.Visible = true; CorrectaMult.Visible = false;
            check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            correcta3.Visible = false; correcta4.Visible = false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            opcionCorrecta = null;
            listaOpCorrecta.Clear();
        }
        public void VistaTest()
        {
            RespuestaTxt.Visible = false; RespuestaTxt.Text = "";
            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true;
            opc0.Visible = true; opc1.Visible = true; opc2.Visible = true;
            botonAdd.Visible = true; botonBorrar.Visible = true;
            correctaTest.Visible = true; correctaVF.Visible = false; CorrectaMult.Visible = false;
            verdadero0.Checked = false; falso1.Checked = false;
            opcionCorrecta = null;
            listaOpCorrecta.Clear();
        }
        public void VistaDesarrollo()
        {
            RespuestaTxt.Visible = true;
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            botonAdd.Visible = false; botonBorrar.Visible = false;
            correctaTest.Visible = false; correctaVF.Visible = false; CorrectaMult.Visible = false;
            check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            correcta3.Visible = false; correcta4.Visible = false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            verdadero0.Checked = false; falso1.Checked = false;
            opcionCorrecta = null;
            listaOpCorrecta.Clear();
        }
        public void VistaMultiple()
        {
            RespuestaTxt.Visible = false; RespuestaTxt.Text = "";
            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true; letraD.Visible = true; letraE.Visible = true;
            botonAdd.Visible = false; botonBorrar.Visible = false;
            correctaTest.Visible = false; correctaVF.Visible = false; CorrectaMult.Visible = true;
            verdadero0.Checked = false; falso1.Checked = false;
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            opcionCorrecta = null;
            listaOpCorrecta.Clear();
        }
        public void CraftearStringCorrecta(List<string> listilla)
        {
            for (int i = 0; i < listilla.Count; i++)
            {
                opcionCorrecta = opcionCorrecta + listilla[i];
            }
        }

        private void EvMarcarCorrectaM(object sender, EventArgs e)
        {
            //TF: 0 True 1 False, Test: 0A 1B 2C 3D 4E
            CheckBox checkBox = (CheckBox)sender;
            String numero = checkBox.Name.Last().ToString();
            opcionCorrecta = numero;
            if(checkBox.Checked == true)
            {
                listaOpCorrecta[Convert.ToInt32(numero)] = "1";
                CraftearStringCorrecta(listaOpCorrecta);
            }
            else
            {
                listaOpCorrecta[Convert.ToInt32(numero)] = "0";
                CraftearStringCorrecta(listaOpCorrecta);
            }
            
            
        }
    }
}
