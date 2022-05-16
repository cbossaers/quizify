using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using System.Threading;
using System.IO;
using Quizify.Persistence;

namespace Quizify.Entities {
    public class Observador {

        DALExamen dalex = new DALExamen();

        public static string TextoNotif = "";

        private event EventHandler TextChanged;

        
        

        public void test() {

        new Thread(() => {
            int aux = dalex.UltimoIdExamen();
            int aux2 = 0;
            Thread.CurrentThread.IsBackground = true; 

            for(int i = 0; i < 99999; i++) {
                System.Threading.Thread.Sleep(5000);
                aux2 = dalex.UltimoIdExamen();
                if(aux2 > aux) {
                    TextoNotif = dalex.Get(aux2).titulo;
                }
                aux = aux2;
            }
        }).Start();
    }
    }
}