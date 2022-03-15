using System;

namespace Quizify.Entities
{
    public partial class Pregunta
    {
        public Pregunta(int Id, string Enunciado, int Dificultad, int ver)
        {
            ID = Id;
            version = ver;
            enunciado = Enunciado;
            dificultad = Dificultad;
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
        public int GetDificultad()
        {
            return dificultad;
        }
        public void SetVersion(int ver)
        {
            version = ver;
        }
        public void SetEnunciado(string Enunciado)
        {
            enunciado = Enunciado;
        }
        
        public void SetDificultad(int Dificultad) 
        {
            dificultad = Dificultad;
        }
    }
}