using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Globalization;
using Quizify.Services;
using System.Timers;

namespace AppTest {
    class Program {

        private static Timer t;
        private static int elapsed;
        
        static void Main(string[] args) {

            //string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

            DALAlumno alumno = new DALAlumno();
            DALProfesor profesor = new DALProfesor();
            DALPregunta pregunta = new DALPregunta();
            DALExamen examen = new DALExamen();
            DALCurso curso = new DALCurso();

            NuevoServicio service = new NuevoServicio();

            FabricaExamenes fabrica = new FabricaExamenes();

            List<int> listaex = new List<int>() {1, 1, 1, 2, 1, 1, 3, 1, 1};
            
            //service.AddExamen(new Examen(examen.UltimoIdExamen()+1, "demo", "demo", "PSW", "patricio@gmail.com", 50, DateTime.Now, DateTime.Now, DateTime.Now.AddDays(1), 1, 1, 1, 0, listaex, "Inactivo", "Normal", ""));
            service.CalcularNotaExamen(3,"cristian@gmail.com");
            //service.AddExamen(new Examen(examen.UltimoIdExamen(), "demo", "demo", "PSW", "patricio@gmail.com", 50, DateTime.Now, DateTime.Now, DateTime.Now.AddDays(1), 1, 1, 1, 0, listaex, "Inactivo", "Normal", ""));
        }
    }
    
}