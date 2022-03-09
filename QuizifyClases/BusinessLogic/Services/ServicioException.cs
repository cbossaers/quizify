using System;

namespace Quizify.Services
{
    public class ServicioException : Exception
    {
        public ServicioException()
        {
        }

        public ServicioException(string message)
        : base(message)
        {
        }

        public ServicioException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }

}