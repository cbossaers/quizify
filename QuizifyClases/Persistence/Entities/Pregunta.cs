using System;

namespace Quizify.Entities
{
    public partial class Pregunta
    {
        private int ID
        {
            get;
            set;
        }
        private int version
        {
            get;
            set;
        }
        private string enunciado
        {
            get;
            set;
        }
        private string tipo
        {
            get;
            set;
        }

        private int dificultad 
        {
            get;
            set;
        }

        private string autor 
        {
            get;
            set;
        }

        private string tema 
        {
            get;
            set;
        }
    }
}