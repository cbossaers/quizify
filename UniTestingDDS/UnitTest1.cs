using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quizify.Entities;
using Quizify.Services;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace UniTestingDDS
{
    [TestClass]
    public class UnitTest1
    {
        FabricaEntidades fabricaent = new FabricaEntidades();
        FabricaPreguntas fpreg = new FabricaPreguntas();
        FabricaExamenes fex = new FabricaExamenes();
        public static System.Random r = new System.Random();
        NuevoServicio serv = new NuevoServicio();

        public static string RandomString(int length) {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[r.Next(s.Length)]).ToArray());
        }

        [TestMethod]
        public void TestAlumno() {
            string correo = RandomString(16);

            Alumno al = fabricaent.CrearEntidad("alumno", correo, "contraseña", "nombre", "apellido");

            serv.AddAlumno(al);
            
            Assert.AreEqual(correo, serv.GetAlumno(correo).GetCorreo());
        }

        [TestMethod]
        public void TestProfesor() {
            string correo = RandomString(16);

            Alumno al = fabricaent.CrearEntidad("profesor", correo, "contraseña", "nombre", "apellido");

            serv.AddAlumno(al);
            
            Assert.AreEqual(correo, serv.GetProfesor(correo).GetCorreo());
        }

        [TestMethod]
        public void TestPregunta() {
            string enunciado = RandomString(16);
            int ultimoid = serv.UltimoIdPregunta();

            List<dynamic> paramtest = new List<dynamic>{1,"hola","hola2","hola3"};
            Pregunta2 test = fpreg.CrearPregunta2(ultimoid+1,1,enunciado,"test",1,"patricio@gmail.com","PSW","",paramtest);
            serv.AddPregunta(test);

            List<dynamic> paramvf = new List<dynamic>{1};
            Pregunta2 vf = fpreg.CrearPregunta2(ultimoid+2,1,enunciado,"vf",1,"patricio@gmail.com","PSW","",paramvf);
            serv.AddPregunta(vf);

            List<dynamic> parammult = new List<dynamic>{101,"hola","hola2","hola3"};
            Pregunta2 mult = fpreg.CrearPregunta2(ultimoid+3,1,enunciado,"mult",1,"patricio@gmail.com","PSW","",parammult);
            serv.AddPregunta(mult);

            List<dynamic> paramdes = new List<dynamic>{""};
            Pregunta2 des = fpreg.CrearPregunta2(ultimoid+4,1,enunciado,"des",1,"patricio@gmail.com","PSW","",paramdes);
            serv.AddPregunta(des);
            
            Assert.AreEqual(test, serv.GetPregunta(ultimoid+1,1));
            Assert.AreEqual(vf, serv.GetPregunta(ultimoid+2,1));
            Assert.AreEqual(mult, serv.GetPregunta(ultimoid+3,1));
            Assert.AreEqual(des, serv.GetPregunta(ultimoid+4,1));
        }
    }
}
