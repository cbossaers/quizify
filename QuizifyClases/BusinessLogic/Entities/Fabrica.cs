using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class Fabrica
    {
        public dynamic Crear_pregunta(string tipo, int id, string enunciado, int dif, string autor, string tema, 
            int version = 1, List<dynamic> opciones = null)
        {
            switch (tipo)
            {
                case ("vf"): return new PreguntaVF(id, enunciado, int.Parse(opciones[0].ToString()), dif, autor, tema, version);
                case ("test"): return new PreguntaTest(id, enunciado, opciones, dif, autor, tema, version);
            }
            return -1;
        }
    }
}