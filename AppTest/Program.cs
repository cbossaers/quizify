using System;
using Quizify.Entities;
using Quizify.Persistence;
using Quizify.Services;
namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL dal = new DAL();
            //dal.eliminarEntidad("correo");
            //dal.addEntidad("peper@pepe.com", "contraseña", "alumno", "pepito", "lopez");
            Console.WriteLine(dal.getEntidad("pepe2@pepe.com").nombre);
        }
    }
}
