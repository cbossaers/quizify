using System;

public partial class Profesor :Entidad
{
    public Profesor(string correo, string nombre, string apellidos, string contraseña, string almacenamiento, string bonos, string tipo) : base(correo, tipo) 
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contraseña = contraseña;
        this.almacenamiento = almacenamiento;
        this.bonos = bonos;
        
    }
    public string getNombre()
    {
        return nombre;
    }
    public string getapellidos()
    {
        return apellidos;
    }
    public string getContraseña()
    {
        return contraseña;
    }
    public string getAlmacenamiento()
    {
        return almacenamiento;
    }
    public string getBonos()
    {
        return bonos;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void setApellidos(string apellidos)
    {
        this.apellidos = apellidos;
    }
    public void setContraseña(string contraseña)
    {
        this.contraseña = contraseña;
    }
    public void setAlmacenaminento(string almacenamiento)
    {
        this.almacenamiento = almacenamiento;
    }
    public void setBonos(string bonos)
    {
        this.bonos = bonos;
    }
}