using System;

namespace Quizify.Entities
{
    public partial class PreguntaVF : Pregunta
    {
        public PreguntaVF(int Id, string Enunciado, string Tipo, int OpCorrecta) : base(Id, Enunciado, Tipo)
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