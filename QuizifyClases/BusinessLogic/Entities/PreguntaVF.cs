using System;

public partial class PreguntaVF : Pregunta
{
    public PreguntaVF(int Id, string Enunciado, string Tipo, int OpCorrecta):base(Id, Enunciado, Tipo)
    {
        correcta = OpCorrecta;
    }
    public int getCorrecta()
    {
        return correcta;
    }
    public void setCorrecta(int OpCorrecta)
    {
        correcta = OpCorrecta;
    }
}