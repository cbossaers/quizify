using System;
using System.Collections.Generic;
using System.Data;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU {
    
    public class Observador : IObserver<Notificaciones> {
        Form1 form = Principal.formportal;
        
        public void TransmitirNotificaciones(DataTable dt) {
            form.setNotificaciones(dt);
        }
        void IObserver<Notificaciones>.OnCompleted(){}
        void IObserver<Notificaciones>.OnError(Exception e) {}
        void IObserver<Notificaciones>.OnNext(Notificaciones x) {}
    }
}