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

            List<dynamic> lista = examen.EstadisticasExamen(1);

            Console.WriteLine(lista[0]);
            if(lista[0] > 0) {
                Console.WriteLine(lista[1]);
                Console.WriteLine(lista[2]);
                
                foreach(double x in lista[3]) {
                    Console.WriteLine(x);
                }
            }
        }
    }
}