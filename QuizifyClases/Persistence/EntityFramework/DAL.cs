using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;

namespace Quizify.Persistence {

public class DAL {
    static string connStr = "server=88.17.214.52;user=GrupoC;database=PSWC;port=3306;password=GrupoC";
    MySqlConnection conn = new MySqlConnection(connStr);
    public void addEntidad(string correo, string contraseña, string tipo, string nombre, string apellidos=null) {
        string entidad = "INSERT into PSWC.entidad(correo,tipo) values('" + correo + "','" + tipo + "');";
        string consulta = "";
        
        switch(tipo){
            case("alumno"): 
                consulta = "INSERT into PSWC.alumno(correo,contraseña,nombre,apellidos) values('" 
                    + correo + "','" + contraseña + "','" + nombre + "','" + apellidos + "');";
                break;

            case("profesor"): 
                consulta = "INSERT into PSWC.profesor(correo,contraseña,nombre,apellidos,almacenamiento,quizes) values('" 
                    + correo + "','" + contraseña + "','" + nombre + "','" + apellidos + "',100,20);";
                break;

            case("institucion"): 
                consulta = "INSERT into PSWC.institucion(correo,contraseña,nombre,quizes) values('" 
                    + correo + "','" + contraseña + "','" + nombre + "',0);";
                break;
        }
        
        conn.Open();
        MySqlCommand cmd = new MySqlCommand(entidad, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();

        conn.Open();
        MySqlCommand cmd2 = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr2 = cmd2.ExecuteReader();
        conn.Close();
    }

    public void modificarContraseña(string correo, string contraseña){
        string tipo = getTipoEntidad(correo);

        conn.Open();

        string accion = "UPDATE PSWC." + tipo + " SET contraseña ='" + contraseña + "' WHERE correo='" + correo + "';"; 
        MySqlCommand cmd = new MySqlCommand(accion, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        conn.Close();
    }

    public void eliminarEntidad(string correo){
        conn.Open();

        string consulta_entidad = "DELETE from PSWC.entidad WHERE correo='" + correo + "';";
        MySqlCommand cmd = new MySqlCommand(consulta_entidad, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        conn.Close();
    }

    public dynamic getEntidad(string correo) {
        string tipo = getTipoEntidad(correo);

        conn.Open();

        string consulta = "SELECT * from PSWC." + tipo + " WHERE correo='" + correo + "';";   

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);

        /*foreach (DataRow row in data.Rows) { 
            Console.WriteLine(row["correo"]); 
            Console.WriteLine(row["contraseña"]); 
            Console.WriteLine(row["nombre"]); 
        }*/
        switch(tipo){
            
                case("alumno"): 
                    return new Alumno(data.Rows[0]["correo"].ToString(), data.Rows[0]["contraseña"].ToString(), 
                        data.Rows[0]["nombre"].ToString(), data.Rows[0]["apellidos"].ToString(), "alumno");
                case("profesor"):
                    return new Profesor(data.Rows[0]["correo"].ToString(), data.Rows[0]["contraseña"].ToString(), 
                        data.Rows[0]["nombre"].ToString(), data.Rows[0]["apellidos"].ToString(), 
                        float.Parse(data.Rows[0]["almacenamiento"].ToString()), int.Parse(data.Rows[0]["quizes"].ToString()), "profesor");
                case("institucion"):
                    return new Institucion(data.Rows[0]["correo"].ToString(), data.Rows[0]["contraseña"].ToString(), 
                        data.Rows[0]["nombre"].ToString(), int.Parse(data.Rows[0]["quizes"].ToString()), "institucion");
            }  

        conn.Close();
        return 0;
    }

    public dynamic getPregunta(int id, int ver) {
        conn.Open();

        string tipo = "SELECT * FROM PSWC.entidad WHERE id= '" + id + "' and ver= '" + ver + "';";
        string enunciado = "";
        List<string> respuestas = new List<string>();
        int correcta = 0;

        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                tipo = rdr.GetString("tipo");
                enunciado = rdr.GetString("enunciado");
        }

        string consulta = "SELECT * from PSWC." + tipo + "WHERE id= '" + id + "' and ver= '" + ver + "';";

        MySqlCommand cmd2 = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr2 = cmd.ExecuteReader();

        while (rdr2.Read()) {
                enunciado = rdr2.GetString("enunciado");
                if(tipo.Equals("Test")) {
                    respuestas.Add(rdr2.GetString("opc_a"));
                    respuestas.Add(rdr2.GetString("opc_b"));
                    respuestas.Add(rdr2.GetString("opc_c"));
                    respuestas.Add(rdr2.GetString("opc_d"));
                    respuestas.Add(rdr2.GetString("opc_e"));
                    correcta = rdr2.GetInt32("correcta");

                } else if(tipo.Equals("VF")) { correcta = rdr2.GetInt32("correcta"); }
        }
        
        return true;
    }

    public string getTipoEntidad(string correo) {
        conn.Open();

        string tipo = "SELECT tipo FROM PSWC.entidad WHERE correo= '" + correo + "';";

        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                tipo = rdr.GetString("tipo");
        }

        conn.Close();

        return tipo;
    }
    public string getTipoPregunta(int id, int ver) {
        conn.Open();

        string tipo = "SELECT tipo FROM PSWC.pregunta WHERE id= '" + id + "' AND ver= '" + ver + "';";

        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                tipo = rdr.GetString("tipo");
        }

        conn.Close();
        
        return tipo;
    }
}}