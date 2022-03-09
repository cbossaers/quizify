using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Entities;

namespace Quizify.Services
{
    public class Servicio : IServicio
    {
        public void addPreguntaVF(PreguntaVF preguntaFV)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La pregunta con Id " + preguntaFV.getId() + " ya existe");
        }
        public void addPreguntaTest(PreguntaTest preguntaTest)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La pregunta con Id " + preguntaTest.getId() + " ya existe");
        }
        public void addAlumno(Alumno alumno)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El alumno con correo " + alumno.getCorreo() + " ya existe");
        }
        public void addProfesor(Profesor profesor)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El profesor con correo " + profesor.getCorreo() + " ya existe");
        }
        public void addInstitucion(Institucion institucion)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La institución con correo " + institucion.getCorreo() + " ya existe");
        }
        public void addExamen(Examen examen)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El examen con Id " + examen.getId() + " ya existe");
        }
        public PreguntaVF getPreguntaVFById(int Id, int version)
        {
            if (true)
            {
                //Id existe
            }
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
            return null;
        }
        public PreguntaTest getPreguntaTestById(int Id, int version)
        {
            if (true)
            {
                //Id existe
            }
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
            return null;
        }
        public Alumno getAlumnoById(string correo)
        {
            if (true)
            {
                //correo existe
            }
            else throw new ServicioException("El alumno con correo " + correo + " no existe");
            return null;
        }
        public Profesor getProfesorById(string correo)
        {
            if (true)
            {
                //correo existe
            }
            else throw new ServicioException("El profesor con correo " + correo + " no existe");
            return null;
        }
        public Institucion GetInstitucionById(string correo)
        {
            if (true)
            {
                //correo existe
            }
            else throw new ServicioException("La institución con correo " + correo + " no existe");
            return null;
        }
        public Examen GetExamenById(int Id)
        {
            if (true)
            {
                //Id existe
            }
            else throw new ServicioException("El examen con Id " + Id + " no existe");
            return null;
        }
        public ICollection<dynamic> GetPreguntas()
        {
            return null;
        }
        public ICollection<dynamic> GetEntidades()
        {
            return null;
        }
        public ICollection<dynamic> GetExamenes()
        {
            return null;
        }
    }
}
