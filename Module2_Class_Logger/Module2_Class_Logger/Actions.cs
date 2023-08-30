using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Class_Logger
{
    public static class Actions
    {
        public static Logger logger { get; set; }

        public static void InfoAction()
        {
            logger.LogLevel = Status.Info;
            logger.WriteLog();
        }

        public static void WarningAction()
        {
            logger.LogLevel = Status.Warning;
            logger.WriteLog();
        }

        public static void ErrorAction()
        {
            logger.LogLevel = Status.Error;
            logger.WriteLog();
        }
    }
}
