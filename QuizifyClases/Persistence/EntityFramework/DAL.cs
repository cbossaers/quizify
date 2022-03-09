using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Quizify.Persistence {

public class DAL {
    string connStr = "server=88.17.214.52;user=GrupoC;database=PSWC;port=3306;password=GrupoC";
    public void addEntidad(string correo, string contraseña, string tipo, string nombre, string apellidos) {
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();

        string entidad = "INSERT into PSWC.entidad(correo,tipo) values(" + correo + "," + tipo + ");";
        string consulta = "";
        
        switch(tipo){
            case("alumno"): 
                consulta = "INSERT into PSWC.alumno(correo,contraseña,nombre,apellidos) values(" 
                    + correo + "," + contraseña + "," + nombre + "," + apellidos + ");";
                break;

            case("profesor"): 
                consulta = "INSERT into PSWC.profesor(correo,contraseña,nombre,apellidos,almacenamiento,quizes) values(" 
                    + correo + "," + contraseña + "," + nombre + "," + apellidos + ",100,20);";
                break;

            case("institucion"): 
                consulta = "INSERT into PSWC.institucion(correo,contraseña,nombre,quizes) values(" 
                    + correo + "," + contraseña + "," + nombre + ",0);";
                break;
        }
        
    
        MySqlCommand cmd = new MySqlCommand(entidad, conn);
        MySqlCommand cmd2 = new MySqlCommand(consulta, conn);

        MySqlDataReader rdr = cmd.ExecuteReader();
        MySqlDataReader rdr2 = cmd2.ExecuteReader();

        conn.Close();
    }

    public void modificarContraseña(string correo, string contraseña){
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();

        string tipo = "SELECT tipo FROM PSWC.entidad WHERE correo = " + correo + ";";
        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        string accion = "UPDATE PSWC." + tipo + "SET contraseña ='" + contraseña + "' WHERE correo='" + correo + "' ;"; 
        MySqlCommand cmd2 = new MySqlCommand(accion, conn);
        MySqlDataReader rdr2 = cmd2.ExecuteReader();

        conn.Close();
    }

    public void eliminarEntidad(string correo){
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();

        string tipo = "SELECT tipo FROM PSWC.entidad WHERE correo= '" + correo + "';";

        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                tipo = rdr.GetString("tipo");
        }

        string consulta_entidad = "DELETE from PSWC.entidad WHERE correo='" + correo + "';";
        string consulta_clase = "DELETE from PSWC." + tipo + "WHERE correo='" + correo + "';";
        
        MySqlCommand cmd2 = new MySqlCommand(consulta_entidad, conn);
        MySqlCommand cmd3 = new MySqlCommand(consulta_clase, conn);
        MySqlDataReader rdr2 = cmd.ExecuteReader();
        MySqlDataReader rdr3 = cmd.ExecuteReader();

        conn.Close();
    }
}}