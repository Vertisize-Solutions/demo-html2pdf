using System;

namespace Core.Lib
{
    public class Logger
    {
        private nk.logger.csv.Logger csvLogger;
        private string dateFormat = "yyyy-MM-dd HH:mm:ss.fff";
        private string fileName = "ErrorLog";

        public Logger()
        {
            csvLogger = new nk.logger.csv.Logger(dateFormat, fileName);
        }

        public void Error(Exception ex)
        {
            csvLogger.Error(ex);
        }
        public void Error(string text)
        {
            csvLogger.Error(text);
        }

        public void Info(string text)
        {
            csvLogger.Info(text);
        }

    }
}