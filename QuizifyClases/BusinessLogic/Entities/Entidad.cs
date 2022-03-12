using System;

namespace Quizify.Entities
{
    public partial class Entidad
    {
        public Entidad(string correo)
        {
            this.correo = correo;
        }
        public string GetCorreo()
        {
            return correo;
        }
        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }
    }
}