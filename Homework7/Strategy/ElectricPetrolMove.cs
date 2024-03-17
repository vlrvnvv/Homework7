using Homework7.Strategy;

namespace Homework7
{
    public class ElectricPetrolMove : IMovable
    {
        public void Checking()
        {
            Console.WriteLine("Проверяем агрегат...");
            Console.WriteLine("Проверяем агрегат...");
        }

        public void Starting()
        {
            Console.WriteLine("Перемещаюсь на гибрид...");
        }

        public void Switching()
        {
            Console.WriteLine("Переключаюсь на электро...");
            Console.WriteLine("Переключаюсь на бензин...");
        }
    }

}
