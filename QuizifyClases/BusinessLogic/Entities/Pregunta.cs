using System;

namespace Quizify.Entities
{
    public partial class Pregunta
    {
        public Pregunta(int Id, string Enunciado, int ver)
        {
            ID = Id;
            version = ver;
            enunciado = Enunciado;
        }
        public int GetId()
        {
            return ID;
        }
        public int GetVersion()
        {
            return version;
        }
        public string GetEnunciado()
        {
            return enunciado;
        }
        public void SetVersion(int ver)
        {
            version = ver;
        }
        public void SetEnunciado(string Enunciado)
        {
            enunciado = Enunciado;
        }
    }
}