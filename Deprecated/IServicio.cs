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
        public void AddPregunta(dynamic pregunta);
        public void addEntidad(dynamic usuario);
        public void AddExamen(Examen examen);
        //Atributos: id, titulo, descrpicion, curso, autor, fecha_creac, fecha_ini, fecha_fin, intentos (int), 
        //volver_atras (0 = no, 1 = si), errores_restan (0 = no, 1 = si), mostrar_resultados (0 = no, 1 = si), preguntas.
        //preguntas[i] = id_pregunta, preguntas[i+1] = version_pregunta, preguntas[i+2] = puntuacion

        public void AddCurso(Curso curso);
        public void AddAlumnoACurso(string alumno, string curso, string profesor);
        //alumno = correo del alumno, curso = codigo del curso, profesor = correo del profesor
        public PreguntaVF GetPreguntaVFById(int Id, int version);
        public PreguntaTest GetPreguntaTestById(int Id, int version);
        public dynamic GetPreguntaById(int Id, int version);
        public dynamic GetEntidadById(string correo);
        public Examen GetExamenById(int Id);
        string GetTipoPregunta(int id);
        public string GetTipoEntidad(string correo);

        public List<int> GetPreguntas(List<dynamic> filtros);
        //filtros[autor(el correo), tipo('test','vf','des','mult'), dificultad(0,1,2), tema(string)] - null si no hay parámetro
        //devuelve lista[id1, ver1, id2, ver2,...]
        public ICollection<dynamic> GetEntidades();
        public List<int> GetExamenes(dynamic persona);
        //Si se le pasa un alumno: muestra los exámenes que el alumno puede realizar
        //Si se le pasa un profesor: muestra los exámenes creados por el profesor

        public void SubirRespuestas(List<dynamic> respuestas);
        //respuestas[id_ex, id_alumno, id_preg1, ver_preg1, resp1, id_preg2, ver_preg2, resp2,....]

        public bool ExisteEntidad(string correo);
        public void AnularPregunta(int id_ex, int id_preg);
        public void EliminarCurso(string codigo, string profesor);
        public Curso GetCurso(string codigo);
        public bool ExisteCurso(string codigo);
        public List<string> GetCursosByAutor(dynamic persona);
        public void EliminarAlumnoDeCurso(string alumno, string curso, string profesor);
        public double GetNota(string id_alumno, int id_ex);
    }
}