using System;

public partial class PreguntaTest
{
    public PreguntaTest(string opA, string opB, string opC, int OpCorrecta)
    {
        op_a = opA;
        op_b = opB;
        op_c = opC;
        correcta = OpCorrecta;
    }
    public void setPreguntaA(string A)
    {
        op_a = A;
    }
    public void setPreguntaB(string B)
    {
        op_b = B;
    }
    public void setPreguntaC(string C)
    {
        op_c = C;
    }
    public void setPreguntaC(string D)
    {
        op_d = D;
    }
}