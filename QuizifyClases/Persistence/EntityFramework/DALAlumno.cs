using MySql.Data.MySqlClient;
using Quizify.Entities;
using System.Collections.Generic;
using Quizify.Persistence;
using System.Data;

namespace Quizify.Persistence {

public class DALAlumno {
    static string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    DALCurso DALCurso = new DALCurso();
    FabricaEntidades fabrica = new FabricaEntidades();

    public void Add(Alumno alumno) {

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

    public Alumno Get(string id) {

        Alumno al = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM alumno WHERE correo = @correo;";

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

    public void Eliminar(string id) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM alumno WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetExamenesActivos(string id) {

        List<string> cursos = DALCurso.GetCursosAlumno(id);
        DataTable dt = new DataTable();

        foreach(string curso in cursos) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = cmd.CommandText = "SELECT * FROM examen WHERE curso = @curso AND estado = 'Activo'";

                    cmd.Parameters.AddWithValue("@curso", curso);

                    conn.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            } 
        }

        return dt;
    }

    public DataTable GetExamenesNoActivos(string id) {

        List<string> cursos = DALCurso.GetCursosAlumno(id);
        DataTable dt = new DataTable();

        foreach(string curso in cursos) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = cmd.CommandText = "SELECT * FROM examen WHERE curso = @curso AND estado NOT LIKE 'Activo'";

                    cmd.Parameters.AddWithValue("@curso", curso);

                    conn.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            } 
        }

        return dt;
    }

    public (DataTable, DataTable) GetExamenes(string id) {

        List<string> cursos = DALCurso.GetCursosAlumno(id);
        DataTable dtact = new DataTable();
        DataTable dtnoact = new DataTable();

        foreach(string curso in cursos) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM examen WHERE curso = @curso AND estado = 'Activo'";

                    cmd.Parameters.AddWithValue("@curso", curso);

                    conn.Open();

                    dtact.Load(cmd.ExecuteReader());

                    conn.Close();
                    

                    cmd.CommandText = "SELECT * FROM examen WHERE curso = @curso AND estado NOT LIKE 'Activo'";

                    cmd.Parameters.AddWithValue("@curso", curso);

                    conn.Open();

                    dtnoact.Load(cmd.ExecuteReader());

                    conn.Close();

                }
            } 
        }

        return (dtact, dtnoact);
    }

    public DataTable GetAllAlumnos() {

        DataTable dt = new DataTable();

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM alumno;";

                conn.Open();

                dt.Load(cmd.ExecuteReader());
            }
        }

        return dt;
    }
}}