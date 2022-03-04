using System;

public partial class Pregunta
{
    public Pregunta(int Id, int ver, string Enunciado, string Tipo)
    {
        ID = Id;
        version = ver;
        enunciado = Enunciado;
        tipo = Tipo;
    }
    public int getId()
    {
        return ID;
    }
    public int getVersion()
    {
        return version;
    }
    public string getEnunciado()
    {
        return enunciado;
    }
    public string getTipo()
    {
        return tipo;
    }
    public void setVersion(int ver)
    {
        version = ver;
    }
    public void setEnunciado(string Enunciado)
    {
        enunciado = Enunciado;
    }
    public void setTipo(string Tipo)
    {
        tipo = Tipo;
    }
}