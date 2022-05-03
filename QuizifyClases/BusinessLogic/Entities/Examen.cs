using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public partial class Examen
    {
        public Examen(int id, string titulo, string descripcion, string curso, string autor, int Tiempo, DateTime fecha_creac, DateTime fecha_ini,
            DateTime fecha_fin, int intentos, int volver_atras, int errores_restan, int mostrar_resultados, List<int> preguntas, string estado, string CT)
        {
            this.ID = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.autor = autor;
            this.curso = curso;
            this.tiempo = Tiempo;
            this.fecha_creac = fecha_creac;
            this.fecha_ini = fecha_ini;
            this.fecha_fin = fecha_fin;
            this.intentos = intentos;
            this.volver_atras = volver_atras;
            this.errores_restan = errores_restan;
            this.mostrar_resultados = mostrar_resultados;
            this.preguntas_asociadas = preguntas;
            this.competenciaTransversal = CT;
            this.estado = estado;
        }

        public Boolean Anadir_pregunta(Pregunta2 pregunta)
        {
            return true;
        }

        public Boolean Eliminar_pregunta(Pregunta2 pregunta)
        {
            return true;
        } 
        public int GetId()
        {
            return ID;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public string GetCurso()
        {
            return curso;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetTiempo()
        {
            return tiempo;
        }

        public DateTime GetFechaCreac()
        {
            return fecha_creac;
        }

        public DateTime GetFechaIni()
        {
            return fecha_ini;
        }

        public DateTime GetFechaFin()
        {
            return fecha_fin;
        }

        public int GetIntentos()
        {
            return intentos;
        }

        public int GetVolverAtras()
        {
            return volver_atras;
        }

        public int GetErroresRestan()
        {
            return errores_restan;
        }

        public int GetMostrarResultados()
        {
            return mostrar_resultados;
        }

        public List<int> GetPreguntasAsociadas()
        {
            return preguntas_asociadas;
        }

        public string GetCompetenciaTransversal()
        {
            return competenciaTransversal;
        }

        public string GetEstado() {
            return estado;
        }


        public void SetId(int id)
        {
            this.ID = id;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetDescripcion(string descripc)
        {
            this.descripcion = descripc;
        }

        public void SetCurso(string curso) 
        {
            this.curso = curso;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTiempo(int Tiempo)
        {
            this.tiempo = Tiempo;
        }

        public void SetFechaCreac(DateTime fecha)
        {
            this.fecha_creac = fecha;
        }

        public void SetFechaIni(DateTime fecha)
        {
            this.fecha_ini = fecha;
        }

        public void SetFechaFin(DateTime fecha)
        {
            this.fecha_fin = fecha;
        }

        public void SetIntentos(int intentos)
        {
            this.intentos = intentos;
        }

        public void SetVolverAtras(int opcion)
        {
            this.volver_atras = opcion;
        }

        public void SetErroresRestan(int opcion)
        {
            this.errores_restan = opcion;
        }

        public void SetMostrarResultados(int opcion)
        {
            this.mostrar_resultados = opcion;
        }

        public void SetPreguntasAsociadas(List<int> preguntas)
        {
            this.preguntas_asociadas = preguntas;
        }

        public void SetEstado(string estado) {
            this.estado = estado;
        }
    }
}