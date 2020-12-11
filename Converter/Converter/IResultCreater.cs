using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public interface IResultCreater
    {
        IActionResult GetResult(string textToDownload);
    }
}
