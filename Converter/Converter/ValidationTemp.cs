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
    public class ValidationTemp
    {
        public int TempF { get; set; }

        [Range(-273, 1000, ErrorMessage = "Invalid temp")]
        public int TempC { get; set; }

        [Range(0, 2, ErrorMessage = "Invalid num")]
        public Helper.Output Output { get; set; }

        //private IResultCreater _resultCreater;

        //public ValidationTemp(IResultCreater resultCreater)
        //{
        //    _resultCreater = resultCreater;
        //}

        public IActionResult GetTempF()
        {
            IActionResult result = null;

            TempF = ((TempC * 9) / 5) + 32;

            var responseString = $"{TempC} °C is {TempF} °F";

            if(Output == Helper.Output.Txt)
            {
                IResultCreater txt = new TxtFileCreater();
                result = txt.GetResult(responseString);
                //result = _resultCreater.GetResult(responseString);
            }
            
            else if(Output == Helper.Output.Zip)
            {
                IResultCreater zip = new ZipFileCreater();
                result = zip.GetResult(responseString);
                //result = _resultCreater.GetResult(responseString);
            }

            else if (Output == Helper.Output.Stream)
            {
                IResultCreater stream = new StreamCreater();
                result = stream.GetResult(responseString);
                //result = _resultCreater.GetResult(responseString);
            }

            return result;
        }

    }
}
