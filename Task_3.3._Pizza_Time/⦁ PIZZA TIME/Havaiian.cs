﻿using System;

namespace __PIZZA_TIME
{
    public class Havaiian : Pizza
    {
        public override int TimeOfWaitingPizza { get; } = 5;

        public override void FinishedCookingPizza()
        {
            Console.WriteLine("Гавайская пицца готовится");
        }
    }
}
