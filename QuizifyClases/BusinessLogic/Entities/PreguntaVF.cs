using System;

namespace Quizify.Entities
{
    public partial class PreguntaVF : Pregunta
    {
        public PreguntaVF(int Id, string Enunciado, int OpCorrecta, int dificultad, string autor, string tema, 
            int version = 1) : base(Id, Enunciado, dificultad, autor, tema, version)
        {
            correcta = OpCorrecta;
        }
        public int GetCorrecta()
        {
            return correcta;
        }
        public void SetCorrecta(int OpCorrecta)
        {
            correcta = OpCorrecta;
        }
    }
}