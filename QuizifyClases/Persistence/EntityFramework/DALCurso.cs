using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALCurso : IDAL2<Curso> {
   static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    public void Add(Curso curso) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.cursos(codigo,nombre,profesor,apuntados,capacidad,fecha_creac,contraseña) "
                    + "VALUES(@codigo, @nombre, @profesor, @apuntados, @capacidad, @fecha_creac, @contraseña);";

                cmd.Parameters.AddWithValue("@codigo", curso.GetCodigo());
                cmd.Parameters.AddWithValue("@nombre", curso.GetNombre());
                cmd.Parameters.AddWithValue("@profesor", curso.GetAutor());
                cmd.Parameters.AddWithValue("@apuntados", 0);
                cmd.Parameters.AddWithValue("@capacidad", curso.GetMaxAlumnos());
                cmd.Parameters.AddWithValue("@fecha_creac", curso.GetFechaCreacion().ToString());
                cmd.Parameters.AddWithValue("@contraseña", curso.GetContraseña());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Curso Get<K>(K id) {

        Curso curso = null;

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM cursos WHERE codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", id);        

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        curso = new Curso(rdr.GetString("codigo"), rdr.GetString("nombre"), rdr.GetString("autor"), rdr.GetInt32("apuntados"),
                        rdr.GetInt32("capacidad"), DateTime.Parse(rdr.GetString("fecha_creac")), rdr.GetString("contraseña"), GetAlumnosDeCurso(id));
                    }
                }
            }
        }

        return curso;
    }

    public void Eliminar<K>(K id) {}

    public void AddAlumnoACurso(string alumno, string curso, string profesor) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            int apuntados = 0;
            int capacidad = 0;

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT apuntados,capacidad FROM PSWC.cursos WHERE codigo = @curso AND profesor = @profesor;";

                cmd.Parameters.AddWithValue("@codigo_curso", curso);
                cmd.Parameters.AddWithValue("@profesor", profesor);

                using (MySqlDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read())
                    apuntados = int.Parse(dr.GetString("apuntados").ToString());
                    capacidad = int.Parse(dr.GetString("capacidad").ToString());
                }
            }

            if(apuntados >= capacidad) {throw new InvalidOperationException("Ese curso ya está lleno"); }

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.alumno_curso(alumno,curso) "
                    + "VALUES(@alumno,@curso);";

                cmd.Parameters.AddWithValue("@alumno", alumno);
                cmd.Parameters.AddWithValue("@curso", curso);

                conn.Open();
                cmd.ExecuteNonQuery();

                AlterarNumeroAlumnos(1,curso,profesor,apuntados);
            }
        }
    }

    public void EliminarAlumnoDeCurso(string alumno, string curso, string profesor) {
        
        using(MySqlConnection conn = new MySqlConnection(connStr)) {
            
            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "DELETE FROM PSWC.alumno_curso WHERE alumno = @alumno AND curso = @curso";

                cmd.Parameters.AddWithValue("@alumno", alumno);
                cmd.Parameters.AddWithValue("@curso", curso);

                conn.Open();
                cmd.ExecuteNonQuery();

                AlterarNumeroAlumnos(-1,curso,profesor);
            }
        }
    }

     public void AlterarNumeroAlumnos(int tipo_cambio, string codigo_curso, string profesor, int apuntados = 0) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "UPDATE PSWC.cursos SET apuntados = @nuevo WHERE codigo = @codigo_curso AND profesor = @profesor;";

                cmd.Parameters.AddWithValue("@nuevo",apuntados + tipo_cambio);
                cmd.Parameters.AddWithValue("@codigo_curso", codigo_curso);
                cmd.Parameters.AddWithValue("@profesor", profesor);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<string> GetCursosProfesor(string profesor) {

        List<string> resultado = new List<string>{};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * FROM cursos WHERE profesor = @profesor;";

                cmd.Parameters.AddWithValue("@profesor", profesor);        

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                         resultado.Add(rdr.GetString("codigo"));
                    }
                }
            }
        }

        return resultado;
    }

    public List<string> GetCursosAlumno(string alumno) {

        List<string> resultado = new List<string>{};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT curso FROM alumno_curso WHERE alumno = @alumno;";

                cmd.Parameters.AddWithValue("@alumno", alumno);        

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                         resultado.Add(rdr.GetString("curso"));
                    }
                }
            }
        }

        return resultado;
    }

    public List<string> GetAlumnosDeCurso<K>(K codigo) {

        List<string> resultado = new List<string>{};

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT alumno FROM cursos WHERE curso = @curso;";

                cmd.Parameters.AddWithValue("@curso", codigo);        

                conn.Open();

                using(MySqlDataReader rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                         resultado.Add(rdr.GetString("alumno"));
                    }
                }
            }
        }

        return resultado;
    }
}
}