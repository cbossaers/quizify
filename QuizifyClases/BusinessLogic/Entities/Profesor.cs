using System;
namespace Quizify.Entities { 
public partial class Profesor :Entidad
{
    public Profesor(string correo, string contraseña, string nombre, string apellidos, double almacenamiento, int quizes, string tipo) : base(correo, tipo) 
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contraseña = contraseña;
        this.almacenamiento = almacenamiento;
        this.quizes = quizes;
        
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
    public double GetAlmacenamiento()
    {
        return almacenamiento;
    }
    public int GetQuizes()
    {
        return quizes;
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
    public void SetAlmacenaminento(double almacenamiento)
    {
        this.almacenamiento = almacenamiento;
    }
    public void SetQuizes(int quizes)
    {
        this.quizes = quizes;
    }
    }
}