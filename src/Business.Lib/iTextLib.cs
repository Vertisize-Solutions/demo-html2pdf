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

        public byte[] iText7Html2Pdf(string html)
        {
            try
            {
                // Determine whether the directory exists.
                var directory = $"{AppDomain.CurrentDomain.BaseDirectory}pdfs";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var filePath = $"{directory}\\sample-{DateTime.UtcNow}.pdf";
                var writer = new PdfWriter(filePath);

                HtmlConverter.ConvertToPdf(html, writer);

                using (var stream = File.OpenRead(filePath))
                {
                    MemoryStream result = new MemoryStream();
                    stream.CopyTo(result);
                    return result.ToArray();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return null;
            }
        }
    }
}
