using Homework7.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Entities
{
    public class Client : Colleague
    {
        public Client(Mediator.Mediator mediator) : base(mediator) { }

        public string Name { get; set; }

        public int Age { get; set; }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение клиенту:{message}"); ;
        }
    }
}
