using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using Quizify.Persistence;

namespace Quizify.Persistence {
    public interface IDAL {
        void AddEntidad(dynamic entidad);
        void AddPregunta(dynamic pregunta);
        void AddExamen(Examen ex);
        //Atributos: id, nombre, titulo, descrpicion, curso, autor, fecha_creac, fecha_ini, fecha_fin, intentos (numero), 
        //volver_atras (0 = no, 1 = si), errores_restan (0 = no, 1 = si), mostrar_resultados (0 = no, 1 = si), preguntas.
        //preguntas[i] = id_pregunta, preguntas[i+1] = version_pregunta, preguntas[i+2] = puntuacion

        void ModificarContraseña(string correo, string contraseña);

        void EliminarEntidad(string correo);
        void EliminarPregunta(int id);
        void EliminarExamen(int id);

        dynamic GetEntidad(string correo);
        dynamic GetPregunta(int id, int ver);
        Examen GetExamen(int id);
        string GetTipoEntidad(string correo);

        List<int> GetPreguntas(List<dynamic> filtros);
        //filtros[autor(el correo), tipo('test','vf','desarrollo'), dificultad(0,1,2), tema(string)]
        List<int> GetExamenes(dynamic persona);
        //Si se le pasa un alumno: muestra los exámenes que el alumno puede realizar
        //Si se le pasa un profesor: muestra los exámenes creados por el profesor

        void SubirRespuestas(List<dynamic> respuestas);
    }
}