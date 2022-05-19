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

            //string connStr = "server=88.17.245.158;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

            DALAlumno alumno = new DALAlumno();
            DALProfesor profesor = new DALProfesor();
            DALPregunta pregunta = new DALPregunta();
            DALExamen examen = new DALExamen();
            DALCurso curso = new DALCurso();

            NuevoServicio service = new NuevoServicio();

            FabricaExamenes fabrica = new FabricaExamenes();

        }
        }
    }