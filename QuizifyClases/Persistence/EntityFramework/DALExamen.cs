using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using System.Data;
using System.Linq;


namespace Quizify.Persistence {

    public class DALExamen {
        static string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

        FabricaExamenes fabrica = new FabricaExamenes();
        DALPregunta dalpreg = new DALPregunta();

        public void Add(Examen ex) {

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT into PSWC.examen(id,titulo,descripcion,autor,curso,tiempo,fecha_ini,fecha_fin,intentos,"
                    + "volver_atras,errores_restan,mostrar_resultados,fecha_creac,estado,CT,dificultad) "

                    + "VALUES(@id,@titulo,@descripcion,@autor,@curso,@tiempo,@fecha_ini,@fecha_fin,@intentos,@volver_atras,@errores_restan,"
                    + "@mostrar_resultados,@fecha_creac,@estado,@CT,@dificultad) "

                    + "ON DUPLICATE KEY UPDATE titulo = @titulo, descripcion = @descripcion, autor = @autor, curso = @curso, tiempo = @tiempo,"
                    + "fecha_ini = @fecha_ini, fecha_fin = @fecha_fin, intentos = @intentos, volver_atras = @volver_atras, errores_restan = @errores_restan,"
                    + "mostrar_resultados = @mostrar_resultados, fecha_creac = @fecha_creac, estado = @estado, CT = @CT, dificultad = @dificultad;";

                    cmd.Parameters.AddWithValue("@id", ex.GetId());
                    cmd.Parameters.AddWithValue("@titulo", ex.GetTitulo());
                    cmd.Parameters.AddWithValue("@descripcion", ex.GetDescripcion());
                    cmd.Parameters.AddWithValue("@autor", ex.GetAutor());
                    cmd.Parameters.AddWithValue("@curso", ex.GetCurso());
                    cmd.Parameters.AddWithValue("@tiempo", ex.GetTiempo());
                    cmd.Parameters.AddWithValue("@fecha_ini", ex.GetFechaIni().ToString());
                    cmd.Parameters.AddWithValue("@fecha_fin", ex.GetFechaFin().ToString());
                    cmd.Parameters.AddWithValue("@intentos", ex.GetIntentos());
                    cmd.Parameters.AddWithValue("@volver_atras", ex.GetVolverAtras());
                    cmd.Parameters.AddWithValue("@errores_restan", ex.GetErroresRestan());
                    cmd.Parameters.AddWithValue("@mostrar_resultados", ex.GetMostrarResultados());
                    cmd.Parameters.AddWithValue("@fecha_creac", ex.GetFechaCreac().ToString());
                    cmd.Parameters.AddWithValue("@estado", ex.GetEstado());
                    cmd.Parameters.AddWithValue("@CT", ex.GetCompetenciaTransversal());
                    cmd.Parameters.AddWithValue("@dificultad", ex.GetDificultad());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            SubirPreguntas(ex.GetPreguntasAsociadas(), ex.GetId());


        }

        public Examen Get(int id) {

            Examen ex = null;

            List<int> lista = GetListaPreguntas(id);

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM examen WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            ex = fabrica.CrearExamen(rdr.GetInt32("id"), rdr.GetString("titulo"), rdr.GetString("descripcion"), rdr.GetString("curso"),
                            rdr.GetString("autor"), rdr.GetInt32("tiempo"), DateTime.Parse(rdr.GetString("fecha_creac")),
                            DateTime.Parse(rdr.GetString("fecha_ini")), DateTime.Parse(rdr.GetString("fecha_fin")), rdr.GetInt32("intentos"),
                            rdr.GetInt32("volver_atras"), rdr.GetInt32("errores_restan"), rdr.GetInt32("mostrar_resultados"), lista,
                            rdr.GetString("estado"), rdr.GetString("dificultad"), rdr.GetString("CT"));
                        }
                    }
                }
            }

            return ex;
        }

        public void Eliminar(int id) {

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM respuestas_examenes WHERE examen = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM notas_examenes WHERE examen = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM notas_pregunta WHERE id_ex = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM lista_preguntas WHERE id_examen = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM examen WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int UltimoIdExamen() {

            int id = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id FROM examen ORDER BY id DESC LIMIT 1;";

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            id = rdr.GetInt32("id");
                        }
                    }
                }
            }

            return id;
        }

        public void SubirPreguntas(List<int> lista, int id) {

            for (int i = 0; i < lista.Count; i += 3) {

                using (MySqlConnection conn = new MySqlConnection(connStr)) {

                    using (MySqlCommand cmd = conn.CreateCommand()) {

                        cmd.CommandText = "INSERT into PSWC.lista_preguntas(id_examen,id_pregunta,ver_pregunta,puntuacion)"
                        + " VALUES(@id_ex,@id_preg,@ver_preg,@puntuacion) ON DUPLICATE KEY UPDATE puntuacion = @puntuacion;";

                        cmd.Parameters.AddWithValue("@id_ex", id);
                        cmd.Parameters.AddWithValue("@id_preg", lista[i]);
                        cmd.Parameters.AddWithValue("@ver_preg", lista[i + 1]);
                        cmd.Parameters.AddWithValue("@puntuacion", lista[i + 2]);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<int> GetListaPreguntas(int id) {

            List<int> result = new List<int> { };

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM PSWC.lista_preguntas WHERE id_examen = @id_ex ORDER BY RAND();";

                    cmd.Parameters.AddWithValue("@id_ex", id);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            result.Add(rdr.GetInt32("id_pregunta"));
                            result.Add(rdr.GetInt32("ver_pregunta"));
                            result.Add(rdr.GetInt32("puntuacion"));
                        }
                    }
                }
            }

            return result;
        }

        public void SubirRespuestas(List<dynamic> respuestas) {

            for (int i = 2; i < respuestas.Count; i += 3) {

                using (MySqlConnection conn = new MySqlConnection(connStr)) {

                    using (MySqlCommand cmd = conn.CreateCommand()) {

                        cmd.CommandText = "INSERT into respuestas_examenes(examen,alumno,pregunta,ver_pregunta,respuesta) "
                        + "VALUES(@examen,@alumno,@pregunta,@ver_pregunta,@respuesta) "
                        + "ON DUPLICATE KEY UPDATE respuesta = @respuesta;";

                        cmd.Parameters.AddWithValue("@examen", int.Parse(respuestas[0].ToString()));
                        cmd.Parameters.AddWithValue("@alumno", respuestas[1].ToString());
                        cmd.Parameters.AddWithValue("@pregunta", int.Parse(respuestas[i].ToString()));
                        cmd.Parameters.AddWithValue("@ver_pregunta", int.Parse(respuestas[i + 1].ToString()));
                        cmd.Parameters.AddWithValue("@respuesta", respuestas[i + 2].ToString());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            CalcularNotaExamen(respuestas[0], respuestas[1]);
        }

        public double CalcularNotaPregunta(Pregunta2 preg, int respuesta, double puntuacion, int resta) {
            string tipo = preg.GetTipo();
            if (respuesta == -1) { return 0; }
            if(tipo == "des") { return 0; }

            int correcta = preg.GetParametros()[0];

            switch (tipo) {
                case ("test"):
                    if (respuesta == correcta) {
                        return puntuacion;
                    } else if (resta == 1) {
                        return -puntuacion / (preg.GetParametros().Count - 2);
                    } else return 0;

                case ("vf"):
                    if (respuesta == correcta) {
                        return puntuacion;
                    } else if (resta == 1) {
                        return -puntuacion;
                    } else return 0;

                case ("mult"):
                    int aux = respuesta;
                    int a = correcta * 2;
                    int c = 0;
                    int sum = 0;
                    double total = 0.0;

                    for (int i = 0; i < 5; i++) {
                        if (a % 10 == 2) { total++; }

                        c = (a % 10) - (aux % 10);
                        if (c < 2) { sum += c; }

                        a /= 10;
                        
                        aux /= 10;
                    }

                    if (sum < 0) { sum = 0; }

                    total = sum / total;

                    return total * puntuacion;
            }

            return 0;
        }
        
        public void AnularPregunta(int id_ex, int id_preg) {

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE lista_preguntas SET puntuacion = 0 WHERE id_examen = @id_ex AND id_pregunta = @id_preg;";

                    cmd.Parameters.AddWithValue("@id_ex", id_ex);
                    cmd.Parameters.AddWithValue("@id_preg", id_preg);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEstadoQuizes() {
            int x = UltimoIdExamen();

            Examen ex = null;

            for (int i = 0; i <= x; i++) {

                ex = Get(i);
                string estado = "";

                if (ex != null) {
                    if (ex.GetFechaIni() > DateTime.Now) { estado = "Inactivo"; }
                    else if (ex.GetFechaIni() <= DateTime.Now && ex.GetFechaFin() > DateTime.Now) { estado = "Activo"; }
                    else if (DateTime.Now > ex.GetFechaFin() && ex.GetMostrarResultados() == 0) { estado = "Finalizado"; }
                    else if (ex.GetMostrarResultados() == 1) { estado = "Calificado"; }

                    using (MySqlConnection conn = new MySqlConnection(connStr)) {

                        using (MySqlCommand cmd = conn.CreateCommand()) {

                            cmd.CommandText = "UPDATE examen SET estado = @estado WHERE id = @id;";

                            cmd.Parameters.AddWithValue("@estado", estado);
                            cmd.Parameters.AddWithValue("@id", i);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

            }
        }

        public void PublicarNotas(int ex_id) {

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE examen SET mostrar_resultados = 1 WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", ex_id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT INTO notificaciones(texto,curso,profesor) VALUES(@texto,@curso,@profesor);";

                    cmd.Parameters.AddWithValue("@texto", Get(ex_id).GetCurso() + ": Nota del examen " + ex_id + " publicada");
                    cmd.Parameters.AddWithValue("@curso", Get(ex_id).GetCurso());
                    cmd.Parameters.AddWithValue("@profesor", Get(ex_id).GetAutor());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public double GetNota(string id_alumno, int id_ex) {

            double res = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT nota FROM notas_examenes WHERE alumno = @id_alumno AND examen = @id_ex;";

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    cmd.Parameters.AddWithValue("@id_ex", id_ex);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            res = double.Parse(rdr.GetString("nota"));
                        }
                    }
                }
            }
            return res;
        }

        public int ErroresRestan(int id_ex) {

            int restan = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT errores_restan FROM examen WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id_ex);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            restan = rdr.GetInt32("errores_restan");
                        }
                    }
                }
            }

            return restan;
        }

        public void CalcularNotaExamen(int id_ex, string correo) {

        double nota = 0.0;
        Pregunta2 pregunta = null;
        int restan = ErroresRestan(id_ex);
        double aux = 0.0;

            List<int> listapreg = GetListaPreguntas(id_ex);
            List<dynamic> listarespuestas = GetListaRespuestas(id_ex, correo);

            for (int i = 0; i < listapreg.Count; i += 3) {

                for (int j = 0; j < listarespuestas.Count; j += 2) {

                    if (listapreg[i] == listarespuestas[j]) {

                    pregunta = dalpreg.Get(listapreg[i], listapreg[i+1]);
                    if(pregunta.GetTipo() == "des") { aux = GetNotaPregunta(id_ex,pregunta.GetId(),correo); }
                    else { aux = CalcularNotaPregunta(pregunta, int.Parse(listarespuestas[j+1]) ,listapreg[i+2],restan); }
                    
                    nota += aux;

                    using(MySqlConnection conn = new MySqlConnection(connStr)) {

                        using(MySqlCommand cmd = conn.CreateCommand()) {

                            cmd.CommandText = "INSERT INTO notas_pregunta(id_ex,id_preg,ver_preg,alumno,nota) " +
                            "VALUES(@id_ex,@id_preg,@ver_preg,@alumno,@nota) ON DUPLICATE KEY UPDATE nota = @nota";

                            cmd.Parameters.AddWithValue("@id_ex", id_ex);
                            cmd.Parameters.AddWithValue("@id_preg", listapreg[i]);
                            cmd.Parameters.AddWithValue("@ver_preg", listapreg[i+1]);
                            cmd.Parameters.AddWithValue("@alumno", correo);
                            cmd.Parameters.AddWithValue("@nota", aux);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        if (nota < 0) { nota = 0; }

        SubirNota(id_ex, correo, nota);
        }

        public void SubirNota(int id_ex, string correo, double nota) {

            if(Get(id_ex).mostrar_resultados == 0) { nota = 0; }

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT into notas_examenes(alumno,examen,nota) VALUES(@correo,@id_ex,@nota) "
                    + "ON DUPLICATE KEY UPDATE nota = @nota;";

                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@id_ex", id_ex);
                    cmd.Parameters.AddWithValue("@nota", nota);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<dynamic> GetListaRespuestas(int id_ex, string correo) {
            List<dynamic> listarespuestas = new List<dynamic> { };

            using (MySqlConnection conn = new MySqlConnection(connStr)) {
                
                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM respuestas_examenes WHERE examen = @id_ex AND alumno = @correo;";

                    cmd.Parameters.AddWithValue("@id_ex", id_ex);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            listarespuestas.Add(rdr.GetInt32("pregunta"));
                            listarespuestas.Add(rdr.GetString("respuesta"));
                        }
                    }
                }
            }

            return listarespuestas;
        }

        public double GetPuntuacionDePregunta(int id_ex, int id_preg) {

            double res = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT puntuacion FROM lista_preguntas WHERE id_examen = @examen AND id_pregunta = @pregunta;";

                    cmd.Parameters.AddWithValue("@examen", id_ex);
                    cmd.Parameters.AddWithValue("@pregunta", id_preg);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            res = rdr.GetDouble("puntuacion");
                        }
                    }
                }
            }

            return res;
        }

        public List<dynamic> EstadisticasExamen(int id_ex) {

            List<double> notas = new List<double>();
            int envios = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT alumno,nota FROM notas_examenes WHERE examen = @examen";

                    cmd.Parameters.AddWithValue("@examen", id_ex);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            envios++;
                            notas.Add(rdr.GetDouble("nota"));
                        }
                    }
                }
            }
            
            notas.Sort();

            if (envios > 0) {
                return new List<dynamic> { envios, Math.Round(double.Parse(notas.Average().ToString()),2).ToString(), Math.Round(Math.Sqrt(notas.Average(v => Math.Pow(v - notas.Average(), 2)))).ToString(), notas };
            } else { return new List<dynamic> { 0, 0, 0, notas }; }

        }

        public DataTable EstadisticasExamenPreguntas(int id_ex) {
            List<int> pregs = GetListaPreguntas(id_ex);
            List<double> notas; 
            int aciertos = 0;

            DataTable dt = new DataTable(); 
            dt.Clear();
            dt.Columns.Add("Pregunta");
            dt.Columns.Add("Versión");
            dt.Columns.Add("Envíos");
            dt.Columns.Add("Aciertos");
            dt.Columns.Add("Ratio");

            DataRow _ravi;

            for(int i = 0; i < pregs.Count; i+=3) {

                _ravi = dt.NewRow();

                notas = new List<double>();

                _ravi["Pregunta"] = pregs[i];
                _ravi["Versión"] = pregs[i+1];

                using (MySqlConnection conn = new MySqlConnection(connStr)) {

                    using (MySqlCommand cmd = conn.CreateCommand()) {

                        cmd.CommandText = "SELECT nota FROM notas_pregunta WHERE id_ex = @examen AND id_preg = @id_preg;";

                        cmd.Parameters.AddWithValue("@examen", id_ex);
                        cmd.Parameters.AddWithValue("@id_preg", pregs[i]);

                        conn.Open();

                        using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                            while (rdr.Read()) {
                                notas.Add(rdr.GetDouble("nota"));
                            }
                        }
                    }
                }

                _ravi["Envíos"] = notas.Count;

                foreach(double nota in notas) {
                    if(nota == pregs[i+2]) { aciertos++; }
                }

                _ravi["Aciertos"] = aciertos;
                if(notas.Count > 0) { _ravi["Ratio"] =  aciertos/notas.Count; }
                else _ravi["Ratio"] = 0;

                dt.Rows.Add(_ravi);
            }

            return dt;
        }

        public void GenerarExamen(string profesor, string codigo_curso, int num_preguntas, int tiempo, DateTime fechaini, DateTime fechafin,
        int intentos, int volveratras, int erroresrestan, int mostrarresultados, bool esrecu, string dific) {

            Random rand = new Random();

            int id = UltimoIdExamen() + 1;

            List<int> preguntas = new List<int> { };
            List<int> versiones = new List<int> { };
            List<int> final = new List<int> { };

            int aux = 0;
            string titulo = codigo_curso + ": autoexamen. ID: " + id;
            string descripcion = "Examen generado automáticamente";

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT DISTINCT id,ver FROM pregunta WHERE tema = @tema AND autor = @autor";

                    cmd.Parameters.AddWithValue("@tema", codigo_curso);
                    cmd.Parameters.AddWithValue("@autor", profesor);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            preguntas.Add(rdr.GetInt32("id"));
                            versiones.Add(rdr.GetInt32("ver"));
                        }
                    }
                }
            }

            if (preguntas.Count == 0) { throw new Exception("No existen preguntas del curso seleccionado"); }

            while (preguntas.Count > num_preguntas) {
                aux = rand.Next(1, preguntas.Count - 1);

                preguntas.RemoveAt(aux);
                versiones.RemoveAt(aux);
            }

            for (int i = 0; i < preguntas.Count; i++) {
                final.Add(preguntas[i]);
                final.Add(versiones[i]);
                final.Add(1);
            }

            if (esrecu) {
                titulo = codigo_curso + ": recuperación. ID: " + id;
                descripcion = "Examen de recuperación generado automáticamente";
            }

            Add(fabrica.CrearExamen(id, titulo, descripcion, codigo_curso, profesor, tiempo, DateTime.Now, fechaini, fechafin,
            intentos, volveratras, erroresrestan, mostrarresultados, final, "Inactivo", dific));
        }

        public void FinalizarExamen(int id) {

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE examen SET fecha_fin = @fecha WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetExamenesByDificultad(List<dynamic> filtros)
        {
            DataTable dt = new DataTable();

            string consulta = "SELECT id,titulo,curso,tiempo,fecha_ini,fecha_fin,estado,dificultad FROM examen WHERE dificultad = '" + filtros[0] + "';";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = consulta;

                    conn.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }

        public void EliminarPreguntaDeExamen(int id_ex, int id_preg) {
            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM lista_preguntas WHERE id_examen = @id_ex AND id_pregunta = @id_preg;";

                    cmd.Parameters.AddWithValue("@id_ex", id_ex);
                    cmd.Parameters.AddWithValue("@id_preg", id_preg);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetPreguntasDesarrolloExamen(int id_ex) {

            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM respuestas_examenes WHERE examen = @id_ex AND pregunta IN " 
                    + "(SELECT id FROM pregunta WHERE tipo = 'des');";

                    cmd.Parameters.AddWithValue("@id_ex", id_ex);

                    conn.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }

        public void CalificarDesarrollo(int id_ex, int id_preg, int ver_preg, string alumno, double nota) {
            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE notas_pregunta SET nota = @nota WHERE id_ex = @id_ex AND id_preg = @id_preg "
                    + "AND ver_preg = @ver_preg AND alumno = @alumno;";

                    cmd.Parameters.AddWithValue("@id_ex", id_ex);
                    cmd.Parameters.AddWithValue("@id_preg", id_preg);
                    cmd.Parameters.AddWithValue("@ver_preg", ver_preg);
                    cmd.Parameters.AddWithValue("@alumno", alumno);
                    cmd.Parameters.AddWithValue("@nota", nota);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }
    
        public double GetNotaPregunta(int id_ex, int id_preg, string alumno) {
            double res = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr)) {

                using (MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT nota FROM notas_pregunta WHERE id_ex = @examen AND id_preg = @pregunta AND alumno = @alumno;";

                    cmd.Parameters.AddWithValue("@examen", id_ex);
                    cmd.Parameters.AddWithValue("@pregunta", id_preg);
                    cmd.Parameters.AddWithValue("@alumno", alumno);

                    conn.Open();

                    using (MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            res = rdr.GetDouble("nota");
                        }
                    }
                }
            }

            return res;
        }
    }
}