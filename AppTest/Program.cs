using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Globalization;
using Quizify.Services;

namespace AppTest {
    class Program {
        
        static void Main(string[] args) {

            DALAlumno alumno = new DALAlumno();
            DALProfesor profesor = new DALProfesor();
            DALPregunta pregunta = new DALPregunta();
            DALExamen examen = new DALExamen();
            DALCurso curso = new DALCurso();

            NuevoServicio service = new NuevoServicio();

            List<string> res = new List<string>();
            
            int x = 1010;

            for(int i = 0; i < 5; i++) {
                res.Add((x%10).ToString());
                x/=10;
            }

            foreach(string s in res) {
                Console.WriteLine(s);
            }
        }
    }
}