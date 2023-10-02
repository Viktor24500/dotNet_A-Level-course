namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<User> listUsers = new List<User>()
            {
                new User("Ava", "Smith", "ava.smith@gmail.com", new DateTime(1990, 7, 14), 1),
                new User("Artem", "Johnson", "artem.johnson@costoso.com", new DateTime(2007, 9, 20), 2),
                new User("Nika", "Williams", "nika.williams@ukr.net", new DateTime(2001, 8, 10), 3),
                new User("Alvin", "Rodriguez", "alvin.rodriguez@outlook.com", new DateTime(2010, 7, 25), 4),
                new User("John", "Martinez", "john.martinez@yahoo.com", new DateTime(2018, 12, 31), 5),
            };

            //1
            var users = listUsers.Where(x => 18 < DateTime.Now.Year - x.DateOfBirth.Year).
                Select(x => new {firstName = x.FirstName, lastName = x.LastName, dateOfBirth=x.DateOfBirth,
                    age = DateTime.Now.Year - x.DateOfBirth.Year });

            foreach (var item in users) 
            {
                Console.WriteLine($"{item.firstName}, {item.lastName}, date of birh - {item.dateOfBirth}, full years - {item.age}");
            }

            //2
            var groupUsersForMail = listUsers.GroupBy(x => x.Email.Contains("gmail.com")).
                Select(group => new
                {
                    domain = group.Key,
                    count = group.Count()
                });

            //3
            Dictionary<int, User> userDict = listUsers.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int, User> kvp in userDict)
            {
                Console.WriteLine(
                    "Key {0}: {1}, {2}, {3}, {4}",
                    kvp.Key,
                    kvp.Value.FirstName,
                    kvp.Value.LastName,
                    kvp.Value.Email,
                    kvp.Value.DateOfBirth);
            }

            //4
            var groupUsersForLastName = listUsers.GroupBy(x => x.LastName).
                Select(group => new { firstName = group.First().FirstName,
                DateOfBirth = group.First().DateOfBirth}).
                OrderBy(group => group.DateOfBirth).ToList();


            Console.ReadKey();
        }
    }
}