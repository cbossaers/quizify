using System;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;
using System.Data;

namespace Quizify.Entities
{
    public class Fachada {

        DALAlumno alumno = new DALAlumno();
        DALProfesor profesor = new DALProfesor();
        DALExamen examen = new DALExamen();

        public (DataTable, DataTable) GetExamenesAlumno (string al) {
            return alumno.GetExamenes(al);
        }

        public DataTable GetExamenesProfesor(string prof) {
            return profesor.GetExamenes(prof);
        }

        public void GenerarExamen(string profesor, string codigo_curso, int num_preguntas, int tiempo, DateTime fechaini, DateTime fechafin,
        int intentos, int volveratras, int erroresrestan, int mostrarresultados, bool esrecu, string dific) {
            try {
                examen.GenerarExamen(profesor, codigo_curso, num_preguntas, tiempo, fechaini, fechafin, intentos, 
                volveratras, erroresrestan, mostrarresultados, esrecu, dific);
            } catch(Exception e) { throw new Exception(e.ToString()); }
        }

        public void CalcularNotaExamen(int id_ex, string correo) {
            examen.CalcularNotaExamen(id_ex, correo);
        }

        public DataTable EstadisticasExamenPreguntas(int id_ex) {
            return examen.EstadisticasExamenPreguntas(id_ex);
        }

    }
}