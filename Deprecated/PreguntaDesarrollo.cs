using System;

namespace Quizify.Entities
{
    public partial class PreguntaDesarrollo : Pregunta
    {
        public PreguntaDesarrollo(int Id, string Enunciado, string Respuesta, int dificultad, string autor, string tema,
            int version = 1, string CT="") : base(Id, Enunciado, dificultad, autor, tema, version, CT)
        {
            respuesta = Respuesta;
        }
        public string GetRespuesta()
        {
            return respuesta;
        }
        public void SetRespuesta(string Respuesta)
        {
            respuesta = Respuesta;
        }
    }
}
