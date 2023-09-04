namespace Module2_HW2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuService menuService = new MenuService();
            menuService.Menu();
            Console.ReadKey();
        }
    }
}