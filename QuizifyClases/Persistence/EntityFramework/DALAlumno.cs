using MySql.Data.MySqlClient;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALAlumno : IDAL2<Alumno> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    FabricaEntidades fabrica = new FabricaEntidades();

    public void Add(Alumno alumno) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into entidad(correo,tipo) VALUES(@correo,'alumno');";

                cmd.Parameters.AddWithValue("@correo", alumno.GetCorreo());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into alumno(correo,contraseña,nombre,apellidos) "
                 + "VALUES(@correo, @contraseña, @nombre, @apellidos);";

                cmd.Parameters.AddWithValue("@correo", alumno.GetCorreo());
                cmd.Parameters.AddWithValue("@contraseña", alumno.GetContraseña());
                cmd.Parameters.AddWithValue("@nombre", alumno.GetNombre());
                cmd.Parameters.AddWithValue("@apellidos", alumno.GetApellidos());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Alumno Get<K>(K id) {

        Alumno al = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * from alumno WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        al = fabrica.CrearEntidad("alumno", rdr.GetString("correo"), rdr.GetString("contraseña"), 
                            rdr.GetString("nombre"), rdr.GetString("apellidos"));
                    }
                }
            }
        }

        return al;
    }

    public void Eliminar<K>(K id) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM entidad WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}}