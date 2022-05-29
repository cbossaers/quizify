namespace Quizify.Entities
{
    public class FabricaEntidades
    {
        public dynamic CrearEntidad (string tipo, string correo, string contraseña, string nombre, string apellidos, int quizes=20)
        {
            switch (tipo)
            {
                case ("alumno"): return new Alumno(correo, contraseña, nombre, apellidos);
                case ("profesor"): return new Profesor(correo, contraseña, nombre, apellidos,quizes);
            }
            
            return -1;
        }
    }
}