using MySql.Data.MySqlClient;
using Quizify.Entities;
using System.Collections.Generic;
using Quizify.Persistence;
using System.Data;

namespace Quizify.Persistence {

public class DALAlumno {
    static string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    DALCurso DALCurso = new DALCurso();
    DALExamen DALExamen = new DALExamen();
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

    public (DataTable, DataTable) GetExamenes(string id) {

        List<string> cursos = DALCurso.GetCursosAlumno(id);
        DataTable dtact = new DataTable();
        DataTable dtnoact = new DataTable();
        DataTable dtnota = new DataTable();

        foreach(string curso in cursos) {

            using(MySqlConnection conn = new MySqlConnection(connStr)) {

                using(MySqlCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id,titulo,curso,tiempo,fecha_fin,CT,dificultad FROM examen WHERE curso = @curso AND estado = 'Activo' AND id NOT IN (SELECT examen FROM notas_examenes WHERE alumno = @alumno)";

                    cmd.Parameters.AddWithValue("@curso", curso);
                    cmd.Parameters.AddWithValue("@alumno", id);

                    conn.Open();

                    dtact.Load(cmd.ExecuteReader());

                    conn.Close();
                    

                    cmd.CommandText = "SELECT id,titulo,curso,estado,CT,dificultad FROM examen WHERE (curso = @curso AND estado NOT LIKE 'Activo') OR (id IN ("
                    + "SELECT examen FROM notas_examenes WHERE alumno = @alumno));";

                    conn.Open();

                    dtnoact.Load(cmd.ExecuteReader());
                }
            } 
        }

        return (dtact, GetNotas(id,dtnoact));
    }

    public DataTable GetNotas(string id_al, DataTable dt) {

        dt.Columns.Add("nota", typeof(System.Double));

        foreach(DataRow row in dt.Rows) {

            row["nota"] = DALExamen.GetNota(id_al, int.Parse(row["id"].ToString()));
        }

        return dt;
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

    public DataTable GetNotificaciones(string correo) {

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id_notif FROM alumno_notif WHERE id_al = @alumno;";

                cmd.Parameters.AddWithValue("@alumno", correo);

                conn.Open();

                dt.Load(cmd.ExecuteReader());
            }
        }

        foreach(DataRow row in dt.Rows) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT id,texto FROM notificaciones WHERE id = @id;";

                cmd.Parameters.AddWithValue("@id", row["id_notif"]);

                conn.Open();

                dt2.Load(cmd.ExecuteReader());
            }
        }
        }

        return dt2;
    }

    public void EliminarNotificacion(int id_notif, string correo) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM alumno_notif WHERE id_al = @id_al AND id_notif = @id_notif;";

                cmd.Parameters.AddWithValue("@id_al", correo);
                cmd.Parameters.AddWithValue("@id_notif", id_notif);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}}