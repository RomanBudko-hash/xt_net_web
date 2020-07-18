using System;

namespace __PIZZA_TIME
{
    public class Order
    {
        public Order(string ClientName)
        {
            Console.WriteLine(ClientName + ", Ваша пицца готовится");
        }

        public event EventHandler<int> PizzaIsCooked;
    }
}
