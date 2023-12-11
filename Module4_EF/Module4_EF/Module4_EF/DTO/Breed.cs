namespace Module4_ModuleHW.DTO
{
    public class Breed
    {
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Pet> Pets = new List<Pet>();
    }
}
