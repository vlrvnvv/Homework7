using Homework7.Entities;

namespace Homework7.State;

public interface ICarState
{
    void Start(Car car);

    void Stop(Car car);
}
