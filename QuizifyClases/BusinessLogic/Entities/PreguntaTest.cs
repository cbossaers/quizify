using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public partial class PreguntaTest : Pregunta
    {
        public PreguntaTest(int Id, string Enunciado, string Tipo, List<string> lista) : base(Id, Enunciado, Tipo)
        {
            opc_a = lista[1];
            opc_b = lista[2];
            opc_c = lista[3];
            if (lista.Count > 4) opc_d = lista[4]; else opc_d = null; opc_e = null;
            if (lista.Count > 5) opc_e = lista[5]; else opc_e = null;
            correcta = Int32.Parse(lista[0]);
        }
        public string GetPreguntaA()
        {
            return opc_a;
        }
        public string GetPreguntaB()
        {
            return opc_b;
        }
        public string GetPreguntaC()
        {
            return opc_c;
        }
        public string GetPreguntaD()
        {
            return opc_d;
        }
        public string GetPreguntaE()
        {
            return opc_e;
        }
        public int GetCorrecta()
        {
            return correcta;
        }
        public void SetPreguntaA(string A)
        {
            opc_a = A;
        }
        public void SetPreguntaB(string B)
        {
            opc_b = B;
        }
        public void SetPreguntaC(string C)
        {
            opc_c = C;
        }
        public void SetPreguntaD(string D)
        {
            opc_d = D;
        }
        public void SetPreguntaE(string E)
        {
            opc_e = E;
        }
        public void SetCorrecta(int OpCorrecta)
        {
            correcta = OpCorrecta;
        }
    }
}