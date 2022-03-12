using System;
namespace Quizify.Entities { 
public partial class Institucion : Entidad
{
    public Institucion(string correo, string contraseña, string nombre, int quizes = 0) : base(correo)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.quizes = quizes;
    }
    public string GetNombre()
    {
        return nombre;
    }
    
    public string GetContraseña()
    {
        return contraseña;
    }
    
    public int GetQuizes()
    {
        return quizes;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
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