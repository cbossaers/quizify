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
        public string getPreguntaA()
        {
            return opc_a;
        }
        public string getPreguntaB()
        {
            return opc_b;
        }
        public string getPreguntaC()
        {
            return opc_c;
        }
        public string getPreguntaD()
        {
            return opc_d;
        }
        public string getPreguntaE()
        {
            return opc_e;
        }
        public int getCorrecta()
        {
            return correcta;
        }
        public void setPreguntaA(string A)
        {
            opc_a = A;
        }
        public void setPreguntaB(string B)
        {
            opc_b = B;
        }
        public void setPreguntaC(string C)
        {
            opc_c = C;
        }
        public void setPreguntaD(string D)
        {
            opc_d = D;
        }
        public void setPreguntaE(string E)
        {
            opc_e = E;
        }
        public void setCorrecta(int OpCorrecta)
        {
            correcta = OpCorrecta;
        }
    }
}