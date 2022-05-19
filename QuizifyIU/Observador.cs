using System;
using System.Collections.Generic;
using System.Data;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU {

    public class Observador : IObserver<Notificaciones> {

        public void TransmitirNotificaciones(DataTable dt) {
            Form1 form = new Form1();
        }
    }
}