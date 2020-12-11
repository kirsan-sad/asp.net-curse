using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class StreamCreater : IResultCreater
    {
        private MemoryStream _ByteStream;
        public IActionResult GetResult(string textToDownload)
        {
            IActionResult result = null;

            _ByteStream = new MemoryStream(Encoding.UTF8.GetBytes(textToDownload));
            result = new FileStreamResult(_ByteStream, "application/octet-stream");
            
            return result;
        }
    }
}
