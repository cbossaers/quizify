using System;
using System.Threading;
using Quizify.Persistence;

namespace Quizify.Entities
{
    public class Hilos {

        DALExamen dalex = new DALExamen();
        DALAlumno dalal = new DALAlumno();

        public void HiloEstadoQuizes(){
            new Thread(() => {
            Thread.CurrentThread.IsBackground = true; 

            while(true) {
                System.Threading.Thread.Sleep(10000);
                dalex.ActualizarEstadoQuizes();
            }
        }).Start();
        }

        public void HiloGetNotificaciones(string correo) {
            new Thread(() => {
            Thread.CurrentThread.IsBackground = true; 

            while(true) {
                System.Threading.Thread.Sleep(2000);
                dalal.GetNotificaciones(correo);
            }
        }).Start();
        }
    }
}