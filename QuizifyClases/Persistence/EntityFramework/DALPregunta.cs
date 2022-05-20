using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using System.Data;

namespace Quizify.Persistence {

public class DALPregunta {
   static string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

   FabricaPreguntas fabrica = new FabricaPreguntas();
   //DALExamen dalex = new DALExamen();

    public void Add(Pregunta2 preg) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into pregunta(id,ver,enunciado,tipo,dificultad,autor,tema,CT) "
                 + "VALUES(@id,@ver,@enunciado,@tipo,@dificultad,@autor,@tema,@CT);";

                cmd.Parameters.AddWithValue("@id", preg.GetId());
                cmd.Parameters.AddWithValue("@ver", preg.GetVersion());
                cmd.Parameters.AddWithValue("@enunciado", preg.GetEnunciado());
                cmd.Parameters.AddWithValue("@tipo", preg.GetTipo());
                cmd.Parameters.AddWithValue("@dificultad", preg.GetDificultad());
                cmd.Parameters.AddWithValue("@autor", preg.GetAutor());
                cmd.Parameters.AddWithValue("@tema", preg.GetTema());
                cmd.Parameters.AddWithValue("@CT", preg.GetCT());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                switch(preg.GetTipo()) {
                    case("test"):

                        while(preg.GetParametros().Count < 6) { preg.GetParametros().Add(null); }

                        cmd.CommandText = "INSERT into pregunta_test(id,ver,opc_a,opc_b,opc_c,opc_d,opc_e,correcta) "
                        + "VALUES(@id,@ver,@opca,@opcb,@opcc,@opcd,@opce,@correcta);";

                        cmd.Parameters.AddWithValue("@id", preg.GetId());
                        cmd.Parameters.AddWithValue("@ver", preg.GetVersion());
                        cmd.Parameters.AddWithValue("@opca", preg.GetParametros()[1]);
                        cmd.Parameters.AddWithValue("@opcb", preg.GetParametros()[2]);
                        cmd.Parameters.AddWithValue("@opcc", preg.GetParametros()[3]);
                        cmd.Parameters.AddWithValue("@opcd", preg.GetParametros()[4]);
                        cmd.Parameters.AddWithValue("@opce", preg.GetParametros()[5]);
                        cmd.Parameters.AddWithValue("@correcta", preg.GetParametros()[0]);

                        break;

                    case("vf"):

                        cmd.CommandText = "INSERT into pregunta_vf(id,ver,correcta) VALUES(@id,@ver,@correcta);";

                        cmd.Parameters.AddWithValue("@id", preg.GetId());
                        cmd.Parameters.AddWithValue("@ver", preg.GetVersion());
                        cmd.Parameters.AddWithValue("@correcta", preg.GetParametros()[0]);

                        break;

                    case("mult"):

                        while(preg.GetParametros().Count < 6) { preg.GetParametros().Add(null); }

                        cmd.CommandText = "INSERT into pregunta_mult(id,ver,opc_a,opc_b,opc_c,opc_d,opc_e,correcta) "
                        + "VALUES(@id,@ver,@opca,@opcb,@opcc,@opcd,@opce,@correcta);";

                        cmd.Parameters.AddWithValue("@id", preg.GetId());
                        cmd.Parameters.AddWithValue("@ver", preg.GetVersion());
                        cmd.Parameters.AddWithValue("@opca", preg.GetParametros()[1]);
                        cmd.Parameters.AddWithValue("@opcb", preg.GetParametros()[2]);
                        cmd.Parameters.AddWithValue("@opcc", preg.GetParametros()[3]);
                        cmd.Parameters.AddWithValue("@opcd", preg.GetParametros()[4]);
                        cmd.Parameters.AddWithValue("@opce", preg.GetParametros()[5]);
                        cmd.Parameters.AddWithValue("@correcta", preg.GetParametros()[0]);

                        break;

                    case("des"):

                        cmd.CommandText = "INSERT into pregunta_des(id,ver,descripcion) VALUES(@id,@ver,@descripcion);";

                        if(preg.GetParametros().Count < 1) { preg.GetParametros().Add(""); }

                        cmd.Parameters.AddWithValue("@id", preg.GetId());
                        cmd.Parameters.AddWithValue("@ver", preg.GetVersion());
                        cmd.Parameters.AddWithValue("@descripcion", preg.GetParametros()[0]);

                        break;

                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
    public Pregunta2 Get(int id, int ver) {

        string tipo = GetTipoPregunta(id);
        List<dynamic> lista = new List<dynamic> {};

        Pregunta2 preg = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * from pregunta_" + tipo + " WHERE id = @id AND ver = @ver;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("ver", ver);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        switch(tipo) {
                            case("test"):
                                lista.Add(rdr.GetInt32("correcta"));
                                lista.Add(rdr.GetString("opc_a"));
                                lista.Add(rdr.GetString("opc_b"));
                                lista.Add(rdr.GetString("opc_c"));
                                if(rdr["opc_d"] != DBNull.Value) { lista.Add(rdr.GetString("opc_d")); }
                                if(rdr["opc_e"] != DBNull.Value) { lista.Add(rdr.GetString("opc_e")); }

                                break;

                            case("vf"):
                                lista.Add(rdr.GetInt32("correcta"));

                                break;

                            case("mult"):
                                lista.Add(rdr.GetInt32("correcta"));
                                lista.Add(rdr.GetString("opc_a"));
                                lista.Add(rdr.GetString("opc_b"));
                                lista.Add(rdr.GetString("opc_c"));
                                if(rdr["opc_d"] != DBNull.Value) { lista.Add(rdr.GetString("opc_d")); }
                                if(rdr["opc_e"] != DBNull.Value) { lista.Add(rdr.GetString("opc_e")); }

                                break;

                            case("des"):
                                lista.Add(rdr.GetString("descripcion"));

                                break;
                    }
                }
            }
        }}

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM pregunta WHERE id = @id AND ver = @ver";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("ver", ver);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        preg = fabrica.CrearPregunta2(rdr.GetInt32("id"), rdr.GetInt32("ver"), rdr.GetString("enunciado"), 
                        rdr.GetString("tipo"), rdr.GetInt32("dificultad"), rdr.GetString("autor"), rdr.GetString("tema"), 
                        rdr.GetString("CT"), lista);
                    }
                }
            }
        }

        return preg;
    }
    public void Eliminar(int id, int ver) {
        
        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM pregunta WHERE id = @id AND ver = @ver;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ver", ver);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
    public DataTable GetPreguntas(List<dynamic> filtros) {

        List<int> result = new List<int> {};
        DataTable dt = new DataTable();

        string consulta = "SELECT id,ver,enunciado,tipo,dificultad,tema,CT from PSWC.pregunta" + " WHERE autor= '" + filtros[0] + "'";

        if(filtros[1] != null) { consulta = consulta + " " +  "AND tipo= '" + filtros[1] + "'"; }
        if(filtros[2] != null) { consulta = consulta + " " +  "AND dificultad= " + filtros[2] + ""; }
        if(filtros[3] != null) { consulta = consulta + " " +  "AND tema= '" + filtros[3] + "'"; }

        consulta = consulta + ";";

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = consulta;

                conn.Open();

                dt.Load(cmd.ExecuteReader());
            }
        }

        return dt;
    }
    public int UltimoIdPregunta() {

        int id = 0;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id FROM pregunta ORDER BY id DESC LIMIT 1;";

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
    public int UltimaVerPregunta(int id) {

        int ver = 0;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT ver FROM pregunta WHERE id = @id ORDER BY ver DESC LIMIT 1;";

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        ver = rdr.GetInt32("ver");
                    }
                }
            }
        }
    return ver;
    }
    public string GetTipoPregunta(int id) {

        string tipo = "";

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT tipo FROM pregunta WHERE id = @id;";

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        tipo = rdr.GetString("tipo");
                    }
                }
            }
        }

        return tipo;
    } 

    /*public List<double> EstadisticasPregunta(int id_ex, int id_preg, int ver_preg) {

        int envios = 0;
        int aciertos = 0;
        double tasa = 0;
        Pregunta2 preg = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM respuestas_examenes WHERE examen = @id_ex " + 
                "AND pregunta = @id_preg AND ver_pregunta = @ver_preg;";

                cmd.Parameters.AddWithValue("@id_ex", id_ex);
                cmd.Parameters.AddWithValue("@id_preg", id_preg);
                cmd.Parameters.AddWithValue("@ver_preg", ver_preg);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        envios++;
                        preg = Get(id_preg, ver_preg);
                        if(dalex.CalcularNotaPregunta(preg, rdr.GetInt32("respuesta"), 1, 0) >= 1) {
                            aciertos++;
                        }
                    }
                }
            }
        }

        if(envios > 0) { tasa = aciertos/envios; }

        return new List<double> {envios, aciertos, tasa};
    }*/
}}