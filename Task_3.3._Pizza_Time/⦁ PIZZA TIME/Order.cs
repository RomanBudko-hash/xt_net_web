using System;

namespace __PIZZA_TIME
{
    public class Order
    {
        public Order(string ClientName)
        {
            Console.WriteLine(ClientName + ", мы уже выращиваем продукты для Вашей пиццы, ожидайте");
        }

        public event EventHandler<int> PizzaIsCooked;
    }
}
