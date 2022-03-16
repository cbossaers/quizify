using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class Fabrica
    {
        public dynamic Crear_pregunta(string enunciado, string tipo, int dif, List<dynamic> opciones = null)
        {
            /*switch (tipo)
            {
                case ("VF"): return new PreguntaVF(0, enunciado, Int32.Parse(opciones[0]),dif);
                case ("Test"): return new PreguntaTest(0, enunciado, opciones, dif);
                default: return true;
            }*/
            return true;
        }
    }
}