namespace Infrasructure.RateLimit.Models
{
    public class KeyModel
    {
        public string Ip { get; set; } = null!;
        public string Endpoint { get; set; } = null!;
    }
}
