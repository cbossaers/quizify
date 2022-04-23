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

            //https://en.wikipedia.org/wiki/SQL_injection#Incorrectly_constructed_SQL_statements
            //https://stackoverflow.com/questions/75401/what-are-the-uses-of-using-in-c

            /*Alumno al1 = new Alumno("cristan@gmail.com", "cristianseña", "Cristian", "Rodriguez", "Primero");
            Alumno al2 = new Alumno("santiago@gmail.com", "santiseña", "Santiago", "Cunillera", "Segundo");
            Alumno al3 = new Alumno("cesar@gmail.com", "cesarseña", "Cesar", "Ayuso", "Tercero");
            Alumno al4 = new Alumno("paul@gmail.com", "paulseña", "Paul", "Lopez", "Segundo");

            servicio.addEntidad(al1);
            servicio.addEntidad(al2);
            servicio.addEntidad(al3);
            servicio.addEntidad(al4);

            Profesor p1 = new Profesor("patricio@gmail.com", "patriseña", "Patricio", "Estrella");
            Profesor p2 = new Profesor("antonio@gmail.com", "antonioseña", "Antonio", "Martinez");

            servicio.addEntidad(p1);
            servicio.addEntidad(p2);*/

            //List<dynamic> lista1 = new List<dynamic> {3, "Pera", "Limón", "Manzana", "Árbol", "Baguette"};
            /*List<dynamic> lista2 = new List<dynamic> {1, "Azul", "Rojo", "Verde"};
            List<dynamic> lista3 = new List<dynamic> {0, "Movil", "PC", "Portatil", "Reloj"};

            PreguntaTest PT1 = new PreguntaTest(1, "Enunciado1", lista1,2,"patricio@gmail.com", "GPR");
            PreguntaTest PT2 = new PreguntaTest(1, "Enunciado2", lista2,2,"antonio@gmail.com", "PSW");
            PreguntaTest PT3 = new PreguntaTest(1, "Enunciado3", lista3,2,"antonio@gmail.com", "TSR");

            PreguntaVF PVF1 = new PreguntaVF(1,"Enunciado4", 0, 1, "patricio@gmail.com", "AIC");
            PreguntaVF PVF2 = new PreguntaVF(1,"Enunciado5", 1, 2, "antonio@gmail.com", "EDA");
            PreguntaVF PVF3 = new PreguntaVF(1,"Enunciado6", 0, 1, "patricio@gmail.com", "IIP");

            servicio.AddPreguntaTest(PT1);
            servicio.AddPreguntaTest(PT2);
            servicio.AddPreguntaTest(PT3);

            servicio.AddPreguntaVF(PVF1);
            servicio.AddPreguntaVF(PVF2);
            servicio.AddPreguntaVF(PVF3);

            List<int> listapreg = new List<int> {3,1,5,5,1,7,7,1,2};

            Examen ex1 = new Examen(1, "Titulo2", "Descripción2", "Segundo", "antonio@gmail.com", 120, DateTime.Now, DateTime.Now,
            DateTime.Now.AddDays(3), 3, 0,0,0, listapreg);

            servicio.AddExamen(ex1);*/

            /*PreguntaTest PT5 = new PreguntaTest(1, "Enunciado1", lista1,2,"patricio@gmail.com", "GPR");
            servicio.AddPreguntaTest(PT5);*/

            //Profesor p1 = new Profesor("f", "f", "f", "f");
            //servicio.addEntidad(p1);

            int a = 10011;
            int b = 00111;

            int c = 0;

            int sum = 0;
            double total = 0.0;

            a *= 2;

            for(int i = 0; i < 5; i++) {
                
                if(a % 10 == 2) { total++; }

                c = (a % 10) - (b % 10);
                if(c < 2) {
                    sum+=c;
                }

                a /= 10;
                b /= 10;
            }

            if(sum < 0) { sum = 0; }

            total = sum / total;

            Console.WriteLine(total);
        }
    }
}
