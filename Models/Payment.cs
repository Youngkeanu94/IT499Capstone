namespace IT499Capstone.Models
{
    public class Payment
    {
        public int? PaymentID { get; set; }
        public int? OrderID { get; set; }
        public decimal Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public Order? Order { get; set; }
    }
}
