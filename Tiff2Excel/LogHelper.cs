using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Tiff2Excel
{
    public class LogHelper
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static void startLogging()
        {
            logger.Trace("Application start");
        }
        public static void addTrace(string trace)
        {
            logger.Trace(trace);
        }
        public static void addError(string trace)
        {
            logger.Error(trace);
        }

    }
}
