using System;
using System.Collections.Generic;
using System.Data;

namespace QuizifyIU {

    public partial class Notificaciones{

        public DataTable pila { get; set; }
        public List<Observador> suscriptores { get; set; }
        public Form1 portal { get; set; }
        public Notificaciones(Form1 portal) {
            pila = new DataTable();
            suscriptores = new List<Observador>();
            this.portal = portal;
        }
        
        public DataTable GetPila() { return pila; }
        public List<Observador> GetSuscriptores() { return suscriptores; }

        public void SetPila(DataTable pila) { this.pila = pila; }
        public void SetSuscriptores(List<Observador> suscriptores) { this.suscriptores = suscriptores; }

        public void Subscribe(Observador suscriptor) { suscriptores.Add(suscriptor); }
        public void Unsubscribe(Observador suscriptor) { suscriptores.Remove(suscriptor); }
        public void Notify() {
            foreach(var suscriptor in suscriptores) {
                suscriptor.TransmitirNotificaciones(this.pila,portal);
            }
        }
        public void DataFetch(DataTable dt) {
            this.pila = dt;
            Notify();
        }
    }
}