using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Mediator
{
    public class CarUnlockMediator : Mediator
    {
        public Colleague Client { get; set; }

        public Colleague Car { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Client) 
            {
                Car.Notify(message);
            }
            else if (colleague == Car)
            {
                Client.Notify(message);
            }
        }
    }
}
