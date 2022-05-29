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
            string correo = RandomString(6) + "@" + RandomString(6) + ".com";

            Alumno al = fabricaent.CrearEntidad("alumno", correo, "contraseña", "nombre", "apellido");

            serv.AddAlumno(al);
            
            Assert.AreEqual(correo, serv.GetAlumno(correo).GetCorreo());
        }

        [TestMethod]
        public void TestProfesor() {
            string correo = RandomString(6) + "@" + RandomString(6) + ".com";

            Profesor al = fabricaent.CrearEntidad("profesor", correo, "contraseña", "nombre", "apellido");

            serv.AddProfesor(al);
            
            Assert.AreEqual(correo, serv.GetProfesor(correo).GetCorreo());
        }

        [TestMethod]
        public void TestPregunta() {
            string enunciado = RandomString(16);
            int ultimoid = serv.UltimoIdPregunta();

            List<dynamic> paramtest = new List<dynamic>{1,RandomString(6),RandomString(6),RandomString(6)};
            Pregunta2 test = fpreg.CrearPregunta2(ultimoid+1,1,enunciado,"test",1,"patricio@gmail.com","PSW","",paramtest);
            serv.AddPregunta(test);

            List<dynamic> paramvf = new List<dynamic>{1};
            Pregunta2 vf = fpreg.CrearPregunta2(ultimoid+2,1,enunciado,"vf",1,"patricio@gmail.com","PSW","",paramvf);
            serv.AddPregunta(vf);

            List<dynamic> parammult = new List<dynamic>{101,RandomString(6),RandomString(6),RandomString(6)};
            Pregunta2 mult = fpreg.CrearPregunta2(ultimoid+3,1,enunciado,"mult",1,"patricio@gmail.com","PSW","",parammult);
            serv.AddPregunta(mult);

            List<dynamic> paramdes = new List<dynamic>{""};
            Pregunta2 des = fpreg.CrearPregunta2(ultimoid+4,1,enunciado,"des",1,"patricio@gmail.com","PSW","",paramdes);
            serv.AddPregunta(des);
            
            Assert.AreEqual(test.GetId(), serv.GetPregunta(ultimoid+1,1).GetId());
            Assert.AreEqual(vf.GetId(), serv.GetPregunta(ultimoid+2,1).GetId());
            Assert.AreEqual(mult.GetId(), serv.GetPregunta(ultimoid+3,1).GetId());
            Assert.AreEqual(des.GetId(), serv.GetPregunta(ultimoid+4,1).GetId());
        }

        [TestMethod]
        public void TestExamen() {
            List<int> lista = new List<int>{11,1,3,12,1,6,13,1,6,14,1,2,15,1,2,16,1,7,17,1,4};
            int x = serv.UltimoIdExamen()+1;

            Examen ex = fex.CrearExamen(x,RandomString(6),RandomString(16),"PSW","patricio@gmail.com",
            60,System.DateTime.Now,System.DateTime.Now.AddDays(1),System.DateTime.Now.AddDays(12),5,1,0,0,lista,"Borrador","Normal");

            serv.AddExamen(ex);

            Assert.AreEqual(ex.GetTitulo(),serv.GetExamen(x).GetTitulo());
        }
    }
}
