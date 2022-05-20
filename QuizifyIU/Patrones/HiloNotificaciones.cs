using System;
using System.Threading;
using Quizify.Persistence;
using System.Data;

namespace QuizifyIU
{
    public class HiloNotificaciones {

        DALAlumno dalal = new DALAlumno();
        //Form1 form = Principal.formportal;

        public void HiloGetNotificaciones(string correo, Form1 aux) {
            var threadParameters = new System.Threading.ThreadStart(delegate { 
                while(true) {
                    System.Threading.Thread.Sleep(2000);
                    aux.LlamarDataFetch(dalal.GetNotificaciones(correo));
                } 
            });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();
        }
    }
}