using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Entities;

namespace Quizify.Services
{
    public interface IServicio
    {
        void addPreguntaVF(PreguntaVF preguntaVF);
        void addPreguntaTest(PreguntaTest preguntaTest);
        void addAlumno(Alumno alumno);
        void addProfesor(Profesor profesor);
        void addInstitucion(Institucion institucion);
        void addExamen(Examen examen);

        PreguntaVF getPreguntaVFById(int Id, int version);
        PreguntaTest getPreguntaTestById(int Id, int version);
        Alumno getAlumnoById(string correo);
        Profesor getProfesorById(string correo);
        Institucion GetInstitucionById(string correo);
        Examen GetExamenById(int Id);

    }
}