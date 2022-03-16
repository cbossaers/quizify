using System;

namespace Quizify.Entities {
    public partial class Alumno
    {

        public string nombre
        {
            get;
            set;
        }
        public string apellidos
        {
            get;
            set;
        }
        public string contraseña
        {
            get;
            set;
        }
        public int nota_media
        {
            get;
            set;
        }
        public int nota_CT
        {
            get;
            set;
        }

        public string Curso{
            get;
            set;
        }

    }
}