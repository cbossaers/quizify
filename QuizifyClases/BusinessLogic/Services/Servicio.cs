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
        public void addEntidad(dynamic user)
        {
            try { dal.AddEntidad(user); }
            catch (Exception e)
            {
                throw new ServicioException(e.ToString());
            }
        }
        public void AddExamen(Examen examen)
        {
            if (true)
            {
                dal.AddExamen(examen);
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
        public dynamic GetPreguntaById(int Id, int version) {
            return dal.GetPregunta(Id, version);
        }
        public string GetTipoPregunta(int id) {
            return dal.GetTipoPregunta(id);
        }
        public dynamic GetEntidadById(string correo)
        {
            try { dynamic entidad = dal.GetEntidad(correo); return entidad; }
            catch (Exception e)
            {
                throw new ServicioException(e.ToString());
            }
        }
        
        public Examen GetExamenById(int Id)
        {
            if (true)
            {
                return dal.GetExamen(Id);
            }
            else throw new ServicioException("El examen con Id " + Id + " no existe");
        }
        public List<int> GetPreguntas(List<dynamic> filtros)
        {
            return dal.GetPreguntas(filtros);
        }
        public ICollection<dynamic> GetEntidades()
        {
            return null;
        }
        public List<int> GetExamenes(dynamic persona)
        {
            return dal.GetExamenes(persona);
        }

        public void SubirRespuestas(List<dynamic> respuestas) {
            dal.SubirRespuestas(respuestas);
        }

        public string GetTipoEntidad(string correo) {
            return dal.GetTipoEntidad(correo);
        }
    }
}
