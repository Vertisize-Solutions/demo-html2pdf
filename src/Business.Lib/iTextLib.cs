using Core.Lib;
using System;

namespace Business.Lib
{
    public class iTextLib
    {

        private Logger logger;

        public iTextLib()
        {
            logger = new Logger();
        }

        public void html2pdf(string html, string css)
        {
            try
            {

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
