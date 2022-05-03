using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class FabricaPreguntas {
        public Pregunta2 CrearPregunta2(int id, int version, string enunciado, string tipo, int dif, string autor, string tema,
            string CT, List<dynamic> param) {
                
            return new Pregunta2(id, version, enunciado, tipo, dif, autor, tema, CT, param);
        }
    }
}