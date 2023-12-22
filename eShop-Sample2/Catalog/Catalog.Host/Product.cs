namespace Catalog.Host
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(int productID, string productName, int productPrice) 
        {
            Id=productID;
            Name=productName;
            Price=productPrice;
        }
    }
}
