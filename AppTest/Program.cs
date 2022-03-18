using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Globalization;

namespace AppTest
{
    class Program {
        
        static void Main(string[] args) {
            DAL dal = new DAL();

            List<int> lista = new List<int> {2,1,1,3,1,2,4,1,9};

            Examen ex = new Examen(3,"La materia","muchas cosas bonitas", "tercero", "angel", 35,
                DateTime.Now,DateTime.Now,DateTime.Now, 3,0,0,1, lista);

            //dal.AddExamen(ex);

            /*foreach (DataRow row in res.Rows) { 
                Console.WriteLine(row["id"]); 
                Console.WriteLine(row["enunciado"]); 
                Console.WriteLine(row["tipo"]); 
            }*/
        }
    }
}
