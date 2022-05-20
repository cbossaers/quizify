using System;
using System.Threading;
using Quizify.Persistence;
using System.Data;

namespace Quizify.Entities
{
    public class Hilos {

        DALExamen dalex = new DALExamen();

        public void HiloEstadoQuizes(){
            new Thread(() => {
            Thread.CurrentThread.IsBackground = true; 

            while(true) {
                System.Threading.Thread.Sleep(10000);
                dalex.ActualizarEstadoQuizes();
            }
        }).Start();
        }
    }
}