using System;

public partial class Institucion : Entidad
{
    public Institucion(string correo, string nombre, string contraseña, string bonos, string tipo) : base(correo, tipo)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.bonos = bonos;
    }
    public string getNombre()
    {
        return nombre;
    }
    
    public string getContraseña()
    {
        return contraseña;
    }
    
    public string getBonos()
    {
        return bonos;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    
    public void setContraseña(string contraseña)
    {
        this.contraseña = contraseña;
    }
    
    public void setBonos(string bonos)
    {
        this.bonos = bonos;
    }
}