using Homework7.State;

namespace Homework7.Momento;

public class CarMomento
{
    public CarMomento(ICarState state, string client, int odometr)
    {
        State = state;
        Client = client;
        Odometr = odometr;
    }

    public ICarState State { get; set; }
    public string Client { get; set; }
    public int Odometr { get; set; }
}
