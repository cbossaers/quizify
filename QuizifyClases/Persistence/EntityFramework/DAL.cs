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
    public void AddEntidad(dynamic entidad) {
        string consulta_entidad = "";
        string consulta_especifica = "";
        string tipo = entidad.GetType().ToString();
        
        switch(tipo){
            case("Quizify.Entities.Alumno"): 
                consulta_entidad = "INSERT into PSWC.entidad(correo,tipo) values('" + entidad.correo + "','alumno');";
                consulta_especifica = "INSERT into PSWC.alumno(correo,contraseña,nombre,apellidos) values('" 
                    + entidad.correo + "','" + entidad.contraseña + "','" + entidad.nombre + "','" + entidad.apellidos + "');";
                break;

            case("Quizify.Entities.Profesor"): 
                consulta_entidad = "INSERT into PSWC.entidad(correo,tipo) values('" + entidad.correo + "','profesor');";
                consulta_especifica = "INSERT into PSWC.profesor(correo,contraseña,nombre,apellidos,almacenamiento,quizes) values('" 
                    + entidad.correo + "','" + entidad.contraseña + "','" + entidad.nombre + "','" + entidad.apellidos + "',100,20);";
                break;

            case("Quizify.Entities.Institucion"): 
                consulta_entidad = "INSERT into PSWC.entidad(correo,tipo) values('" + entidad.correo + "','institucion');";
                consulta_especifica = "INSERT into PSWC.institucion(correo,contraseña,nombre,quizes) values('" 
                    + entidad.correo + "','" + entidad.contraseña + "','" + entidad.nombre + "',0);";
                break;
        }
        
        conn.Open();
        MySqlCommand cmd = new MySqlCommand(consulta_entidad, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();

        conn.Open();
        MySqlCommand cmd2 = new MySqlCommand(consulta_especifica, conn);
        MySqlDataReader rdr2 = cmd2.ExecuteReader();
        conn.Close();
    }

    public void AddPregunta(dynamic pregunta) {
        int id = UltimoIdPregunta() + 1;

        string consulta_pregunta = "";
        string consulta_especifica = "";
        string tipo = pregunta.GetType().ToString();
        
        switch(tipo){
            case("Quizify.Entities.PreguntaTest"): 
                consulta_pregunta = "INSERT into PSWC.pregunta(id,ver,enunciado,tipo,dificultad,autor,tema) values(" + id + ",1,'" + pregunta.GetEnunciado() 
                    + "','test'," + pregunta.GetDificultad() + ",'" + pregunta.GetAutor() + "','" + pregunta.GetTema() +  "');";
                consulta_especifica = "INSERT into PSWC.pregunta_test(id,ver,opc_a,opc_b,opc_c,opc_d,opc_e,correcta) values(" + id + ",1,'" 
                    + pregunta.GetOpcA() + "','" + pregunta.GetOpcB() + "','" + pregunta.GetOpcC() + "','" + pregunta.GetOpcD() + "','" 
                    + pregunta.GetOpcE() + "'," + pregunta.GetCorrecta() + ");";
                break;

            case("Quizify.Entities.PreguntaVF"): 
                consulta_pregunta = "INSERT into PSWC.pregunta(id,ver,enunciado,tipo,dificultad,autor,tema) values(" + id + ",1,'" + pregunta.GetEnunciado() 
                    + "','test'," + pregunta.GetDificultad() + ",'" + pregunta.GetAutor() + "','" + pregunta.GetTema() +  "');";
                consulta_especifica = "INSERT into PSWC.pregunta_vf(id,ver,correcta) values(" + id + ",1," + pregunta.GetCorrecta() + ");";
                break;
        }
        
        conn.Open();
        MySqlCommand cmd = new MySqlCommand(consulta_pregunta, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();

        conn.Open();
        MySqlCommand cmd2 = new MySqlCommand(consulta_especifica, conn);
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
            aux = int.Parse(row["id"].ToString());
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

    public void EliminarPregunta(int id) {
        conn.Open();

        string consulta_pregunta = "DELETE FROM PSWC.pregunta WHERE id='" + id + "';";
        MySqlCommand cmd = new MySqlCommand(consulta_pregunta, conn);
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
                        data.Rows[0]["nombre"].ToString(), data.Rows[0]["apellidos"].ToString());
                case("profesor"):
                    return new Profesor(data.Rows[0]["correo"].ToString(), data.Rows[0]["contraseña"].ToString(), 
                        data.Rows[0]["nombre"].ToString(), data.Rows[0]["apellidos"].ToString(), 
                        float.Parse(data.Rows[0]["almacenamiento"].ToString()), int.Parse(data.Rows[0]["quizes"].ToString()));
                case("institucion"):
                    return new Institucion(data.Rows[0]["correo"].ToString(), data.Rows[0]["contraseña"].ToString(), 
                        data.Rows[0]["nombre"].ToString(), int.Parse(data.Rows[0]["quizes"].ToString()));
            }  

        conn.Close();
        return 0;
    }

    public dynamic GetPregunta(int id, int ver) {
        string tipo = GetTipoPregunta(id);
        List<dynamic> lista = new List<dynamic> {};

        conn.Open();

        string consulta = "SELECT * from PSWC.pregunta_" + tipo + " WHERE id= " + id + " AND ver= " + ver + ";"; 

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);

        switch(tipo){
            case("test"): 
                lista.Add(int.Parse(data.Rows[0]["correcta"].ToString()));
                lista.Add(data.Rows[0]["opc_a"].ToString());
                lista.Add(data.Rows[0]["opc_b"].ToString());
                lista.Add(data.Rows[0]["opc_c"].ToString());
                if(data.Rows[0]["opc_d"].ToString() != null) { lista.Add(data.Rows[0]["opc_d"].ToString()); }
                if(data.Rows[0]["opc_e"].ToString() != null) { lista.Add(data.Rows[0]["opc_e"].ToString()); }

                return new PreguntaTest(int.Parse(data.Rows[0]["id"].ToString()), GetEnunciado(id, ver), 
                    lista, GetDificultad(id, ver), GetAutor(id,ver), GetTema(id, ver), int.Parse(data.Rows[0]["ver"].ToString()));

            case("vf"):
                return new PreguntaVF(int.Parse(data.Rows[0]["id"].ToString()), GetEnunciado(id, ver), 
                    int.Parse(data.Rows[0]["correcta"].ToString()), GetDificultad(id, ver), GetAutor(id, ver), GetTema(id, ver), int.Parse(data.Rows[0]["ver"].ToString()));
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

    public string GetEnunciado(int id, int ver) {
        string consulta = "SELECT enunciado FROM PSWC.pregunta WHERE id= " + id + " AND ver= " + ver + ";";

        MySqlCommand cmd = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                consulta = rdr.GetString("enunciado");
        }
        return consulta;
    }

    public int GetDificultad(int id, int ver) {
        string consulta = "SELECT dificultad FROM PSWC.pregunta WHERE id= " + id + " AND ver= " + ver + ";";
        int res = 0;

        MySqlCommand cmd = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                res = int.Parse(rdr.GetString("enunciado"));
        }
        return res;
    }

    public string GetAutor(int id, int ver) {
        string consulta = "SELECT autor FROM PSWC.pregunta WHERE id= " + id + " AND ver= " + ver + ";";

        MySqlCommand cmd = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                consulta = rdr.GetString("enunciado");
        }
        return consulta;
    }

    public string GetTema(int id, int ver) {
        string consulta = "SELECT tema FROM PSWC.pregunta WHERE id= " + id + " AND ver= " + ver + ";";

        MySqlCommand cmd = new MySqlCommand(consulta, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
                consulta = rdr.GetString("enunciado");
        }
        return consulta;
    }
    
    //filtros[autor, tipo('test','vf','desarrollo'), dificultad(0,1,2), tema(string)]
    public DataTable GetPreguntas(List<dynamic> filtros) {
        conn.Open();

        string consulta = "SELECT * from PSWC.pregunta" + " WHERE autor= '" + filtros[0] + "' AND tipo= '" + filtros[1] + "' AND dificultad= " 
            + filtros[2] + " AND tema= '" + filtros[3] + "';"; 

        MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conn);
        DataTable data = new DataTable();
        adapter.Fill(data);
        
        conn.Close();

        return data;
    }
}}