using System;
using System.Collections.Generic;
using System.Text;

namespace Quizify.Entities
{
    public partial class Curso
    {
        public string codigo
        {
            get;
            set;
        }
        
        public string nombre
        {
            get;
            set;
        }

        public string autor
        {
            get;
            set;
        }

        public int alumnosApuntados
        {
            get;
            set;
        }

        public int maxAlumnos
        {
            get;
            set;
        } 

        public DateTime fechaCreacion
        {
            get;
            set;
        }

        public string contraseña
        {
            get;
            set;
        }

        public List<string> listaAl
        {
            get;
            set;
        }
    }
}
