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

            Profesor prof = servicio.GetEntidadById("angel");
            List<int> lista = servicio.GetExamenes(prof);

            foreach(int x in lista) {
                Console.WriteLine(servicio.GetExamenById(x).fecha_fin);
            }
        }
    }
}
