using System;
using System.Collections.Generic;
using System.Text;

namespace Quizify.Entities
{
    public partial class Curso
    {
        public Curso(string codigo, string nombre, string autor, int alumnosApuntados, int maxAlumnos, DateTime fechaCreacion, string contraseña)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.autor = autor;
            this.alumnosApuntados = alumnosApuntados;
            this.maxAlumnos = maxAlumnos;
            this.fechaCreacion = fechaCreacion;
            this.contraseña = contraseña;
        }

        public string GetCodigo()
        {
            return codigo;
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

        public int GetMaxAlumnos()
        {
            return maxAlumnos;
        }

        public DateTime GetFechaCreacion()
        {
            return fechaCreacion;
        }

        public string GetContraseña()
        {
            return contraseña;
        }
    }
}
