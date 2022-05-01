using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class FabricaPreguntas
    {
        public dynamic CrearPregunta(string tipo, int id, string enunciado, int dif, string autor, string tema,
            List<dynamic> opciones = null, int version = 1, string CT="")
        {
            switch (tipo)
            {
                case ("vf"): return new PreguntaVF(id, enunciado, int.Parse(opciones[0].ToString()), dif, autor, tema, version, CT);
                case ("test"): return new PreguntaTest(id, enunciado, opciones, dif, autor, tema, version, CT);
                case ("multiple"): return new PreguntaMultiple(id, enunciado, opciones, dif, autor, tema, version, CT);
                case ("desarrollo"): return new PreguntaTest(id, enunciado, opciones[0].ToString(), dif, autor, tema, version, CT);
            }
            return -1;
        }

        public Pregunta2 CrearPregunta2(int id, int version, string enunciado, string tipo, int dif, string autor, string tema,
        string CT, List<dynamic> param)
        {
            return new Pregunta2(id, version, enunciado, tipo, dif, autor, tema, CT, param);
        }
    }
}