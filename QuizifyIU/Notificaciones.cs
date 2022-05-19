using System;
using System.Collections.Generic;
using System.Data;

namespace QuizifyIU {

    public partial class Notificaciones : IObservable<Notificaciones>{

        public Notificaciones(DataTable pila, List<IObserver<Notificaciones>> suscriptores) {
            this.pila = pila;
        }
        
        public DataTable GetPila() { return pila; }
        public List<IObserver<Notificaciones>> GetSuscriptores() { return suscriptores; }

        public void SetPila(DataTable pila) { this.pila = pila; }
        public void SetSuscriptores(List<IObserver<Notificaciones>> suscriptores) { this.suscriptores = suscriptores; }

        public void AddSuscriptor(IObserver<Notificaciones> suscriptor) { suscriptores.Add(suscriptor); }
        public void EliminarSuscriptor(IObserver<Notificaciones> suscriptor) { suscriptores.Remove(suscriptor); }
        public void Notificar() {
            foreach(var suscriptor in suscriptores) {
                suscriptor.TransmitirNotificaciones(this.pila);
            }
        }
    }
}