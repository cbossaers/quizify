using System;
using System.Collections.Generic;
using System.Text;
using Quizify.Services;

namespace Quizify.Entities
{
    public class Singleton
    {
        private static Alumno alumno;
        private static Profesor profesor;
        private NuevoServicio servicio = new NuevoServicio();

        public Alumno GetAlumno(string correo)
        {
            if (alumno == null)
            {
                return servicio.GetAlumno(correo);
            }
            else
            {
                return alumno;
            }
        }
        public Profesor GetProfesor(string correo)
        {
            if (profesor == null)
            {
                return servicio.GetProfesor(correo);
            }
            else
            {
                return profesor;
            }
        }

    }
}
