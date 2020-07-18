using System;
using System.Threading;

namespace __PIZZA_TIME
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");

            string Name = Console.ReadLine();

            Console.WriteLine("Выберите пиццу");
            Console.WriteLine("1.Pepperoni");
            Console.WriteLine("2.Margarita");
            Console.WriteLine("3.Havaiian");

            int.TryParse(Console.ReadLine(), out int choiceThePizza);

            Order order = new Order(Name);

            order.PizzaIsCooked += Order_PizzaIsCooked;

            Order_PizzaIsCooked(order, choiceThePizza);
        }

        private static void Order_PizzaIsCooked(object sender, int e)
        {
            switch (e)
            {
                case 1:
                    Pepperoni pepperoni = new Pepperoni();
                    pepperoni.FinishedCookingPizza();
                    break;
                case 2:
                    Margarita margarita = new Margarita();
                    margarita.FinishedCookingPizza();
                    break;
                case 3:
                    Havaiian havaiian = new Havaiian();
                    havaiian.FinishedCookingPizza();
                    break;
            }
        }
    }
}
