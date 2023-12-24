namespace Module4_ModuleHW.DTO
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }

        public List<Pet> Pets = new List<Pet>();
    }
}
