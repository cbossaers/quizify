using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using System.Data;

namespace Quizify.Persistence {

public class DALExamen : IDAL2<Examen> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    FabricaExamenes fabrica = new FabricaExamenes();
    DALPregunta DALPregunta = new DALPregunta();

    public void Add(Examen ex) {

        int ultimoID = UltimoIdExamen();

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.examen(id,titulo,descripcion,autor,curso,tiempo,fecha_ini,fecha_fin,intentos"
                + ",volver_atras,errores_restan,mostrar_resultados,fecha_creac,estado,CT) VALUES(@id,@titulo,@descripcion,@autor,"
                + "@curso,@tiempo,@fecha_ini,@fecha_fin,@intentos,@volver_atras,@errores_restan,@mostrar_resultados,@fecha_creac,@estado,@CT);";

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

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        List<int> lista = ex.GetPreguntasAsociadas();

        for(int i = 0; i < lista.Count; i+=3) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT into PSWC.lista_preguntas(id_examen,id_pregunta,ver_pregunta,puntuacion)"
                    + " VALUES(@id_ex,@id_preg,@ver_preg,@puntuacion);";

                    cmd.Parameters.AddWithValue("@id_ex", ex.GetId());
                    cmd.Parameters.AddWithValue("@id_preg", lista[i]);
                    cmd.Parameters.AddWithValue("@ver_preg", lista[i+1]);
                    cmd.Parameters.AddWithValue("@puntuacion", lista[i+2]);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
 
    public Examen Get<K>(K id) {

        Examen ex = null;

        List<int> lista = GetListaPreguntas(id);
        
        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM examen WHERE id = @id;";

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        ex = fabrica.CrearExamen(rdr.GetInt32("id"), rdr.GetString("titulo"), rdr.GetString("descripcion"), rdr.GetString("curso"),
                        rdr.GetString("autor"), rdr.GetInt32("tiempo"), DateTime.Parse(rdr.GetString("fecha_creac")), 
                        DateTime.Parse(rdr.GetString("fecha_ini")), DateTime.Parse(rdr.GetString("fecha_fin")), rdr.GetInt32("intentos"),
                        rdr.GetInt32("volver_atras"), rdr.GetInt32("errores_restan"), rdr.GetInt32("mostrar_resultados"), lista,
                        rdr.GetString("estado"), rdr.GetString("CT"));
                    }
                }
            }
        }

        return ex;
    }

    public void Eliminar<K>(K id) {}

    public int UltimoIdExamen() {

        int id = 0;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id FROM examen;";

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        id = rdr.GetInt32("id");
                    }
                }
            }
        }
    return id;
    }

    public List<int> GetListaPreguntas<K>(K id) {

        List<int> result = new List<int> {};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM PSWC.lista_preguntas WHERE id_examen = @id_ex;";

                cmd.Parameters.AddWithValue("@id_ex", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

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

        for(int i = 2; i < respuestas.Count; i+=3) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT into respuestas_examenes(examen,alumno,pregunta,ver_pregunta,respuesta) "
                    + "VALUES(@examen,@alumno,@pregunta,@ver_pregunta,@respuesta);";

                    cmd.Parameters.AddWithValue("@examen", respuestas[0]);
                    cmd.Parameters.AddWithValue("@alumno", respuestas[1]);
                    cmd.Parameters.AddWithValue("@pregunta", respuestas[i]);
                    cmd.Parameters.AddWithValue("@ver_pregunta", respuestas[i+1]);
                    cmd.Parameters.AddWithValue("@respuesta", respuestas[i+2].ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public double CalcularNotaPregunta(Pregunta2 preg, int respuesta, double puntuacion, int resta) {
        string tipo = preg.GetTipo();
        int correcta = preg.GetParametros()[0];

        if(respuesta == -1) { return 0; }

        switch(tipo){
            case("test"): 
                if(respuesta == correcta) {
                    return puntuacion;
                } else if (resta == 1) {
                    return -puntuacion/(preg.GetParametros().Count - 2);
                } else return 0;

            case("vf"):
                if(respuesta == correcta) {
                    return puntuacion;
                } else if (resta == 1) {
                    return -puntuacion;
                } else return 0;

            case("mult"):
                int a = correcta * 2;
                int c = 0;
                int sum = 0;
                double total = 0.0;

                for(int i = 0; i < 5; i++) {
                    if(a % 10 == 2) { total++; }

                    c = (a % 10) - (respuesta % 10);
                    if(c < 2) { sum+=c; }

                    a /= 10;
                    respuesta /= 10;
                }

                if(sum < 0) { sum = 0; }

                total = sum / total;

                return total * puntuacion;

            case("des"):
                return 0;
        }

        return 0;
    }

    public void AnularPregunta(int id_ex, int id_preg) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

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

        for(int i = 0; i < x; i++) {
            
            ex = Get(i);
            string estado = "";

            if(ex.GetMostrarResultados() == 1) { estado = "Calificado"; }
            else if(ex.GetFechaIni() > DateTime.Now) { estado = "Inactivo";}
            else if(ex.GetFechaIni() <= DateTime.Now && ex.GetFechaFin() > DateTime.Now) { estado = "Activo"; }
            else if(ex.GetFechaFin() <= DateTime.Now) { estado = "Finalizado"; }

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE PSWC.examen SET estado = @estado WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id",i);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public void PublicarNotas(int ex_id) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "UPDATE examen SET mostrar_resultados = @mostrar WHERE id = @id;";

                cmd.Parameters.AddWithValue("@mostrar", 1);
                cmd.Parameters.AddWithValue("@id",ex_id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        ActualizarEstadoQuizes();
    }

    public double GetNota(string id_alumno, int id_ex) {

            double res = 0.0;

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT nota FROM notas_examanes WHERE alumno = @id_alumno AND examen = @id_ex;"; 

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    cmd.Parameters.AddWithValue("@id_ex",id_ex);

                    conn.Open();

                    using(MySqlDataReader rdr = cmd.ExecuteReader()) {

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

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT errores_restan FROM examen WHERE id = @id;";

                cmd.Parameters.AddWithValue("@id", id_ex);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

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
        dynamic pregunta = null;
        int id_preg = 0;
        int ver_preg = 0;
        double puntuacion = 0.0;
        int restan = ErroresRestan(id_ex);

        using(MySqlConnection conn = new MySqlConnection(connStr)) {
            string consulta_lista =  "SELECT * FROM lista_preguntas WHERE id_examen = " + id_ex + ";";
            string consulta_respuestas = "SELECT * FROM respuestas_examenes WHERE examen = " + id_ex +  " AND alumno = '" + correo + "';";
            
            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta_lista, conn);
            DataTable data = new DataTable();
            adapter.Fill(data);

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta_respuestas, conn);
            DataTable data2 = new DataTable();
            adapter2.Fill(data2);

            conn.Close();

            foreach (DataRow row in data.Rows) { 
                id_preg = int.Parse(row["id_pregunta"].ToString());
                ver_preg = int.Parse(row["ver_pregunta"].ToString());
                puntuacion = double.Parse(row["puntuacion"].ToString());

                foreach (DataRow row2 in data2.Rows) { 
                    if(id_preg == int.Parse(row2["pregunta"].ToString())) {
                        pregunta = DALPregunta.Get(id_preg, ver_preg);
                        nota+=CalcularNotaPregunta(pregunta, int.Parse(row2["respuesta"].ToString()),puntuacion,restan);
                    }
                }
            }
        }

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.notas_examenes(alumno,examen,nota) VALUES(@correo,@id_ex,@nota);";

                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@id_ex", id_ex);
                cmd.Parameters.AddWithValue("@nota", nota);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}}