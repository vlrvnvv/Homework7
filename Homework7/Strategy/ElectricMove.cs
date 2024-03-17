using Homework7.Strategy;

namespace Homework7
{
    public class ElectricMove : IMovable
    {
        public void Starting()
        {
            Console.WriteLine("Перемещаюсь на электричестве...");
        }

        public void Switching()
        {
            Console.WriteLine("Переключаюсь на электро...");
        }
    }

}
