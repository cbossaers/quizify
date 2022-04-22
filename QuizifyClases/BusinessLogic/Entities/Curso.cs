using System;
using System.Collections.Generic;
using System.Text;

namespace Quizify.Entities
{
    public partial class Curso
    {
        public Curso(int id, string nombre, string autor, int alumnosApuntados, int maxAlumnos, DateTime fechaCreacion)
        {
            this.ID = id;
            this.nombre = nombre;
            this.autor = autor;
            this.alumnosApuntados = alumnosApuntados;
            this.maxAlumnos = maxAlumnos;
            this.fechaCreacion = fechaCreacion;
        }

        public int GetId()
        {
            return ID;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetNumAlumnos()
        {
            return alumnosApuntados;
        }

        public DateTime GetFechaCreacion()
        {
            return fechaCreacion;
        }
    }
}
