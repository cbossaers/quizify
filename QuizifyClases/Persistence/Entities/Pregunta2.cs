using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public partial class Pregunta2
    {
        private int Id
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

        private string CT
        {
            get;
            set;
        }

        private List<dynamic> parametros
        {
            get;
            set;
        }
    }
}