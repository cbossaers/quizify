using System.Collections.Generic;

namespace Quizify.Entities
{
    public partial class Pregunta2
    {
        public Pregunta2(int ID, int ver, string Enunciado, string Tipo, int Dificultad, string Autor, string Tema, string ct, List<dynamic> Param)
        {
            Id = ID;
            version = ver;
            enunciado = Enunciado;
            tipo = Tipo;
            dificultad = Dificultad;
            autor = Autor;
            tema = Tema;
            CT = ct;
            parametros = Param;
        }

        public int GetId()
        {
            return Id;
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
        public int GetDificultad()
        {
            return dificultad;
        }
        public string GetAutor()
        {
            return autor;
        }
        public string GetTema()
        {
            return tema;
        }
        public string GetCT()
        {
            return CT;
        }
        public List<dynamic> GetParametros()
        {
            return parametros;
        }


        public void SetId(int id)
        {
            Id = id;
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
        public void SetDificultad(int Dificultad) 
        {
            dificultad = Dificultad;
        }
        public void SetAutor(string Autor)
        {
            autor = Autor;
        }
        public void SetTema(string Tema)
        {
            tema = Tema;
        }
        public void SetCT(string Ct)
        {
            CT = Ct;
        }
        public void SetParametros(List<dynamic> param)
        {
            parametros = param;
        }
    }
}