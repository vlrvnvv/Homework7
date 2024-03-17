using Homework7.Mediator;
using Homework7.Momento;
using Homework7.State;
using Homework7.Strategy;

namespace Homework7.Entities;

public class Car : Colleague
{
    public ICarState State { get; set; }

    public string Client { get; set; }

    public int Odometr { get; set; }

    public CarMomento SaveState()
    {
        return new CarMomento(State, Client, Odometr);
    }

    public void RestoreState(CarMomento memento)
    {
        State = memento.State;
        Client = memento.Client;
        Odometr = memento.Odometr;
    }

    public IMovable Movable { private get; set; } //private get; 
    public Car(IMovable movable, ICarState state, Mediator.Mediator mediator) : base(mediator) 
    {
        Movable = movable;
        State = state;
    }

    public void Move()
    {
        Movable.MoveOn();
    }

    public void Start()
    {
        State.Start(this);
    }

    public void Stop()
    {
        State.Stop(this);
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Сообщение автомобилю:{message}");
    }
}
