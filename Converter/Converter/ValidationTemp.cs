using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Converter.Controllers
{
    public enum FileType
    {
        Txt,
        Zip,
        Stream
    }

    public class ValidationTemp : IValidator
    {
        public int TempF { get; set; }

        [Range(-273, 1000, ErrorMessage = "Invalid temp")]
        public int TempC { get; set; }

        [Range(0, 2, ErrorMessage = "Invalid num")]
        public FileType FileType { get; set; }

        public int GetTempFahrenheit(int tempC)
        {
            TempC = tempC;
            TempF = ((TempC * 9) / 5) + 32;

            return TempF;
        }

        public IActionResult GetTempFile(int tempC, FileType fileType)
        {
            IActionResult result = null;
            FileType = fileType;

            GetTempFahrenheit(tempC);

            var responseString = $"{TempC} °C is {TempF} °F";

            if(FileType == FileType.Txt)
            {
                IResultCreater txt = new TxtFileCreater();
                result = txt.GetResult(responseString);
            }
            
            else if(FileType == FileType.Zip)
            {
                IResultCreater zip = new ZipFileCreater();
                result = zip.GetResult(responseString);
            }

            else if (FileType == FileType.Stream)
            {
                IResultCreater stream = new StreamCreater();
                result = stream.GetResult(responseString);
            }

            return result;
        }

    }
}
