﻿using System;
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
    public void AddEntidad(string correo, string contraseña, string tipo, string nombre, string apellidos=null) {
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

    public async void AddPregunta(string enunciado, string tipo, List<string> lista) {
        int id = UltimoIdPregunta() + 1;
        
        string pregunta = "INSERT into PSWC.pregunta(id,ver) values(" + id + ",1,'" + enunciado +"','" + tipo + "');";
        string consulta = "";
        
        switch(tipo){
            case("Test"): 
                consulta = "INSERT into PSWC.pregunta_test(id,ver,opc_a,opc_b,opc_c,opc_d,opc_e,correcta) values(" + id + ",1,'" + "','" 
                    + lista[1] + "','" + lista[2] + "','" + lista[3] + "','" + lista[4] + "','" + lista[5] + "','" + lista[0] + "';";
                break;

            case("VF"): 
                consulta = "INSERT into PSWC.pregunta_test(id,ver,correcta) values(" + id + ",1,'" + "','" 
                    + lista[0] + "';";
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


    public int UltimoIdPregunta(){
        conn.Open();
        string consulta = "SELECT id FROM PSWC.pregunta;";
        int id = 0; int aux = 0;

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);

        foreach (DataRow row in data.Rows) { 
            aux = int.Parse(row["ver"].ToString());
            if(aux > id) { id = aux; }
        }
        conn.Close();
        return id;
    }
    public int UltimaVersionPregunta(int id) {
        string tipo = GetTipoPregunta(id);

        conn.Open();

        string consulta = "SELECT ver FROM PSWC.pregunta WHERE id= " + id + ";";
        int version = 0; int aux = 0;

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);

        foreach (DataRow row in data.Rows) { 
            aux = int.Parse(row["ver"].ToString());
            if(aux > version) { version = aux; }
        }
        conn.Close();
        return version;
    }

    public void ModificarContraseña(string correo, string contraseña){
        string tipo = GetTipoEntidad(correo);

        conn.Open();

        string accion = "UPDATE PSWC." + tipo + " SET contraseña ='" + contraseña + "' WHERE correo='" + correo + "';"; 
        MySqlCommand cmd = new MySqlCommand(accion, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        conn.Close();
    }

    public void EliminarEntidad(string correo){
        conn.Open();

        string consulta_entidad = "DELETE FROM PSWC.entidad WHERE correo='" + correo + "';";
        MySqlCommand cmd = new MySqlCommand(consulta_entidad, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        conn.Close();
    }

    public dynamic GetEntidad(string correo) {
        string tipo = GetTipoEntidad(correo);

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

    public dynamic GetPregunta(int id, int ver) {
        string tipo = GetTipoPregunta(id);
        List<string> lista = null;

        conn.Open();

        string consulta = "SELECT * from PSWC." + tipo + " WHERE id= " + id + " AND ver= " + ver + ";"; 

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);

        switch(tipo){
                case("Test"): 
                    lista.Add(data.Rows[0]["correcta"].ToString());
                    lista.Add(data.Rows[0]["opc_a"].ToString());
                    lista.Add(data.Rows[0]["opc_b"].ToString());
                    lista.Add(data.Rows[0]["opc_c"].ToString());
                    if(data.Rows[0]["opc_d"].ToString() == null) { lista.Add(data.Rows[0]["opc_d"].ToString()); }
                    if(data.Rows[0]["opc_e"].ToString() == null) { lista.Add(data.Rows[0]["opc_e"].ToString()); }

                    return new PreguntaTest(int.Parse(data.Rows[0]["id"].ToString()), data.Rows[0]["enunciado"].ToString(), tipo, lista);
                case("VF"):
                    return new PreguntaVF(int.Parse(data.Rows[0]["id"].ToString()), data.Rows[0]["enunciado"].ToString(), tipo, int.Parse(data.Rows[0]["correcta"].ToString()));
            }  

        conn.Close();
        return 0;
    }

    public string GetTipoEntidad(string correo) {
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
    public string GetTipoPregunta(int id) {
        conn.Open();

        string tipo = "SELECT tipo FROM PSWC.pregunta WHERE id= " + id + ";";

        MySqlCommand cmd = new MySqlCommand(tipo, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                tipo = rdr.GetString("tipo");
        }

        conn.Close();
        
        return tipo;
    }
}}