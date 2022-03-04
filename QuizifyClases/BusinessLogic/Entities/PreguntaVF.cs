using System;

public partial class PreguntaVF : Pregunta
{
    public PreguntaVF(int Id, int ver, string Enunciado, string Tipo, int OpCorrecta, string opA, string opB):base(Id, ver, Enunciado, Tipo)
    {
        correcta = OpCorrecta;
        opc_a = opA;
        opc_b = opB;
    }
}