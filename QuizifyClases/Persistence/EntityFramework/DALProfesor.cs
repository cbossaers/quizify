using MySql.Data.MySqlClient;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALProfesor : IDAL2<Profesor> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    FabricaEntidades fabrica = new FabricaEntidades();

    public void Add(Profesor profesor) {
        
        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into entidad(correo,tipo) VALUES(@correo,'profesor');";

                cmd.Parameters.AddWithValue("@correo", profesor.GetCorreo());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into profesor(correo,contraseña,nombre,apellidos) "
                 + "VALUES(@correo, @contraseña, @nombre, @apellidos,20);";

                cmd.Parameters.AddWithValue("@correo", profesor.GetCorreo());
                cmd.Parameters.AddWithValue("@contraseña", profesor.GetContraseña());
                cmd.Parameters.AddWithValue("@nombre", profesor.GetNombre());
                cmd.Parameters.AddWithValue("@apellidos", profesor.GetApellidos());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Profesor Get<K>(K id) {
        
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