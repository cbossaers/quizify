using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Entities;

namespace Quizify.Services
{
    public interface IServicio
    {
        public void addPreguntaVF(PreguntaVF preguntaVF);
        public void addPreguntaTest(PreguntaTest preguntaTest);
        public void addAlumno(Alumno alumno);
        public void addProfesor(Profesor profesor);
        public void addInstitucion(Institucion institucion);
        public void addExamen(Examen examen);

        public PreguntaVF getPreguntaVFById(int Id, int version);
        public PreguntaTest getPreguntaTestById(int Id, int version);
        public Alumno getAlumnoById(string correo);
        public Profesor getProfesorById(string correo);
        public Institucion GetInstitucionById(string correo);
        public Examen GetExamenById(int Id);

        public ICollection<dynamic> GetPreguntas();
        public ICollection<dynamic> GetEntidades();
        public ICollection<dynamic> GetExamenes();

    }
}