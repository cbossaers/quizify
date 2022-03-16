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

            //dal.AddEntidad(new Profesor("luis", "luisseña", "dsufbi", "sdnfs"));

            List<dynamic> lista = new List<dynamic> {1,"limon", "pera", "hola"};
            PreguntaTest preg = new PreguntaTest(3,"hola don amigo", lista, 1, "luis", "Aqrs");

            dal.AddPregunta(preg);

            List<dynamic> list = new List<dynamic> {"luis", "test", "1", "Aqrs"};
            DataTable res = dal.GetPreguntas(list);

            foreach (DataRow row in res.Rows) { 
                Console.WriteLine(row["id"]); 
                Console.WriteLine(row["enunciado"]); 
                Console.WriteLine(row["tipo"]); 
            }
        }
    }
}
