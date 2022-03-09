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
    public double getAlmacenamiento()
    {
        return almacenamiento;
    }
    public int getQuizes()
    {
        return quizes;
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
    public void setAlmacenaminento(double almacenamiento)
    {
        this.almacenamiento = almacenamiento;
    }
    public void setQuizes(int quizes)
    {
        this.quizes = quizes;
    }
    }
}