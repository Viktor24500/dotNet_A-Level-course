namespace Module4_ModuleHW.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        public User? User { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
