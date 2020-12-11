using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class TxtFileCreater : IResultCreater
    {
        private const string _downloadTxtFileName = "FahrenheitValue.txt";
        public IActionResult GetResult(string textToDownload)
        {
            IActionResult result = null;

            result = new FileContentResult(Encoding.UTF8.GetBytes(textToDownload), "text/plain")
            {
                FileDownloadName = _downloadTxtFileName
            };

            return result;
        }
    }
}
