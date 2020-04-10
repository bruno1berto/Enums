using Enumeracoes.Entities;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}
