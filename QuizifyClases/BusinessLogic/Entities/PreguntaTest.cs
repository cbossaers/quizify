using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public partial class PreguntaTest : Pregunta
    {
        public PreguntaTest(int Id, string Enunciado, List<dynamic> lista, int dificultad, string autor, string tema, 
            int version = 1) : base(Id, Enunciado, dificultad, autor, tema, version)
        {
            opc_a = lista[1];
            opc_b = lista[2];
            opc_c = lista[3];
            if (lista.Count > 4) opc_d = lista[4]; else opc_d = null; opc_e = null;
            if (lista.Count > 5) opc_e = lista[5]; else opc_e = null;
            correcta = lista[0];
        }
        public string GetOpcA()
        {
            return opc_a;
        }
        public string GetOpcB()
        {
            return opc_b;
        }
        public string GetOpcC()
        {
            return opc_c;
        }
        public string GetOpcD()
        {
            return opc_d;
        }
        public string GetOpcE()
        {
            return opc_e;
        }
        public int GetCorrecta()
        {
            return correcta;
        }
        public void SetOpcA(string A)
        {
            opc_a = A;
        }
        public void SetOpcB(string B)
        {
            opc_b = B;
        }
        public void SetOpcC(string C)
        {
            opc_c = C;
        }
        public void SetOpcD(string D)
        {
            opc_d = D;
        }
        public void SetOpcE(string E)
        {
            opc_e = E;
        }
        public void SetCorrecta(int OpCorrecta)
        {
            correcta = OpCorrecta;
        }
    }
}