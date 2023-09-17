namespace Module2_Class_Logger
{
    public class Program
    {
        static void Main(string[] args)
        {
            var instance = Logger.GetInstance();

            //PopulateLogs(instance);
            Actions.logger = instance;
            Starter.Run();

            Console.ReadKey();
        }
    }
}