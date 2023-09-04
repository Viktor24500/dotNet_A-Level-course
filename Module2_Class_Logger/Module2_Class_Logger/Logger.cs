using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module2_Class_Logger
{
    public class Logger //singleton
    {
        private List<Result> _logs = null;
        private string _path = @"D:\dot_Net_course_A-level\logs.txt";
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

        public void WriteLogToConsole()
        {
            foreach (Result item in _logs) 
            {
                if (item.Status == LogLevel)
                {
                    Console.WriteLine($"{item.DateTime}: {item.Status}: {item.Message}");
                }
                    
            }
        }

        public void WriteLogToFile() 
        {
            foreach (Result item in _logs)
            {
                if (!File.Exists(_path))
                {
                    StreamWriter sw = File.AppendText(_path);
                    if (item.Status == LogLevel)
                    {
                        sw.WriteLine($"{item.DateTime}: {item.Status}: {item.Message}");
                    }
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = File.AppendText(_path);
                    if (item.Status == LogLevel)
                    {
                        sw.WriteLine($"{item.DateTime}: {item.Status}: {item.Message}");
                    }
                    sw.Close();
                }
            }
        }

        public void AddLog(Result log) 
        {
            if (_logs == null) 
            {
                _logs = new List<Result>();
            }
            _logs.Add(log);
        }
    }
}
