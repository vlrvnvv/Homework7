using Homework7.Entities;

namespace Homework7.State;

public class FreezeCarState : ICarState
{
    public void Start(Car car)
    {
        car.State = new DriveCarState();
    }

    public void Stop(Car car)
    {
        car.State = new FreezeCarState();
    }
}
