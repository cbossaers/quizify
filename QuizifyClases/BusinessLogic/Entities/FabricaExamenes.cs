using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class FabricaExamenes
    {
        public Examen CrearExamen(int id, string titulo, string descripcion, string curso, string autor, int tiempo,
        DateTime fecha_creac, DateTime fecha_ini, DateTime fecha_fin, int intentos, int volver_atras, int errores_restan, 
        int mostrar_resultados, List<int> preguntas)
        {
            return new Examen(id, titulo, descripcion, curso, autor, tiempo, fecha_creac, fecha_ini, fecha_fin, intentos,
            volver_atras, errores_restan, mostrar_resultados, preguntas);
        }
    }
}