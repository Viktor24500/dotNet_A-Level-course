namespace Module4_ModuleHW.DTO
{
    public class Pet
    {
        public int petId {  get; set; }
        public string petName { get; set; }
        public int? categoryId { get; set; }

        public Category? Category { get; set; }
        public int? breedId { get; set; }

        public Breed? Breed { get; set; }
        public float petAge { get; set; }
        public int? locationId { get; set; }

        public Location? Location { get; set; }
        public string imageUrl { get; set; }
        public string petDescription { get; set; }
    }
}
