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
        [Route("itext7")]
        public IActionResult GeneratePdf([FromBody] HtmlData data)
        {
            var lib = new iTextLib();
            lib.iText7Html2Pdf(data.html);
            return Ok("");
        }
    }
}