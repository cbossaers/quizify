using System;
namespace Quizify.Entities { 
public partial class Alumno : Entidad
{
    
    public Alumno(string correo, string contraseña, string nombre, string apellidos) : base(correo)
    {
        this.nombre = nombre;   
        this.apellidos = apellidos;
        this.contraseña = contraseña;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public string GetApellidos()
    {
        return apellidos;
    }
    public string GetContraseña()
    {
        return contraseña;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetApellidos(string apellidos)
    {
        this.apellidos = apellidos;
    }
    public void SetContraseña(string contraseña)
    {
        this.contraseña = contraseña;
    }

    }
}
