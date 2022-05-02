using System;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;

namespace Quizify.Services
{
    public class NuevoServicio {
        DALAlumno alumno = new DALAlumno();
        DALProfesor profesor = new DALProfesor();
        DALPregunta pregunta = new DALPregunta();
        DALExamen examen = new DALExamen();
        DALCurso curso = new DALCurso();

        //Métodos Alumno
        public void AddAlumno(Alumno al) {
            try { alumno.Add(al); } 
            catch(MySql.Data.MySqlClient.MySqlException) { throw new Exception("Este alumno ya existe."); }
        }
        public Alumno GetAlumno(string id) {
            Alumno al = alumno.Get(id);
            if(al is null) { throw new Exception("Este alumno no existe."); }
            return al;
        }
        public void EliminarAlumno(string id){
            alumno.Eliminar(id);
        }
        public List<int> GetExamenesAlumno(string al) {
            return alumno.GetExamenes(al);
        }

        //Métodos Profesor
        public void AddProfesor(Profesor prof) {
            try { profesor.Add(prof); } 
            catch(MySql.Data.MySqlClient.MySqlException) { throw new Exception("Este profesor ya existe."); }
        }
        public Profesor GetProfesor(string id) {
            Profesor prof = profesor.Get(id);
            if(prof is null) { throw new Exception("Este profesor no existe."); }
            return prof;
        }
        public void EliminarProfesor(string id){
            profesor.Eliminar(id);
        }
        public List<int> GetExamenesProfesor(string prof) {
            return profesor.GetExamenes(prof);
        }

        //Métodos Curso
        public void AddCurso(Curso cur) {
            try { curso.Add(cur); } 
            catch(MySql.Data.MySqlClient.MySqlException ex) { 
                if(ex.Number == 1062) { throw new Exception("Este curso ya existe."); }
                if(ex.Number == 1452) { throw new Exception("Ese profesor no existe."); }
                else { throw new Exception("Error de integridad, código: " + ex.Number); }
            }
        }
        public Curso GetCurso(string id, string autor) {
            Curso cur = curso.Get(id, autor);
            if(cur is null) { throw new Exception("Este curso no existe o no es impartido por el profesor seleccionado."); }
            return cur;
        }
        public void AddAlumnoACurso(string al, string cur, string prof) {
            try { curso.AddAlumnoACurso(al,cur,prof); }
            catch(MySql.Data.MySqlClient.MySqlException ex) { throw new Exception("El alumno seleccionado ya está en este curso, o el curso no existe" + ex.Message.ToString()); }
            catch(InvalidOperationException) { throw new Exception("Ese curso está lleno"); }
        }
        public void EliminarAlumnoDeCurso(string al, string cur, string prof) {
            curso.EliminarAlumnoDeCurso(al,cur,prof);
        }
        public List<string> GetCursosAlumno(string id) {
            return curso.GetCursosAlumno(id);
        }
        public List<string> GetCursosProfesor(string id) {
            return curso.GetCursosProfesor(id);
        }
        public List<string> GetAlumnosDeCurso(string cur, string prof) {
            return curso.GetAlumnosDeCurso(cur,prof);
        }

        //Métodos pregunta
        public void AddPregunta(Pregunta2 preg) {
            try { pregunta.Add(preg); } 
            catch(MySql.Data.MySqlClient.MySqlException ex) { 
                if(ex.Number == 1062) { throw new Exception("Esta pregunta ya existe."); }
                else { throw new Exception("Error crítico, código: " + ex.Number); }
            }
        }
        public Pregunta2 GetPregunta(int id, int ver) {
            try { return pregunta.Get(id, ver); }
            catch(MySql.Data.MySqlClient.MySqlException) { throw new Exception("Esta pregunta no existe"); }
        }
        public void EliminarPregunta(int id, int ver) {
            pregunta.Eliminar(id, ver);
        }
        public List<int> GetPreguntas(List<dynamic> filtros) {
            return pregunta.GetPreguntas(filtros); 
        }
        public int UltimoIdPregunta() {
            return pregunta.UltimoIdPregunta();
        }
        public int UltimaVersionPregunta(int id) {
            return pregunta.UltimaVerPregunta(id);
        }

        //Métodos examen
        public void AddExamen(Examen exam) {
            try { examen.Add(exam); } 
            catch(MySql.Data.MySqlClient.MySqlException ex) { 
                if(ex.Number == 1062) { throw new Exception("Este examen ya existe."); }
                if(ex.Number == 1452) { throw new Exception("Ese profesor no existe."); }
                else { throw new Exception("Error de integridad, código: " + ex.Number); }
            }
        }
        public Examen GetExamen(int id) {
            Examen exam = examen.Get(id);
            if(exam is null) { throw new Exception("Este examen no existe."); }
            return exam;
        }
        public int UltimoIdExamen() {
            return examen.UltimoIdExamen();
        }
        public void SubirRespuestas(List<dynamic> respuestas) {
            try { examen.SubirRespuestas(respuestas); }
            catch(MySql.Data.MySqlClient.MySqlException ex) { throw new Exception("Error de integridad, código: " + ex.Number); }
        }
        public void AnularPregunta(int id_ex, int id_preg) {
            examen.AnularPregunta(id_ex,id_preg);
        }
        public void ActualizarEstadoQuizes() {
            examen.ActualizarEstadoQuizes();
        }
        public void PublicarNotas(int ex_id) {
            examen.PublicarNotas(ex_id);
        }
        public double GetNota(string id_alumno, int id_ex) {
            return examen.GetNota(id_alumno,id_ex);
        }

        public int GetPuntuacionDePregunta(int id_ex, int id_preg) {
            return examen.GetPuntuacionDePregunta(id_ex, id_preg);
        }
    
        //Otros métodos
        public string GetTipoEntidad(string usuario) {
            try { 
                GetAlumno(usuario); 
                return "alumno"; 
            }
            catch(Exception) { 
                try { GetProfesor(usuario); return "profesor"; }
                catch(Exception ex) { throw new Exception(""+ex); }    
            }
        }
    }   
}