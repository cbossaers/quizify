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
            dal.eliminarEntidad("pepe@pepe.com");
        }
    }
}
