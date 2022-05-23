using Quizify.Entities;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizifyClases.BusinessLogic.Entities
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instancia;

        public Entidad usuario { get; set; }


        public static Singleton getInstancia()
        {
            if (instancia == null) throw new Exception("Sesión no iniciada");
            return instancia;
        }

        public static void Login(Entidad user)
        {
            if(instancia == null)
            {
                instancia = new Singleton();
                instancia.usuario = user; 
            }
            else
            {
                throw new Exception("Sesión ya iniciada");
            }
        }

        public static void Logout()
        {
            if (instancia != null) instancia = null;
            else throw new Exception("Sesión no iniciada");
        }
    }
}
