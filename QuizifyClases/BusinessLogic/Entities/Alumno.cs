using System;
namespace Quizify.Entities { 
public partial class Alumno : Entidad
{
    
    public Alumno(string correo, string contraseña, string nombre, string apellidos, string curso) : base(correo)
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
    public int GetNota_media()
    {
        return nota_media;
    }
    public int GetNota_CT()
    {
        return nota_CT;
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
    public void SetNota_media(int nota_media)
    {
        this.nota_media = nota_media;
    }
    public void SetNota_CT(int nota_CT)
    {
        this.nota_CT = nota_CT;
    }

    public void SetCurso(string curso)
    {
        this.Curso = curso;
    }
    }
}
