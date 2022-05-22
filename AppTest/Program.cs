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

            SetTimer();

            t.Stop();
            t.Dispose();
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            elapsed++;
        }

        public static void SetTimer() {
            t = new Timer(1000);
            t.Elapsed += OnTimedEvent;

            t.AutoReset = true;
            t.Enabled = true;
        }
    }
    
}