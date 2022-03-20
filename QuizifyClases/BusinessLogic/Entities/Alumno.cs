using System;
namespace Quizify.Entities { 
public partial class Alumno : Entidad
{
    
    public Alumno(string correo, string contraseña, string nombre, string apellidos, string curso="") : base(correo)
    {
        this.nombre = nombre;   
        this.apellidos = apellidos;
        this.contraseña = contraseña;
        this.Curso = curso;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public string Getapellidos()
    {
        return apellidos;
    }
    public string GetContraseña()
    {
        return contraseña;
    }
    public string GetCurso()
    {
        return Curso;
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
    public void SetCurso(string curso)
    {
        this.Curso = curso;
    }
    }
}
