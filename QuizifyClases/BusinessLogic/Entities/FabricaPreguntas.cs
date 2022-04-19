using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class FabricaPreguntas
    {
        public dynamic CrearPregunta(string tipo, int id, string enunciado, int dif, string autor, string tema,
            List<dynamic> opciones = null, int version = 1)
        {
            switch (tipo)
            {
                case ("vf"): return new PreguntaVF(id, enunciado, int.Parse(opciones[0].ToString()), dif, autor, tema, version);
                case ("test"): return new PreguntaTest(id, enunciado, opciones, dif, autor, tema, version);
                //case ("desarrollo"): return new PreguntaDesarrollo(id, enunciado, dif, autor, tema, version);
                //case ("multiple"): return new PreguntaMultiple(id, enunciado, opciones, dif, autor, tema, version);
            }
            return -1;
        }
    }
}