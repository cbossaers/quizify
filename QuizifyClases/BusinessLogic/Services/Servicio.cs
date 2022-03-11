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
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La pregunta con Id " + preguntaFV.GetId() + " ya existe");
        }
        public void AddPreguntaTest(PreguntaTest preguntaTest)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La pregunta con Id " + preguntaTest.GetId() + " ya existe");
        }
        public void AddAlumno(Alumno alumno)
        {
            if (true)
            {
                dal.AddEntidad(alumno.correo, alumno.contraseña, alumno.tipo, alumno.nombre, alumno.apellidos);
            }
            else throw new ServicioException("El alumno con correo " + alumno.GetCorreo() + " ya existe");
        }
        public void AddProfesor(Profesor profesor)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El profesor con correo " + profesor.GetCorreo() + " ya existe");
        }
        public void AddInstitucion(Institucion institucion)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("La institución con correo " + institucion.GetCorreo() + " ya existe");
        }
        public void AddExamen(Examen examen)
        {
            if (true)
            {
                //no existe el mismo Id
            }
            else throw new ServicioException("El examen con Id " + examen.GetId() + " ya existe");
        }
        public PreguntaVF GetPreguntaVFById(int Id, int version)
        {
            if (true)
            {
                //Id existe
            }
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
            return null;
        }
        public PreguntaTest GetPreguntaTestById(int Id, int version)
        {
            if (true)
            {
                //Id existe
            }
            else throw new ServicioException("La pregunta con Id " + Id + " no existe");
            return null;
        }
        public Alumno GetAlumnoById(string correo)
        {
            if (true)
            {
                //correo existe
            }
            else throw new ServicioException("El alumno con correo " + correo + " no existe");
            return null;
        }
        public Profesor GetProfesorById(string correo)
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
