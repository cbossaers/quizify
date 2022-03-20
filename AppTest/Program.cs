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

            List<int> preg = new List<int> {2,1,6,3,1,8,5,1,2};

            servicio.AddExamen(new Examen(3,"titulo", "descripcion", "TSR", "angel", 90, DateTime.Now, 
                DateTime.Now, DateTime.Now.AddDays(3), 3, 0, 0, 1, preg));

            
        }
    }
}
