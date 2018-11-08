using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/pdf")]
    public class PdfController : Controller
    {
        [HttpPost]
        public void GeneratePdf([FromBody]HtmlData value)
        {

        }
    }
}
