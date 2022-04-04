using Enum_1.Entities;
using Enum_1.Entities.Enuns;

namespace Enum_1
{
    class Program
    {
        static void Main(string [] args)
        {
            Order order = new Order() { ID = 100,
            Moment = DateTime.Now,
            Status = OrderStatus.Delivered};

            Console.WriteLine(order.ToString());

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }

        
    }
}