using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Class_Logger
{
    public class Logger //singleton
    {
        private List<Result> logs = null;
        private Logger() { } //private singleton constructor

        private static Logger _instance;

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public Status LogLevel { get; set; }

        public void WriteLog()
        {
            foreach (Result item in logs) 
            {
                if (item.Status==LogLevel)
                {
                    Console.WriteLine($"{item.DateTime}: {item.Status}: {item.Message}");
                }
            }
        }

        public void AddLog(Result log) 
        {
            if (logs == null) 
            {
                logs = new List<Result>();
            }
            logs.Add(log);
        }
    }
}
