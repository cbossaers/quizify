using MySql.Data.MySqlClient;
using Quizify.Entities;
using System.Collections.Generic;
using System.Data;

namespace Quizify.Persistence {

public class DALProfesor {
    static string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

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

    public DataTable GetExamenes(string id) {

        DataTable dt = new DataTable();

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM examen WHERE autor = @autor";

                cmd.Parameters.AddWithValue("@autor", id);

                conn.Open();

                dt.Load(cmd.ExecuteReader());
            }
        }

        return dt;
    }
        
}}