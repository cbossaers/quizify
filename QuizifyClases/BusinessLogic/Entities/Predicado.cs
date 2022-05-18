using System;
using System.Collections.Generic;
using System.Threading;
using Quizify.Entities;

namespace Quizify.Entities
{
    public class Predicado : IObserver {
        public void Update(ISubject subject)
        {            
            if ((subject as Sujeto).State < 3)
            {
                Console.WriteLine("Predicado: Reacted to the event.");
            }
        }
    }
}