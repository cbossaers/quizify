using System;

public partial class Institucion : Entidad
{
    public Institucion(string correo, string nombre, string contrase�a, string bonos, string tipo) : base(correo, tipo)
    {
        this.nombre = nombre;
        this.contrase�a = contrase�a;
        this.bonos = bonos;
    }
    public string getNombre()
    {
        return nombre;
    }
    
    public string getContrase�a()
    {
        return contrase�a;
    }
    
    public string getBonos()
    {
        return bonos;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    
    public void setContrase�a(string contrase�a)
    {
        this.contrase�a = contrase�a;
    }
    
    public void setBonos(string bonos)
    {
        this.bonos = bonos;
    }
}