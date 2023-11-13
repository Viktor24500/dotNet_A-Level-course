namespace Module4_ModuleHW.DTO
{
    public class Location
    {
        public int locationId { get; set; }
        public string locationName { get; set; }

        public List<Pet> Pets = new List<Pet>();
    }
}
