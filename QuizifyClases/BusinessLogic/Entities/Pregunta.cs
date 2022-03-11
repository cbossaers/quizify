using System;

namespace Quizify.Entities
{
    public partial class Pregunta
    {
        public Pregunta(int Id, string Enunciado, string Tipo)
        {
            ID = Id;
            version = 1;
            enunciado = Enunciado;
            tipo = Tipo;
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
        public string GetTipo()
        {
            return tipo;
        }
        public void SetVersion(int ver)
        {
            version = ver;
        }
        public void SetEnunciado(string Enunciado)
        {
            enunciado = Enunciado;
        }
        public void SetTipo(string Tipo)
        {
            tipo = Tipo;
        }
    }
}