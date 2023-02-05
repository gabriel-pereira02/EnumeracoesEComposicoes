using Enums;

namespace Enum.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Date} - {Status}";
        }
    }
}