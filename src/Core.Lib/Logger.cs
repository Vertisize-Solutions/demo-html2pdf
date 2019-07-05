using System;

namespace Core.Lib
{
    public class Logger
    {
        private nk.logger.csv.Logger csvLogger;

        public Logger()
        {
            csvLogger = new nk.logger.csv.Logger();
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