using System;

public partial class PreguntaTest : Pregunta
{
    public PreguntaTest(int Id, int ver, string Enunciado, string Tipo, int OpCorrecta, string opA, string opB,
        string opC, string opD = null, string opE = null): base(Id, ver, Enunciado, Tipo)
    {
        opc_a = opA;
        opc_b = opB;
        opc_c = opC;
        opc_d = opD;
        opc_e = opE;
        correcta = OpCorrecta;
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
}