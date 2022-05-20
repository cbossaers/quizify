using System;
using System.Collections.Generic;
using System.Data;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU {
    
    public class Observador : IObserver<Notificaciones> {

        public Observador() {}
        
        public void TransmitirNotificaciones(DataTable dt, Form1 aux) {
            aux.setNotificaciones(dt);
        }
        void IObserver<Notificaciones>.OnCompleted(){}
        void IObserver<Notificaciones>.OnError(Exception e) {}
        void IObserver<Notificaciones>.OnNext(Notificaciones x) {}
    }
}