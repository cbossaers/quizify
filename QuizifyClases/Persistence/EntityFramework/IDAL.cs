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
        void ModificarContraseña(string correo, string contraseña);
        void EliminarEntidad(string correo);
        void EliminarPregunta(int id);
        dynamic GetEntidad(string correo);
        dynamic GetPregunta(int id, int ver);
    }
}