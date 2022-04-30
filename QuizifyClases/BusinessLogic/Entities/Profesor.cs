using System;
namespace Quizify.Entities { 
public partial class Profesor :Entidad
{
    public Profesor(string correo, string contraseña, string nombre, string apellidos, int quizes = 20) : base(correo) 
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contraseña = contraseña;
        this.quizes = quizes;
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
    public int GetQuizes()
    {
        return quizes;
    }
    public string GetTipo()
    {
        return "profesor";
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
    public void SetQuizes(int quizes)
    {
        this.quizes = quizes;
    }
    }
}