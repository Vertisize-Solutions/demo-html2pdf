using Business.Lib;
using Business.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        [HttpPost]
        public void GeneratePdf([FromBody] HtmlData data)
        {
            var lib = new iTextLib();
            lib.html2pdf(data.html, data.css);
        }
    }
}