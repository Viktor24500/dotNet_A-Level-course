using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Module2_Class_Logger
{
    public class Logger //singleton
    {
        private List<Result> _logs = null;
        private string _path = @"D:\dot_Net_course_A-level\";
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

        public void WriteLogToConsole(Result result)
        {
            Console.WriteLine($"{result.Status}, {result.DateTime}, {result.Message}");
        }

        public void WriteLogToFile(Result result) 
        {
            string fileName = $"{result.DateTime.ToString("MM_dd_yyyy_hh_mm_ss")}_fff.txt";
            string fullPath = _path + fileName;
            if (!File.Exists(fullPath))
            {
                StreamWriter sw = File.AppendText(fullPath);
                sw.WriteLine($"{result.Status}, {result.DateTime}, {result.Message}");
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText(fullPath);
                sw.WriteLine($"{result.Status}, {result.DateTime}, {result.Message}");
                sw.Close();
            }
        }
        public void WriteToJson(Result result) 
        {
            string fileName = $"{result.DateTime.ToString("MM_dd_yyyy_hh_mm_ss")}_fff.txt";
            string fullPath = _path + fileName;
            string json = JsonConvert.SerializeObject(result);
            if (!File.Exists(fullPath))
            {
                StreamWriter sw = File.AppendText(fullPath);
                sw.WriteLine(json);
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText(fullPath);
                sw.WriteLine(json);
                sw.Close();
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
