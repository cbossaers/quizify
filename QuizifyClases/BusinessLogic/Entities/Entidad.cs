using System;

namespace Quizify.Entities
{
    public partial class Entidad
    {
        public Entidad(string correo, string tipo)
        {
            this.correo = correo;
            this.tipo = tipo;
        }
        public string GetCorreo()
        {
            return correo;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

    }
}