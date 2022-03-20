using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Globalization;
using Quizify.Services;

namespace AppTest
{
    class Program {
        
        static void Main(string[] args) {
            DAL dal = new DAL();
            Servicio servicio = new Servicio(dal);

            List<dynamic> filtro = new List<dynamic> {"angel", null, null, null};
            List<int> lista = servicio.GetPreguntas(filtro);

            foreach(int x in lista) {
                Console.WriteLine(x);
            }
        }
    }
}
