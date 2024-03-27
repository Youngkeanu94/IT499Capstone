namespace IT499Capstone.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Tax { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } 
        public Payment Payment { get; set; }
    }
}
