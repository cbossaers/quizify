using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizifyClases.BusinessLogic.Entities
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton instancia = null;


        public static Singleton getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
            }
            return instancia;
        }
    }
}
