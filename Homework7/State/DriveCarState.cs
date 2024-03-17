using Homework7.Entities;

namespace Homework7.State;

public class DriveCarState : ICarState
{
    public void Start(Car car)
    {
        car.State = new RushCarState();
    }

    public void Stop(Car car)
    {
        car.State = new FreezeCarState();
    }
}
