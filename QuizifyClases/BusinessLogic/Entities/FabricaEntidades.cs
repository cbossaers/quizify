using System;
using System.Collections.Generic;

namespace Quizify.Entities
{
    public class FabricaEntidades
    {
        public dynamic CrearEntidad (string tipo, string correo, string contraseña, string nombre, string apellidos="" )
        {
            switch (tipo)
            {
                case ("alumno"): return new Alumno(correo, contraseña, nombre, apellidos);
                case ("profesor"): return new Profesor(correo, contraseña, nombre, apellidos);
                case ("institucion"): return new Institucion(correo, contraseña, nombre);
            }
            
            return -1;
        }
    }
}