using MySql.Data.MySqlClient;
using Quizify.Entities;
using System.Collections.Generic;

namespace Quizify.Persistence {

public class DALProfesor {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    FabricaEntidades fabrica = new FabricaEntidades();

    public void Add(Profesor profesor) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into profesor(correo,contraseña,nombre,apellidos,quizes) "
                 + "VALUES(@correo, @contraseña, @nombre, @apellidos,@quizes);";

                cmd.Parameters.AddWithValue("@correo", profesor.GetCorreo());
                cmd.Parameters.AddWithValue("@contraseña", profesor.GetContraseña());
                cmd.Parameters.AddWithValue("@nombre", profesor.GetNombre());
                cmd.Parameters.AddWithValue("@apellidos", profesor.GetApellidos());
                cmd.Parameters.AddWithValue("@quizes", profesor.GetQuizes());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Profesor Get(string id) {
        
        Profesor prof = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * from profesor WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        prof = fabrica.CrearEntidad("profesor", rdr.GetString("correo"), rdr.GetString("contraseña"), 
                            rdr.GetString("nombre"), rdr.GetString("apellidos"),rdr.GetInt32("quizes"));
                    }
                }
            }
        }

        return prof;
    }

    public void Eliminar(string id) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM profesor WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<int> GetExamenes(string id) {

        List<int> result = new List<int> {};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id FROM examen WHERE autor = @autor";

                cmd.Parameters.AddWithValue("@autor", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        result.Add(rdr.GetInt32("id"));
                    }
                }
            }
        }

        return result;
    }
        
}}