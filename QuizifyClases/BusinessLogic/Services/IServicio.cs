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
        //Atributos: id, nombre, titulo, descrpicion, curso, autor, fecha_creac, fecha_ini, fecha_fin, intentos (numero), 
        //volver_atras (0 = no, 1 = si), errores_restan (0 = no, 1 = si), mostrar_resultados (0 = no, 1 = si), preguntas.
        //preguntas[i] = id_pregunta, preguntas[i+1] = version_pregunta, preguntas[i+2] = puntuacion

        public PreguntaVF GetPreguntaVFById(int Id, int version);
        public PreguntaTest GetPreguntaTestById(int Id, int version);
        public dynamic GetPreguntaById(int Id, int version);
        public Alumno GetAlumnoById(string correo);
        public Profesor GetProfesorById(string correo);
        public Institucion GetInstitucionById(string correo);
        public Examen GetExamenById(int Id);
        string GetTipoPregunta(int id);

        public List<int> GetPreguntas(List<dynamic> filtros);
        //filtros[autor(el correo), tipo('test','vf','desarrollo'), dificultad(0,1,2), tema(string)] - null si no hay parámetro
        //devuelve lista[id1, ver1, id2, ver2,...]
        public ICollection<dynamic> GetEntidades();
        public DataTable GetExamenes(dynamic persona);
        //Si se le pasa un alumno: muestra los exámenes que el alumno puede realizar
        //Si se le pasa un profesor: muestra los exámenes creados por el profesor

        public void SubirRespuestas(List<dynamic> respuestas);
        //respuestas[id_ex, id_alumno, id_preg1, ver_preg1, resp1, id_preg2, ver_preg2, resp2,....]
    }
}