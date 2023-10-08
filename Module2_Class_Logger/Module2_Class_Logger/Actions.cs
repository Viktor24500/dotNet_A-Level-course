using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Class_Logger
{
    public class Actions
    {

        public static Logger logger { get; set; }

        public static void InfoAction()
        {
            Result result = new Result();
            result.Status = Status.Info;
            result.DateTime = DateTime.Now;
            result.Message = "This is info message";
            logger.WriteToJson(result);
        }

        public static void WarningAction()
        {
            Result result = new Result();
            result.Status = Status.Warning;
            result.DateTime = DateTime.Now;
            result.Message = "This is warning message";
            logger.WriteToJson(result);
        }

        public static void ErrorAction()
        {
            try 
            {
                throw new BusinessException("Business Ex");
            }
            catch(BusinessException ex)
            {
                Result result = new Result();
                result.Status = Status.Error;
                result.DateTime = DateTime.Now;
                result.Message = ex.Message;
                logger.WriteToJson(result);
            }
        }
    }
}
