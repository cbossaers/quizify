using MySql.Data.MySqlClient;
using Quizify.Entities;
using System.Collections.Generic;
using Quizify.Persistence;

namespace Quizify.Persistence {

public class DALAlumno : IDAL2<Alumno> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    DALCurso DALCurso = new DALCurso();
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

    public List<int> GetExamenes(string id) {

        List<int> result = new List<int> {};

        List<string> cursos = DALCurso.GetCursosAlumno(id);

        foreach(string curso in cursos) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id FROM examen WHERE curso = @curso";

                    cmd.Parameters.AddWithValue("@curso", curso);

                    conn.Open();

                    using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            result.Add(rdr.GetInt32("id"));
                        }
                    }
                }
            }
        }

        return result;
    }

}}