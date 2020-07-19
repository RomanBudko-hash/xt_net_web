using System;

namespace __PIZZA_TIME
{
    public class Margarita : Pizza
    {
        public override int TimeOfWaitingPizza { get; } = 2;

        public override void FinishedCookingPizza()
        {
            Console.WriteLine("Маргарита готовится");
        }
    }
}
