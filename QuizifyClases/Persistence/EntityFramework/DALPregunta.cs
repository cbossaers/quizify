using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALPregunta : IDAL2<Pregunta2> {
   static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

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
                        break;

                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Pregunta2 Get<K>(K id) {

        string tipo = GetTipoPregunta(id);
        List<dynamic> lista = new List<dynamic> {};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * from pregunta_@tipo WHERE id = @id AND ver = @ver;";

                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("ver", ver);

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        switch(tipo) {
                            case("test"):
                                lista.Add(rdr.GetInt32("correcta"));
                                lista.Add(rdr.GetString("opc_a"));
                                lista.Add(rdr.GetString("opc_b"));
                                lista.Add(rdr.GetString("opc_c"));
                                lista.Add(rdr.GetString("opc_d"));
                                lista.Add(rdr.GetString("opc_e"));

                                break;

                            case("vf"):
                                lista.Add(rdr.GetInt32("correcta"));

                                break;

                            case("mult"):
                                lista.Add(rdr.GetInt32("correcta"));
                                lista.Add(rdr.GetString("opc_a"));
                                lista.Add(rdr.GetString("opc_b"));
                                lista.Add(rdr.GetString("opc_c"));
                                lista.Add(rdr.GetString("opc_d"));
                                lista.Add(rdr.GetString("opc_e"));

                                break;

                            case("des"):
                                break;
                    }
                }
            }
        }
    }}

    public List<dynamic> GetParametros<K>(K id, int ver, ) {
        
    }

    public void Eliminar<K>(K id) {}

    public List<int> GetPreguntas(List<dynamic> filtros) {}

    public int UltimoIdPregunta() {

        int id = 0;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id FROM pregunta;";

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

    public string GetTipoPregunta<K>(K id) {

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

}}