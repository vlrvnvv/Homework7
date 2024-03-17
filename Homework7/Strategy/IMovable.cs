namespace Homework7.Strategy;

public interface IMovable
{
    void MoveOn()
    {
        Checking();
        Switching();
        Starting();
    }

    void Checking()
    {
        Console.WriteLine("Проверяем агрегат...");
    }

    void Switching();

    void Starting();
}
