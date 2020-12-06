using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HASOapi2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HASOapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {


        [HttpPost, DisableRequestSizeLimit]

        public FileStream DownloadFile([FromBody] Uploadedfile files)
        {
            var folderName = Path.Combine("Ressources", "temp");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);


            var file = Path.Combine(pathToSave, files.path);

            return new FileStream(file, FileMode.Open, FileAccess.Read);
        }
    }
}