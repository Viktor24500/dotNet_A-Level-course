namespace Module4_ModuleHW.DTO
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Breed> Breeds = new List<Breed>();
        public List<Pet> Pets = new List<Pet>();
    }
}
