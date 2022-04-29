using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALAlumno : IDAL2<Alumno> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    public void Add(Alumno alumno) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.entidad(correo,tipo) values(@correo,'alumno');";

                cmd.Parameters.AddWithValue("@correo", alumno.GetCorreo());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "INSERT into PSWC.alumno(correo,contraseña,nombre,apellidos,curso) "
                 + "values(@correo, @contraseña, @nombre, @apellidos);";

                cmd.Parameters.AddWithValue("@correo", alumno.GetCorreo());
                cmd.Parameters.AddWithValue("@contraseña", alumno.GetContraseña());
                cmd.Parameters.AddWithValue("@nombre", alumno.GetNombre());
                cmd.Parameters.AddWithValue("@apellidos", alumno.GetApellidos());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Get(string id) {

        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "SELECT * from PSWC.alumno WHERE correo = @correo;";

                cmd.Parameters.AddWithValue("@correo", id);
            }
        }
    }

    public void Eliminar(string id) {

    }

    public void Existe(int id) {

    }

}}