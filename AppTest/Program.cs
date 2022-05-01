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

            //curso.AddAlumnoACurso("santiago@gmail.com", "3IS12", "patricio@gmail.com");

            List<string> lista = curso.GetCursosProfesor("antonio@gmail.com");

            foreach(string x in lista) {
                Console.WriteLine(x);
            }
        }
    }
}