﻿using System;
using System.Threading;

namespace __PIZZA_TIME
{
    public class Program
    {
        public static int FullTime = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");

            string Name = Console.ReadLine();

            Console.WriteLine("Выберите пиццу");
            Console.WriteLine("1.Pepperoni");
            Console.WriteLine("2.Margarita");
            Console.WriteLine("3.Havaiian");

            if (int.TryParse(Console.ReadLine(), out int choiceThePizza)
                && choiceThePizza > 0 && choiceThePizza < 4)
            {
                Order order = new Order(Name);

                order.PizzaIsCooked += Order_PizzaIsCooked;

                Order_PizzaIsCooked(order, choiceThePizza);

                Thread.Sleep(2000 * FullTime);

                Console.WriteLine("Пицца готова! Приятного аппетита");
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static void Order_PizzaIsCooked(object sender, int e)
        {
            switch (e)
            {
                case 1:
                    Pepperoni pepperoni = new Pepperoni();
                    pepperoni.FinishedCookingPizza();
                    FullTime = pepperoni.TimeOfWaitingPizza;
                    break;
                case 2:
                    Margarita margarita = new Margarita();
                    margarita.FinishedCookingPizza();
                    FullTime = margarita.TimeOfWaitingPizza;
                    break;
                case 3:
                    Havaiian havaiian = new Havaiian();
                    havaiian.FinishedCookingPizza();
                    FullTime = havaiian.TimeOfWaitingPizza;
                    break;
            }
        }
    }
}
