using System;
using System.Collections.Generic;
using System.Data;

namespace QuizifyIU {

    public partial class Notificaciones{

        public DataTable pila { get; set; }

        public List<Observador> suscriptores { get; set; }

        public Notificaciones(DataTable pila, List<IObserver<Notificaciones>> suscriptores) {
            this.pila = pila;
        }
        
        public DataTable GetPila() { return pila; }
        public List<Observador> GetSuscriptores() { return suscriptores; }

        public void SetPila(DataTable pila) { this.pila = pila; }
        public void SetSuscriptores(List<Observador> suscriptores) { this.suscriptores = suscriptores; }

        public void Subscribe(Observador suscriptor) { suscriptores.Add(suscriptor); }
        public void EliminarSuscriptor(Observador suscriptor) { suscriptores.Remove(suscriptor); }
        public void Notificar() {
            foreach(var suscriptor in suscriptores) {
                suscriptor.TransmitirNotificaciones(this.pila);
            }
        }
    }
}