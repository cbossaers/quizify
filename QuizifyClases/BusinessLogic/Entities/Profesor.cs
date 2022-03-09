using System;
namespace Quizify.Entities { 
public partial class Profesor :Entidad
{
    public Profesor(string correo, string contrase�a, string nombre, string apellidos, double almacenamiento, int quizes, string tipo) : base(correo, tipo) 
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contrase�a = contrase�a;
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
    public string getContrase�a()
    {
        return contrase�a;
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
    public void setContrase�a(string contrase�a)
    {
        this.contrase�a = contrase�a;

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