using Homework7.Strategy;

namespace Homework7;

public class PetrolMove : IMovable
{
    public void Starting()
    {
        Console.WriteLine("Перемещаюсь на бензине...");
    }

    public void Switching()
    {
        Console.WriteLine("Переключаюсь на бензин...");
    }
}
