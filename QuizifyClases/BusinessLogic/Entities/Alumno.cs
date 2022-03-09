using System;
namespace Quizify.Entities { 
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
    public int getNota_media()
    {
        return nota_media;
    }
    public int getNota_CT()
    {
        return nota_CT;
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
    public void setNota_media(int nota_media)
    {
        this.nota_media = nota_media;
    }
    public void setNota_CT(int nota_CT)
    {
        this.nota_CT = nota_CT;
    }

    }
}
