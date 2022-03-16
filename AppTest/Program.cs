using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;

namespace AppTest
{
    class Program {
        
        static void Main(string[] args) {
            DAL dal = new DAL();

            //filtros[autor, tipo('test','vf','desarrollo'), dificultad(0,1,2), tema(string)]
            /*dal.AddEntidad(new Profesor("angel", "luisseña", "dsufbi", "sdnfs"));

            List<dynamic> lista = new List<dynamic> {1,"limon", "pera", "hola"};

            dal.AddPregunta(new PreguntaTest(3,"PregTest1", lista, 1, "luis", "Aqrs"));
            dal.AddPregunta(new PreguntaTest(3,"PregTest2", lista, 1, "angel", "Cosas"));
            dal.AddPregunta(new PreguntaTest(3,"PregTest3", lista, 2, "luis", "Jersey"));
            dal.AddPregunta(new PreguntaVF(3,"PregVF1", 1, 0, "angel", "Aqrs"));
            dal.AddPregunta(new PreguntaVF(3,"PregVF2", 1, 2, "angel", "Cosas"));
            dal.AddPregunta(new PreguntaVF(3,"PregVF3", 1, 1, "luis", "Cosas"));*/

            List<dynamic> list = new List<dynamic> {"angel", null, 2, null};
            DataTable res = dal.GetPreguntas(list);

            foreach (DataRow row in res.Rows) { 
                Console.WriteLine(row["id"]); 
                Console.WriteLine(row["enunciado"]); 
                Console.WriteLine(row["tipo"]); 
            }
        }
    }
}
