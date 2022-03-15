using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Entities;

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

        public ICollection<dynamic> GetPreguntas(List<dynamic> lista);
        public ICollection<dynamic> GetEntidades();
        public ICollection<dynamic> GetExamenes();

    }
}