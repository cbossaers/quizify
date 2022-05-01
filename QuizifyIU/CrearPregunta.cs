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
        private bool crearquiz = false;
        private FabricaPreguntas fabrica = new FabricaPreguntas();
        private List<dynamic> lista = new List<dynamic> { };
        /*private PreguntaTest preguntaTest;
        private PreguntaVF preguntaVF;
        private PreguntaDesarrollo preguntaDesarrollo;
        private PreguntaMultiple preguntaMultiple;*/
        private Pregunta2 pregunta;
        private int dificultadNum;
        private int id = -1;

        Examen examen;
        dynamic usuario;
        bool mispreguntas = false;
        
        public CrearPregunta(NuevoServicio servicio,dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = usuario;
            crearquiz = false;
        }
        public CrearPregunta(NuevoServicio servicio, dynamic usuario,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.examen = examen;
            this.crearquiz= true;
            this.usuario = usuario;
        }
        public CrearPregunta(NuevoServicio servicio, dynamic usuario,int id, int version, string tipo)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = usuario;
            mispreguntas = true;
            editar(id,version,tipo); 
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
            if(id == -1)
            {
                int id = servicio.UltimoIdPregunta() + 1;
            }
            if (enunciado.Text == "")
            {
                MessageBox.Show(this, "No se ha introducido un enunciado", "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            else if (opcionCorrecta == "")
            {
                MessageBox.Show(this, "No se ha seleccionado una opción correcta", "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                return;
            }
            if(tipoPregunta.Text == "Desarrollo")
            {
                if (ctPregunta.Text == "Competencia Transversal") ctPregunta.Text = "";
                pregunta = fabrica.CrearPregunta2(id, servicio.UltimaVersionPregunta(id)+1,
                    enunciado.Text,"des", dificultadNum, usuario.GetCorreo(), tema.Text, ctPregunta.Text, lista);
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
                if (ComprobarOpcionesRellenadas(numeroDeOpciones) == false)
                {
                    return;
                }
                else
                {
                    lista.Add(Convert.ToInt32(opcionCorrecta));
                    lista.Add(opc0.Text); lista.Add(opc1.Text); lista.Add(opc2.Text);
                    if (numeroDeOpciones == 4) lista.Add(opc3.Text);
                    if (numeroDeOpciones == 5) lista.Add(opc4.Text);
                }
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
                lista.Add(Convert.ToInt32(opcionCorrecta));
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
            id = -1;
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
            RespuestaTxt.Visible = true; RespuestaTxt.Text = "";
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            botonAdd.Visible = false; botonBorrar.Visible = false; botonAdd2.Visible = false; botonBorrar2.Visible = false;
            correctaTest.Visible = false; correctaVF.Visible = false; CorrectaMult.Visible = false;
            lista.Clear();
        }
        public void VistaMultiple()
        {
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
                listaOpCorrecta[Convert.ToInt32(numero)] = "1";
                CraftearStringCorrecta(listaOpCorrecta);
            }
            else
            {
                listaOpCorrecta[Convert.ToInt32(numero)] = "0";
                CraftearStringCorrecta(listaOpCorrecta);
            }
            
            
        }

        private void editar(int id,int version,string tipo)
        {
            crear.Enabled = true;

            if (tipo == "test")
            {
                VistaTest();
                tipoPregunta.Text = "Test";
                PreguntaTest preg = servicio.GetPreguntaTestById(id,version);
                opcionCorrecta = preg.GetCorrecta().ToString();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                enunciado.Text = preg.GetEnunciado();
                int dificul = preg.GetDificultad();
                int correc = preg.GetCorrecta();

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

                opc0.Text = preg.GetOpcA();
                opc1.Text = preg.GetOpcB();
                opc2.Text = preg.GetOpcC();

                if (preg.GetOpcD() != "")
                 {
                   opc3.Text = preg.GetOpcD();
                   opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;
                    numeroDeOpciones++;
                    if (preg.GetOpcE() != "")
                    {
                       opc4.Text = preg.GetOpcD();
                        opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;
                        numeroDeOpciones++;
                    }
                }
            }
            else if (tipo == "vf")
            {
                tipoPregunta.Text = "VF";
                VistaVF();
                PreguntaVF preg = servicio.GetPreguntaVFById(id, version);
                opcionCorrecta = preg.GetCorrecta().ToString();
                enunciado.Text = preg.GetEnunciado();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                int dificul = preg.GetDificultad();
                int correc = preg.GetCorrecta();
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
            else if (tipo == "multiple")
            {
                VistaMultiple();
                tipoPregunta.Text = "Selección Multiple";
                PreguntaTest preg = servicio.GetPreguntaTestById(id, version);
                opcionCorrecta = preg.GetCorrecta().ToString();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
                enunciado.Text = preg.GetEnunciado();
                int dificul = preg.GetDificultad();
                int correc = preg.GetCorrecta();
                switch (dificul)
                {
                    case (0): dificultad.Text = "Fácil"; break;
                    case (1): dificultad.Text = "Normal"; break;
                    case (2): dificultad.Text = "Difícil"; break;
                }
                int cont = 0;
                while(correc>0){
                    if(correc % 10 == 1)
                    {
                        switch (cont)
                        {
                            case (0): check0.Checked = true; break;
                            case (1): check0.Checked = true; break;
                            case (2): check0.Checked = true; break;
                            case (3): check0.Checked = true; break;
                            case (4): check0.Checked = true; break;
                        }
                    }
                    correc = correc / 10;
                    cont++;
                }

                opc0.Text = preg.GetOpcA();
                opc1.Text = preg.GetOpcB();
                opc2.Text = preg.GetOpcC();

                if (preg.GetOpcD() != "")
                {
                    opc3.Text = preg.GetOpcD();
                    opc3.Visible = true; letraD.Visible = true; check3.Visible = true;
                    numeroDeOpciones++;
                    if (preg.GetOpcE() != "")
                    {
                        opc4.Text = preg.GetOpcD();
                        opc4.Visible = true; letraE.Visible = true; check4.Visible = true; 
                        numeroDeOpciones++;
                    }
                }
            }
            else if(tipo == "desarrollo")
            {
                VistaDesarrollo();
                PreguntaTest preg = servicio.GetPreguntaTestById(id, version);
                ctPregunta.Text = preg.GetCT();
                opcionCorrecta = preg.GetCorrecta().ToString();
                tema.Text = preg.GetTema();
                ctPregunta.Text = preg.GetCT();
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
