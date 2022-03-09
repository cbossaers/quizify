using System;

public partial class Institucion : Entidad
{
    public Institucion(string correo, string contrase�a, string nombre, int quizes, string tipo) : base(correo, tipo)
    {
        this.nombre = nombre;
        this.contrase�a = contrase�a;
        this.quizes = quizes;
    }
    public string getNombre()
    {
        return nombre;
    }
    
    public string getContrase�a()
    {
        return contrase�a;
    }
    
    public int getQuizes()
    {
        return quizes;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    
    public void setContrase�a(string contrase�a)
    {
        this.contrase�a = contrase�a;
    }
    
    public void setQuizes(int quizes)
    {
        this.quizes = quizes;
    }
}