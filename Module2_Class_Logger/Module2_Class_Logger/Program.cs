namespace Module2_Class_Logger
{
    public class Program
    {
        static void Main(string[] args)
        {
            var instance = Logger.GetInstance();

            PopulateLogs(instance);
            Actions.logger = instance;
            Starter.Run();

            Console.ReadKey();
        }

        private static void PopulateLogs(Logger logger) 
        {
            Result result1 = new Result();
            Result result2 = new Result();
            Result result3 = new Result();

            result1.Status = Status.Info;
            result1.Message = "message 1";
            result1.DateTime = DateTime.Now.AddDays(1);

            result2.Status = Status.Warning;
            result2.Message = "message 2";
            result2.DateTime = DateTime.Now.AddDays(2);

            result3.Status = Status.Error;
            result3.Message = "message 3";
            result3.DateTime = DateTime.Now.AddDays(3);

            logger.AddLog(result1);
            logger.AddLog(result2);
            logger.AddLog(result3);
        }
    }
}