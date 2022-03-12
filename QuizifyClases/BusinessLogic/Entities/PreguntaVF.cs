using System;

namespace Quizify.Entities
{
    public partial class PreguntaVF : Pregunta
    {
        public PreguntaVF(int Id, string Enunciado, int OpCorrecta, int version = 1) : base(Id, Enunciado, version)
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