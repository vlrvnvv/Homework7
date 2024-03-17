using Homework7.Entities;
using Homework7.Mediator;
using Homework7.Momento;
using Homework7.State;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarUnlockMediator mediator = new CarUnlockMediator();

            Car car = new Car(new PetrolMove(), new FreezeCarState(), mediator);
            Client client = new Client(mediator)
            {
                Name = "Максим",
                Age = 27
            };

            mediator.Car = car;
            mediator.Client = client;

            if (client.Age >=  21)
            {
                client.Send("Разблокируйте дверь, мне больше 21");
                car.Send("Дверь разблокирована"); 
            }
            else
            {
                client.Send("Разблокируйте дверь, мне меньше 21");
                car.Send("Вам меньше 21, дверь не может быть разблокирована");
            }
        }
    }
}
