using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Entities;
using Quizify.Persistence;

namespace Quizify.Services
{
    public class Servicio : IServicio
    {
        private readonly DAL dal;
        public Servicio(DAL dal)
        {
            this.dal = dal;
        }
        public void AddPreguntaVF(PreguntaVF preguntaFV)
        {
            if (dal.GetPregunta(preguntaFV.GetId(),preguntaFV.GetVersion()) == null)
            {
                dal.AddPregunta(preguntaFV);
            }
            else throw new ServicioException("La pregunta con Id " + preguntaFV.GetId() + " versión: " + preguntaFV.GetVersion() + " ya existe");
        }
        public void AddPreguntaTest(PreguntaTest preguntaTest)
        {
            if (dal.GetPregunta(preguntaTest.GetId(), preguntaTest.GetVersion()) == null)
            {
                dal.AddPregunta(preguntaTest);
            }
            else throw new ServicioException("La pregunta con Id " + preguntaTest.GetId() + " versión: " + preguntaTest.GetVersion() + " ya existe");
        }
        public void AddAlumno(Alumno alumno)
        {
            if (dal.GetEntidad(alumno.GetCorreo()) == null)
            {
                dal.AddEntidad(alumno);
            }
            else throw new ServicioException("El alumno con correo " + alumno.GetCorreo() + " ya existe");
        }
        public void AddProfesor(Profesor profesor)
        {
            if (dal.GetEntidad(profesor.GetCorreo()) == null)
            {
                dal.AddEntidad(profesor);
            }
            else throw new ServicioException("El profesor con correo " + profesor.GetCorreo() + " ya existe");
        }
        public void AddInstitucion(Institucion institucion)
        {
            if (dal.GetEntidad(institucion.GetCorreo()) == null)
            {
                dal.AddEntidad(institucion);
            }
            else throw new ServicioException("La institución con correo " + institucion.GetCorreo() + " ya existe");
        }
        public void AddExamen(Examen examen)
        {
            if ()
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El examen con Id " + examen.GetId() + " ya existe");
        }
        public PreguntaVF GetPreguntaVFById(int Id, int version)
        {
            PreguntaVF pregunta = dal.GetPregunta(Id, version);
            if (pregunta != null) return pregunta;
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
        }
        public PreguntaTest GetPreguntaTestById(int Id, int version)
        {
            PreguntaTest pregunta = dal.GetPregunta(Id, version);
            if (pregunta != null) return pregunta;
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
        }
        public Alumno GetAlumnoById(string correo)
        {
            Alumno alumno = dal.GetEntidad(correo);
            if (alumno != null) return alumno;
            else throw new ServicioException("El alumno con correo " + correo + " no existe");
        }
        public Profesor GetProfesorById(string correo)
        {
            Profesor profesor = dal.GetEntidad(correo);
            if (profesor != null) return profesor;
            else throw new ServicioException("El profesor con correo " + correo + " no existe");
        }
        public Institucion GetInstitucionById(string correo)
        {
            Institucion institucion = dal.GetEntidad(correo);
            if (institucion != null) return institucion;
            else throw new ServicioException("La institución con correo " + correo + " no existe");
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
