using System;

public partial class Institucion : Entidad
{
    public Institucion(string correo, string contraseña, string nombre, int quizes, string tipo) : base(correo, tipo)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.quizes = quizes;
    }
    public string getNombre()
    {
        return nombre;
    }
    
    public string getContraseña()
    {
        return contraseña;
    }
    
    public int getQuizes()
    {
        return quizes;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    
    public void setContraseña(string contraseña)
    {
        this.contraseña = contraseña;
    }
    
    public void setQuizes(int quizes)
    {
        this.quizes = quizes;
    }
}