using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Text;

namespace Quizify.Services
{
    public interface IServicio
    {
        public void AddPreguntaVF(PreguntaVF preguntaVF);
        public void AddPreguntaTest(PreguntaTest preguntaTest);
        public void AddAlumno(Alumno alumno);
        public void AddProfesor(Profesor profesor);
        public void AddInstitucion(Institucion institucion);
        public void AddExamen(Examen examen);

        public PreguntaVF GetPreguntaVFById(int Id, int version);
        public PreguntaTest GetPreguntaTestById(int Id, int version);
        public Alumno GetAlumnoById(string correo);
        public Profesor GetProfesorById(string correo);
        public Institucion GetInstitucionById(string correo);
        public Examen GetExamenById(int Id);

        public DataTable GetPreguntas(List<dynamic> lista);
        //filtros[autor(el correo), tipo('test','vf','desarrollo'), dificultad(0,1,2), tema(string)]
        public ICollection<dynamic> GetEntidades();
        public ICollection<dynamic> GetExamenes();

    }
}