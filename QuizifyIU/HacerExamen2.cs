using Quizify.Entities;
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
        private int id = 0, cont = 0;
        private NuevoServicio servicio;
        List<int> preguntas_asociadas = new List<int>();
        
        Dictionary<int, dynamic> res = new Dictionary<int, dynamic>();
        private int op_correcta = -1;

        private bool Test = false;
        private bool vf = false;
        private bool mult = false;
        private bool desarrollo = false;

        private Alumno usuario;
        int counter;
        int minutes;
        Examen examen;

        private List<string> listaOpCorrecta = new List<String> { "0", "0", "0", "0", "0" };
        private string opcionCorrecta="";

        private void guardar(int id, int version, dynamic correcta)
        {
            if (res.ContainsKey(id)) res[id] = correcta;
            else res.Add(id, correcta);

        }
        

        public HacerExamen2(NuevoServicio servicio, dynamic user, Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            this.servicio = servicio;
            preguntas_asociadas = examen.GetPreguntasAsociadas();
            this.examen = examen;
            for (int i = 0; i < preguntas_asociadas.Count; i += 3)
            {
                res.Add(preguntas_asociadas[i], -1);
            }

            if (examen.GetVolverAtras() == 0) anterior.Visible = false;
            interfaz();
            indice();
            bloquear();

            label1.Text = preguntas_asociadas[cont].ToString();
            label1.Text = preguntas_asociadas[cont + 1].ToString();
        }

        private void interfaz()
        {
            borrar_seleccion.Visible = true;
            Pregunta2 preg = servicio.GetPregunta(preguntas_asociadas[cont], preguntas_asociadas[cont + 1]);
            desarrollo = false; mult = false; vf = false; Test = false;
            CambiaTipoPregunta(preg);
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (mult) { CraftearStringCorrecta(listaOpCorrecta); op_correcta = int.Parse(opcionCorrecta); }
            if (!desarrollo) { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta); }
            else { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], RespuestaTxt.Text); }
            cont -= 3;
            interfaz();
        }

        private void siguiete_Click(object sender, EventArgs e)
        {
            if (mult) { CraftearStringCorrecta(listaOpCorrecta); op_correcta = int.Parse(opcionCorrecta); }
            if (!desarrollo) { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta); }
            else { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], RespuestaTxt.Text); }
            if (siguiente.Text == "Finalizar examen")
            {
                List<dynamic> respuestas = new List<dynamic> { };
                indice();
                respuestas.Add(examen.GetId());
                respuestas.Add(usuario.GetCorreo());
                for (int i = 0; i < preguntas_asociadas.Count; i += 3)
                {
                    respuestas.Add(preguntas_asociadas[i]);
                    respuestas.Add(preguntas_asociadas[i + 1]);
                    respuestas.Add(res[preguntas_asociadas[i]].ToString());
                }
                /*string p="";
                foreach(dynamic m in respuestas)
                {
                    p+= m.ToString();
                }
                label1.Text = p;*/
                servicio.SubirRespuestas(respuestas);

                DialogResult answer = MessageBox.Show(this, "examen añadido correctamente.",
                                                            "Exito", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information);
                Principal.formportal.abrirNieto(new MisExamenes(servicio, usuario));
            }
            else
            {
                cont += 3;
                interfaz();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mult) { CraftearStringCorrecta(listaOpCorrecta); op_correcta = int.Parse(opcionCorrecta); }
            if (!desarrollo) { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta); }
            else { guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], RespuestaTxt.Text); }
            indice();
        }

        private void borrar_seleccion_Click(object sender, EventArgs e)
        {
            verdadero0.Checked = false; falso1.Checked = false; correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            op_correcta = -1;
        }

        private void CambiaTipoPregunta(Pregunta2 preg)
        {
            indice();
            bloquear();
            Test = false; mult = false; desarrollo = false; vf = false;
            listaOpCorrecta = new List<String> { "0", "0", "0", "0", "0" };
            enunciado.Text = preg.GetEnunciado().ToString();
            op_correcta = -1;
            opcionCorrecta = "";
            if (preg.GetTipo() == "test")
            {
                VistaTest();
                Test = true;
                visible(preg);
                op_correcta = -1;
                if (res.ContainsKey(preguntas_asociadas[cont]) && res[preguntas_asociadas[cont]] != -1)
                {
                    dynamic prov;
                    res.TryGetValue(preguntas_asociadas[cont], out prov);
                    op_correcta = prov;
                    switch (op_correcta)
                    {
                        case 0:
                            correcta0.Checked = true;
                            break;
                        case 1:
                            correcta1.Checked = true;
                            break;
                        case 2:
                            correcta2.Checked = true;
                            break;
                        case 3:
                            correcta3.Checked = true;
                            break;
                        case 4:
                            correcta4.Checked = true;
                            break;
                    }
                    label1.Text = op_correcta.ToString();
                }

            }else if (preg.GetTipo() == "des")
            {
                dynamic prov;
                res.TryGetValue(preguntas_asociadas[cont], out prov);
                label1.Text = prov.ToString();
                VistaDesarrollo();
                opcionCorrecta = "";
                desarrollo = true;
                string pre = res[preguntas_asociadas[cont]].ToString();
                if (!pre.Equals("-1") && !pre.Equals(""))
                {

                    res.TryGetValue(preguntas_asociadas[cont], out prov);
                    opcionCorrecta = prov;
                    RespuestaTxt.Text = opcionCorrecta;
                }  
            }
            else if (preg.GetTipo() == "mult")
            {
                mult = true;
                VistaMultiple();
                List<dynamic> lista = preg.GetParametros();
                visible(preg);
                op_correcta = -1;
                if (res.ContainsKey(preguntas_asociadas[cont]) && res[preguntas_asociadas[cont]] != -1)
                {
                    dynamic prov;
                    res.TryGetValue(preguntas_asociadas[cont], out prov);
                    op_correcta = prov;
                    
                    int x = op_correcta;
                    for (int i = 4; i >= 0; i--)
                    {
                        listaOpCorrecta[i] = (x % 10).ToString();
                        x /= 10;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        int aux = int.Parse(listaOpCorrecta[i]);
                        if (aux == 1)
                        {
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
                }
            }
            else
            {

                VistaVF();
                op_correcta = -1;
                if (res.ContainsKey(preguntas_asociadas[cont]) && res[preguntas_asociadas[cont]] != -1)
                {
                    dynamic prov;
                    res.TryGetValue(preguntas_asociadas[cont], out prov);
                    op_correcta = prov;
                    if (op_correcta == 0) verdadero0.Checked = true;
                    else if (op_correcta == 1) falso1.Checked = true;
                    label1.Text = op_correcta.ToString();
                }
                
            }
        }
    
        public void VistaVF()
        {
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            verdadero0.Checked = false; falso1.Checked = false;
            correctaVF.Visible = true; CorrectaMult.Visible = false;
            RespuestaTxt.Visible = false;
            correcta0.Visible = false; correcta1.Visible = false; correcta2.Visible = false; correcta3.Visible = false; correcta4.Visible = false;

        }
        public void VistaTest()
        {
            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = true; opc1.Visible = true; opc2.Visible = true; opc3.Visible = false; opc4.Visible = false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            correcta0.Visible = true; correcta1.Visible = true; correcta2.Visible = true; correcta3.Visible = false; correcta4.Visible = false;
            correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            correctaVF.Visible = false; CorrectaMult.Visible = false;
            RespuestaTxt.Visible = false;
            opcionCorrecta = "";
        }
        public void VistaDesarrollo()
        {
            borrar_seleccion.Visible = false;
            RespuestaTxt.Visible = true; RespuestaTxt.Text = "";
            letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = false; opc1.Visible = false; opc2.Visible = false; opc3.Visible = false; opc4.Visible = false;
            correctaVF.Visible = false; CorrectaMult.Visible = false;
            correcta0.Visible = false; correcta1.Visible = false; correcta2.Visible = false; correcta3.Visible = false; correcta4.Visible = false;
        }
        public void VistaMultiple()
        {

            letraA.Visible = true; letraB.Visible = true; letraC.Visible = true; letraD.Visible = false; letraE.Visible = false;
            opc0.Visible = true; opc1.Visible = true; opc2.Visible = true; opc3.Visible = false; opc4.Visible = false;
            opc0.Text = ""; opc1.Text = ""; opc2.Text = ""; opc3.Text = ""; opc4.Text = "";
            check0.Visible = true; check1.Visible = true; check2.Visible = true; check3.Visible = false; check4.Visible = false;
            check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            correctaVF.Visible = false; CorrectaMult.Visible = true;
            RespuestaTxt.Visible = false;
            correcta0.Visible = false; correcta1.Visible = false; correcta2.Visible = false; correcta3.Visible = false; correcta4.Visible = false;

            opcionCorrecta = "";
            for (int i = 0; i < 5; i++) { listaOpCorrecta[i] = "0"; }
        }
        public void CraftearStringCorrecta(List<string> listilla)
        {
            opcionCorrecta = "";
            for (int i = 0; i < 5; i++)
            {
                opcionCorrecta += listilla[i];
            }
        }

        private void EvMarcarCorrectaM(object sender, EventArgs e)
        {
            //TF: 0 True 1 False, Test: 0A 1B 2C 3D 4E
            CheckBox checkBox = (CheckBox)sender;
            String numero = checkBox.Name.Last().ToString();
            if (checkBox.Checked == true)
            {
                listaOpCorrecta[int.Parse(numero)] = "1";
            }
            else
            {
                listaOpCorrecta[int.Parse(numero)] = "0";
            }
        }

        public void bloquear()
        {
            if (cont <= 0) { anterior.Enabled = false; }
            else anterior.Enabled = true; if (cont >= preguntas_asociadas.Count - 3) { siguiente.Text = "Finalizar examen"; }
            else siguiente.Text = "Siguiente";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < res.Count; i++)
            {
                if (dataGridView1.SelectedCells[0].Value.ToString().Equals("Pregunta " + (i + 1).ToString()))
                {
                    if (mult) { CraftearStringCorrecta(listaOpCorrecta); op_correcta = int.Parse(opcionCorrecta); }
                    guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
                    cont = i * 3;
                    interfaz();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Ocultar indice")
            {
                dataGridView1.Visible = false;
                button1.Text = "Mostrar indice";
            }
            else
            {
                dataGridView1.Visible = true;
                button1.Text = "Ocultar indice";
            }
        }

        private void correct(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            op_correcta = radioButton.Name.Last();
            switch (op_correcta)
            {
                case 48: op_correcta = 0; break;
                case 49: op_correcta = 1; break;
                case 50: op_correcta = 2; break;
                case 51: op_correcta = 3; break;
                case 52: op_correcta = 4; break;
            }
            label1.Text = op_correcta.ToString();

        }

        private void indice()
        {
            BindingList<object> bindinglist = new BindingList<object>();
            DataTable dt = new DataTable();

            dt.Columns.Add("Pregunta");
            dt.Columns.Add("Contestada");
            int cuen = 0;
            for (int i = 1; i <= res.Count; i++)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["Pregunta"] = "Pregunta " + i.ToString();
                string pre = res[preguntas_asociadas[cuen]].ToString();
                if (pre.Equals("-1")  && pre.Equals("00000") || !pre.Equals(""))
                {
                    _ravi["Contestada"] = "◉";
                }
                else { _ravi["Contestada"] = "○"; }
                cuen += 3;
                dt.Rows.Add(_ravi);
            }
            dataGridView1.DataSource = dt;
            if (cont != 0)
            {
                dataGridView1.Rows[cont / 3].Selected = true;
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < res.Count; i++)
            {
                if (dataGridView1.SelectedCells[0].Value.ToString().Equals("Pregunta " + (i + 1).ToString()))
                {
                    if (mult) { CraftearStringCorrecta(listaOpCorrecta); op_correcta = int.Parse(opcionCorrecta); }
                    guardar(preguntas_asociadas[cont], preguntas_asociadas[cont + 1], op_correcta);
                    cont = i * 3;
                    interfaz();

                }
            }
        }

        private void visible(Pregunta2 preg)
        {
            if (mult)
            {
                List<dynamic> lista = preg.GetParametros();
                opc0.Text = lista[1];
                opc0.Visible = true; letraA.Visible = true; check0.Visible = true;
                opc1.Text = lista[2];
                opc1.Visible = true; letraB.Visible = true; check1.Visible = true;
                opc2.Text = lista[3];
                opc2.Visible = true; letraC.Visible = true; check2.Visible = true;

                if (lista.Count > 4)
                {
                    opc3.Text = lista[4];
                    opc3.Visible = true; letraD.Visible = true; check3.Visible = true;

                    if (lista.Count > 5)
                    {
                        opc4.Text = lista[5];
                        opc4.Visible = true; letraE.Visible = true; check4.Visible = true;
                    }
                    else { opc4.Visible = false; letraE.Visible = false; listaOpCorrecta[4] = "0"; check4.Visible = false; }
                }
                else { opc3.Visible = false; letraD.Visible = false; listaOpCorrecta[3] = "0"; check3.Visible = false; }

                check0.Checked = false; check1.Checked = false; check2.Checked = false; check3.Checked = false; check4.Checked = false;
            }
            else
            {
                List<dynamic> lista = preg.GetParametros();
                opc0.Text = lista[1];
                opc0.Visible = true; letraA.Visible = true; correcta0.Visible = true;
                opc1.Text = lista[2];
                opc1.Visible = true; letraB.Visible = true; correcta1.Visible = true;
                opc2.Text = lista[3];
                opc2.Visible = true; letraC.Visible = true; correcta2.Visible = true;

                if (lista.Count > 4)
                {
                    opc3.Text = lista[4];
                    opc3.Visible = true; letraD.Visible = true; correcta3.Visible = true;

                    if (lista.Count > 5)
                    {
                        opc4.Text = lista[5];
                        opc4.Visible = true; letraE.Visible = true; correcta4.Visible = true;
                    }
                    else { opc4.Visible = false; letraE.Visible = false; listaOpCorrecta[4] = "0"; correcta4.Visible = false; }
                }
                else { opc3.Visible = false; letraD.Visible = false; listaOpCorrecta[3] = "0"; correcta3.Visible = false; }

                correcta0.Checked = false; correcta1.Checked = false; correcta2.Checked = false; correcta3.Checked = false; correcta4.Checked = false;
            }
        }
    }
}