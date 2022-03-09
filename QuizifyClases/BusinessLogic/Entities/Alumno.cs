using System;

public partial class Alumno : Entidad
{
    
    public Alumno(string correo, string contraseña, string nombre, string apellidos, string tipo= "alumno") : base(correo, tipo)
    {
        this.nombre = nombre;   
        this.apellidos = apellidos;
        this.contraseña = contraseña;

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
    
}