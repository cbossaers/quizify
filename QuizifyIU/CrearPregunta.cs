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
        private NuevoServicio servicio;
        private string opcionCorrecta;
        private List<string> listaOpCorrecta = new List<String> {"0", "0", "0", "0", "0"};
        private int numeroDeOpciones = 3;
        private bool cambioDificultad = false;
        private bool cambioTipoPregunta = false;
        private FabricaPreguntas fabrica = new FabricaPreguntas();
        private List<dynamic> lista = new List<dynamic> { };
        /*private PreguntaTest preguntaTest;
        private PreguntaVF preguntaVF;
        private PreguntaDesarrollo preguntaDesarrollo;
        private PreguntaMultiple preguntaMultiple;*/
        private Pregunta2 pregunta;
        private int dificultadNum;
        private int id;
        Examen examen;
        dynamic usuario;
        bool Editar = false;
        
        public CrearPregunta(NuevoServicio servicio,dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = usuario;
            RellenarCursos();
        }
        public CrearPregunta(NuevoServicio servicio, dynamic usuario,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;            
            this.usuario = usuario;
            RellenarCursos();
        }
        public CrearPregunta(NuevoServicio servicio, dynamic usuario, Pregunta2 pregunta)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = usuario;
            RellenarCursos();
            editar(pregunta); 
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
                if (correcta4.Checked == true) opcionCorrecta = null; correcta4.Checked = false;
            }
            else if (opc3.Visible == true)
            {
                opc3.Visible = false; letraD.Visible = false; correcta3.Visible = false;
                numeroDeOpciones--;
                if (correcta3.Checked == true) opcionCorrecta = null; correcta3.Checked = false;
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

        private void BorrarOpc2(object sender, EventArgs e)
        {
            if (check4.Visible == true)
            {
                opc4.Visible = false; letraE.Visible = false; check4.Visible = false;
                numeroDeOpciones--;
                if (check4.Checked == true) listaOpCorrecta[4] = "0"; check4.Checked = false;
            }
            else if (check3.Visible == true)
            {
                opc3.Visible = false; letraD.Visible = false; check3.Visible = false;
                numeroDeOpciones--;
                if (check3.Checked == true) listaOpCorrecta[3] = "0"; check3.Checked = false;
            }
        }

        private void AddOpc2(object sender, EventArgs e)
        {
            if (opc3.Visible != true)
            {
                opc3.Visible = true; letraD.Visible = true; check3.Visible = true;
                numeroDeOpciones++;
            }
            else if (opc4.Visible != true)
            {
                opc4.Visible = true; letraE.Visible = true; check4.Visible = true;
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
            if(Editar == false)
            {
               id = servicio.UltimoIdPregunta() + 1;
            }
            if (enunciado.Text == "")
            {
                MessageBox.Show(this, "No se ha introducido un enunciado", "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            if(tipoPregunta.Text == "Desarrollo")
            {
                List<dynamic> listaDes = new List<dynamic>();
                if (ctPregunta.Text == "Competencia Transversal") ctPregunta.Text = "";
                pregunta = fabrica.CrearPregunta2(id, servicio.UltimaVersionPregunta(id)+1,
                    enunciado.Text,"des", dificultadNum, usuario.GetCorreo(), tema.Text, ctPregunta.Text, listaDes);
                try { servicio.AddPregunta(pregunta); }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString(), "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    return;
                }
                

                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                VistaDesarrollo();
            }
            else if (tipoPregunta.Text == "Test")
            {
                if (opcionCorrecta == "")
                {
                    MessageBox.Show(this, "No se ha seleccionado una opción correcta", "Error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                    return;
                }
                if (ComprobarOpcionesRellenadas(numeroDeOpciones) == false){
                    return;
                }
                else
                {
                    lista.Add(opcionCorrecta);
                    lista.Add(opc0.Text); lista.Add(opc1.Text); lista.Add(opc2.Text);
                    if (numeroDeOpciones == 4) lista.Add(opc3.Text);
                    if (numeroDeOpciones == 5) lista.Add(opc4.Text);
                }
                if (ctPregunta.Text == "Competencia Transversal") ctPregunta.Text = "";
                pregunta = fabrica.CrearPregunta2(id, servicio.UltimaVersionPregunta(id) + 1,
                    enunciado.Text, "test",dificultadNum, usuario.GetCorreo() , tema.Text, ctPregunta.Text, lista);
                try { servicio.AddPregunta(pregunta); }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString(), "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                
                VistaTest();
            }
            else if (tipoPregunta.Text == "Selección Múltiple")
            {
                    CraftearStringCorrecta(listaOpCorrecta);
                    lista.Add(int.Parse(opcionCorrecta));
                    lista.Add(opc0.Text); lista.Add(opc1.Text); lista.Add(opc2.Text);
                    if (numeroDeOpciones == 4) lista.Add(opc3.Text);
                    if (numeroDeOpciones == 5) lista.Add(opc4.Text);
                
                if (ctPregunta.Text == "Competencia Transversal") ctPregunta.Text = "";
                pregunta = fabrica.CrearPregunta2(id, servicio.UltimaVersionPregunta(id) + 1,
                    enunciado.Text, "mult", dificultadNum, usuario.GetCorreo(), tema.Text, ctPregunta.Text, lista);
                try { servicio.AddPregunta(pregunta); }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString(), "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                VistaMultiple();
            }
            else
            {
                lista.Add(int.Parse(opcionCorrecta));
                if (ctPregunta.Text == "Competencia Transversal") ctPregunta.Text = "";
                pregunta = fabrica.CrearPregunta2(id, servicio.UltimaVersionPregunta(id) + 1,
                    enunciado.Text,"vf", dificultadNum, usuario.GetCorreo() , tema.Text, ctPregunta.Text, lista);
                try { servicio.AddPregunta(pregunta); }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString(), "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Se ha creado la pregunta de forma exitosa", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                
                VistaVF();
            }
            if (id <= servicio.UltimoIdPregunta()) { 
                //cerrar
            }
            Editar = false;
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
        public void VistaVF()
        {
            tipoPregunta.Text = "Verdadero Falso";
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            verdadero0.Checked = false; falso1.Checked = false;
            correctaTest.Visible = false; correctaVF.Visible = true; CorrectaMult.Visible = false;
            botonAdd.Visible = false; botonBorrar.Visible = false; botonAdd2.Visible = false; botonBorrar2.Visible = false;
            RespuestaTxt.Visible = false;
            lista.Clear();
        }
        public void VistaTest()
        {
            tipoPregunta.Text = "Test";
            numeroDeOpciones = 3;
            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = true; opc1.Visible = true; opc2.Visible = true; opc3.Visible = false; opc4.Visible = false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            correcta0.Visible = true; correcta1.Visible = true; correcta2.Visible = true; correcta3.Visible = false; correcta4.Visible = false;
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            correctaTest.Visible = true; correctaVF.Visible = false; CorrectaMult.Visible = false;
            botonAdd.Visible = true; botonBorrar.Visible = true; botonAdd2.Visible = false; botonBorrar2.Visible = false;
            RespuestaTxt.Visible = false;
            opcionCorrecta = "";
            lista.Clear();
        }
        public void VistaDesarrollo()
        {
            tipoPregunta.Text = "Desarrollo";
            RespuestaTxt.Visible = true; RespuestaTxt.Text = "";
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            botonAdd.Visible = false; botonBorrar.Visible = false; botonAdd2.Visible = false; botonBorrar2.Visible = false;
            correctaTest.Visible = false; correctaVF.Visible = false; CorrectaMult.Visible = false;
            lista.Clear();
        }
        public void VistaMultiple()
        {
            tipoPregunta.Text = "Selección Múltiple";
            numeroDeOpciones = 3;
            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = true; opc1.Visible = true; opc2.Visible = true; opc3.Visible = false; opc4.Visible=false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            check0.Visible = true; check1.Visible = true; check2.Visible = true; check3.Visible = false; check4.Visible = false;
            check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            correctaTest.Visible = false; correctaVF.Visible = false; CorrectaMult.Visible = true;
            botonAdd.Visible = false; botonBorrar.Visible = false; botonAdd2.Visible = true; botonBorrar2.Visible = true;
            RespuestaTxt.Visible = false; 
            opcionCorrecta = "";
            for(int i = 0; i < 5; i++) { listaOpCorrecta[i] = "0"; }
            lista.Clear();
        }
        public void CraftearStringCorrecta(List<string> listilla)
        {
            opcionCorrecta = "";
            for (int i = 0; i < 5; i++)
            {
                opcionCorrecta = opcionCorrecta + listilla[i];
            }
        }

        private void EvMarcarCorrectaM(object sender, EventArgs e)
        {
            //TF: 0 True 1 False, Test: 0A 1B 2C 3D 4E
            CheckBox checkBox = (CheckBox)sender;
            String numero = checkBox.Name.Last().ToString();
            if(checkBox.Checked == true)
            {
                listaOpCorrecta[int.Parse(numero)] = "1";
            }
            else
            {
                listaOpCorrecta[int.Parse(numero)] = "0";
            }
            
            
        }
        private void RellenarCursos()
        {
            List<string> curso = servicio.GetCursosProfesor(usuario.GetCorreo());
            for(int i = 0; i < curso.Count; i++)
            {
                tema.Items.Add(curso[i]);
            }
        }
        private void editar(Pregunta2 preg)
        {
            Editar = true;
            id = preg.GetId();
            crear.Enabled = true;
            string tipo = preg.GetTipo();
            if (tipo == "test")
            {
                VistaTest();
                lista = preg.GetParametros();
                opcionCorrecta = lista[0].ToString();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                enunciado.Text = preg.GetEnunciado();
                int dificul = preg.GetDificultad();
                int correc = lista[0];

                switch (dificul)
                {
                    case (0): dificultad.Text = "Fácil"; break;
                    case (1): dificultad.Text = "Normal"; break;
                    case (2): dificultad.Text = "Difícil"; break;
                }
                switch (correc)  
                {
                    case (0): correcta0.Checked = true; break;
                    case (1): correcta1.Checked = true; break;
                    case (2): correcta2.Checked = true; break;
                    case (3): correcta3.Checked = true; break;
                    case (4): correcta4.Checked = true; break;
                }

                opc0.Text = lista[1];
                opc1.Text = lista[2];
                opc2.Text = lista[3];

                if (lista.Count>4)
                 {
                   opc3.Text = lista[4];
                    opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;
                    numeroDeOpciones++;
                    if (lista.Count > 5)
                    {
                       opc4.Text = lista[5];
                        opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;
                        numeroDeOpciones++;
                    }
                }
            }
            else if (tipo == "vf")
            {
                VistaVF();
                List<dynamic> lista = preg.GetParametros();
                opcionCorrecta = lista[0].ToString();
                enunciado.Text = preg.GetEnunciado();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                int dificul = preg.GetDificultad();
                int correc = lista[0];
                switch (dificul)
                {
                    case (0): dificultad.Text = "Fácil"; break;
                    case (1): dificultad.Text = "Normal"; break;
                    case (2): dificultad.Text = "Difícil"; break;
                }
                
                switch (correc)
                {
                    case (0): verdadero0.Checked = true; break;
                    case (1): falso1.Checked = true; break;
                }
            }
            else if (tipo == "mult")
            {
                VistaMultiple();
                
                List<dynamic> lista = preg.GetParametros();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                enunciado.Text = preg.GetEnunciado();
                int dificul = preg.GetDificultad();
                int correc = lista[0];
                switch (dificul)
                {
                    case (0): dificultad.Text = "Fácil"; break;
                    case (1): dificultad.Text = "Normal"; break;
                    case (2): dificultad.Text = "Difícil"; break;
                }
                int x = lista[0];
                for(int i = 4; i >= 0; i--)
                {
                    listaOpCorrecta[i] =(x%10).ToString();
                    x/=10;
                }
                for (int i = 0; i < 5; i++)
                {
                    int aux = int.Parse(listaOpCorrecta[i]);
                    if (aux == 1) {
                        switch (i)
                        {
                            case (0): check0.Checked = true; break;
                            case (1): check1.Checked = true; break;
                            case (2): check2.Checked = true; break;
                            case (3): check3.Checked = true; break;
                            case (4): check4.Checked = true; break;
                        }
                    }
                }

                opc0.Text = lista[1];
                opc1.Text = lista[2];
                opc2.Text = lista[3];

                if (lista.Count > 4)
                {
                    opc3.Text = lista[4];
                    opc3.Visible = true; letraD.Visible = true; check3.Visible = true;
                    numeroDeOpciones++;
                    if (lista.Count > 5)
                    {
                        opc4.Text = lista[5];
                        opc4.Visible = true; letraE.Visible = true; check4.Visible = true; 
                        numeroDeOpciones++;
                    }
                }
            }
            else if(tipo == "des")
            {
                VistaDesarrollo();
                ctPregunta.Text = preg.GetCT();
                tema.Text = preg.GetTema();
                enunciado.Text = preg.GetEnunciado();
                int dificul = preg.GetDificultad();
                switch (dificul)
                {
                    case (0): dificultad.Text = "Fácil"; break;
                    case (1): dificultad.Text = "Normal"; break;
                    case (2): dificultad.Text = "Difícil"; break;
                }
            }
        }
    }
}
