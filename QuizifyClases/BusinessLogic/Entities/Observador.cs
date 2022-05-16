using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;
using System.Threading;
using System.IO;

namespace Quizify.Entities {
    public class Observador {

        public void test() {

        new Thread(() => {
        Thread.CurrentThread.IsBackground = true; 
        // Get the directories currently on the C drive.

            // Write each directory name to a file.

            for(int i = 0; i < 99999; i++) {

                System.Threading.Thread.Sleep(5000);

            }
        }).Start();
    }
    }
}