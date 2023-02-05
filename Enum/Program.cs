using Enum.Entities;
using Enums;

namespace Enum{
    class Program{
        static void Main(string[] args){
            Order order = new Order{
                Id = 1235,
                Date = DateTime.Now,
                Status = OrderStatus.Delivered
            } ; 

            Console.Write(order);

            string txt = OrderStatus.Delivered.ToString();
            Console.WriteLine(txt);
        }
    }
}