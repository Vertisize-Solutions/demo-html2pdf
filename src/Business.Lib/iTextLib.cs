using Core.Lib;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using System;
using System.IO;

namespace Business.Lib
{
    public class iTextLib
    {

        private Logger logger;

        public iTextLib()
        {
            logger = new Logger();
        }

        public void iText7Html2Pdf(string html)
        {
            try
            {
                // Determine whether the directory exists.
                var directory = $"{AppDomain.CurrentDomain.BaseDirectory}pdfs";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var filePath = $"{directory}\\sample.pdf";
                var writer = new PdfWriter(filePath);

                HtmlConverter.ConvertToPdf(html, writer);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
