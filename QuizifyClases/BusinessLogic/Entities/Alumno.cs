using System;

public partial class Alumno : Entidad
{
    
    public Alumno(string correo, string contrase�a, string nombre, string apellidos, string tipo= "alumno") : base(correo, tipo)
    {
        this.nombre = nombre;   
        this.apellidos = apellidos;
        this.contrase�a = contrase�a;

    }
    public string getNombre()
    {
        return nombre;
    }
    public string getapellidos()
    {
        return apellidos;
    }
    public string getContrase�a()
    {
        return contrase�a;
    }
    
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void setApellidos(string apellidos)
    {
        this.apellidos = apellidos;
    }
    public void setContrase�a(string contrase�a)
    {
        this.contrase�a = contrase�a;
    }
    
}