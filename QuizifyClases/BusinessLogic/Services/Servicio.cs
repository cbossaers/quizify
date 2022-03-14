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
        public void AddPreguntaVF(PreguntaVF preguntaVF)
        {
            try { dal.AddPregunta(preguntaVF); }
            catch (Exception)
            {
                throw new ServicioException("La pregunta con Id " + preguntaVF.GetId() + " versión: " + preguntaVF.GetVersion() + " ya existe");
            }
        }
        public void AddPreguntaTest(PreguntaTest preguntaTest)
        {
            try { dal.AddPregunta(preguntaTest);}
            catch(Exception) {
                throw new ServicioException("La pregunta con Id " + preguntaTest.GetId() + " versión: " + preguntaTest.GetVersion() + " ya existe");
                }
            
        }
        public void AddAlumno(Alumno alumno)
        {
            try { dal.AddEntidad(alumno); }
            catch (Exception)
            {
                throw new ServicioException("El alumno con correo " + alumno.GetCorreo() + " ya existe");
            }
        }
        public void AddProfesor(Profesor profesor)
        {
            try { dal.AddEntidad(profesor); }
            catch (Exception)
            {
                throw new ServicioException("El profesor con correo " + profesor.GetCorreo() + " ya existe");
            }
        }
        public void AddInstitucion(Institucion institucion)
        {
            try { dal.AddEntidad(institucion); }
            catch (Exception)
            {
                throw new ServicioException("La institución con correo " + institucion.GetCorreo() + " ya existe");
            }
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
            try { PreguntaVF pregunta = dal.GetPregunta(Id, version); return pregunta; }
            catch (Exception)
            {
                throw new ServicioException("La pregunta con Id " + Id + " no existe");
            }
        }
        public PreguntaTest GetPreguntaTestById(int Id, int version)
        {
            try { PreguntaTest pregunta = dal.GetPregunta(Id, version); return pregunta; }
            catch (Exception)
            {
                throw new ServicioException("La pregunta con Id " + Id + " no existe");
            }
        }
        public Alumno GetAlumnoById(string correo)
        {
            try { Alumno alumno = dal.GetEntidad(correo); return alumno; }
            catch (Exception)
            {
                throw new ServicioException("El alumno con correo " + correo + " no existe");
            }
        }
        public Profesor GetProfesorById(string correo)
        {
            try { Profesor profesor = dal.GetEntidad(correo); return profesor; }
            catch (Exception)
            {
                throw new ServicioException("El profesor con correo " + correo + " no existe");
            }
        }
        public Institucion GetInstitucionById(string correo)
        {
            try { Institucion institucion = dal.GetEntidad(correo); return institucion }
            catch (Exception)
            {
                throw new ServicioException("La institución con correo " + correo + " no existe");
            }
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
