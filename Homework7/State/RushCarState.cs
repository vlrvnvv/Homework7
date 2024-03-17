using Homework7.Entities;

namespace Homework7.State;

public class RushCarState : ICarState
{
    public void Start(Car car)
    {
        car.State = new RushCarState();
    }

    public void Stop(Car car)
    {
        car.State = new DriveCarState();
    }
}
