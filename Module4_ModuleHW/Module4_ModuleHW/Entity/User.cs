namespace Module4_ModuleHW.Entity
{
    public class User
    {
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
