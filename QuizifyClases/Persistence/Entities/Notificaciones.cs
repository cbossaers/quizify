using System;
using System.Collections.Generic;
using System.Data;

namespace Quizify.Entities {

    public partial class Notificaciones {

        public DataTable pila { get; set; }

        public List<IObserver<Notificaciones>> suscriptores { get; set; }
    }
}