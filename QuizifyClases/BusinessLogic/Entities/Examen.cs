using System;

public partial class Examen
{
    public Examen(string nombre, string titulo, string descripcion, string curso, DateTime fecha_ini, 
        DateTime fecha_fin, int volver_atras, int errores_restan, int mostrar_resultados)
    {
        this.nombre = nombre;
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.curso = curso;
        this.fecha_ini = fecha_ini;
        this.fecha_fin = fecha_fin;
        this.volver_atras = volver_atras;
        this.errores_restan = errores_restan;
        this.mostrar_resultados = mostrar_resultados;
        //??
    }

    public Boolean anadir_pregunta(Pregunta pregunta) {
        return true;
    }

    public Boolean eliminar_pregunta(Pregunta pregunta) {
        return true;
    }

    public dynamic crear_pregunta(string enunciado, string tipo) {
        switch(tipo){
            case("VF"): return new PreguntaVF(3, enunciado, tipo, )
            case("Test"): return true;
            case("Desarrollo"): return true;
        }
    }
}