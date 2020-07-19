using System;

namespace __PIZZA_TIME
{
    public class Pepperoni : Pizza
    {
        public override int TimeOfWaitingPizza { get; } = 3;

        public override void FinishedCookingPizza()
        {
            Console.WriteLine("Пеперони готовится");
        }
    }
}
