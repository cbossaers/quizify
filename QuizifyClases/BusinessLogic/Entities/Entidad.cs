using System;

public partial class Entidad
{
    public Entidad(string correo, string tipo)
    {
        this.correo = correo;
        this.tipo = tipo;
    }
    public string getCorreo()
    {
        return correo;
    }
    public string getTipo()
    {
        return tipo;
    }
    public void setCorreo(string correo)
    {
        this.correo = correo;
    }
    public void setTipo(string tipo)
    {
        this.tipo = tipo;
    }

}