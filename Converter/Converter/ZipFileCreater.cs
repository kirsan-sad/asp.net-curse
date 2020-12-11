using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class ZipFileCreater : IResultCreater
    {
        private const string _downloadZipFileName = "FahrenheitValueArchive.zip";
        private const string _downloadTxtFileName = "FahrenheitValue.txt";

        public IActionResult GetResult(string textToDownload)
        {
            IActionResult result = null;

            (string FileName, byte[] Content) fileTuple = (_downloadTxtFileName, Encoding.UTF8.GetBytes(textToDownload));

            result = new FileContentResult(CreateZipArchive(fileTuple), "application/zip")
            {
                FileDownloadName = _downloadZipFileName
            };

            return result;
        }

        private byte[] CreateZipArchive((string FileName, byte[] Content) fileTuple)
        {
            byte[] archiveFile;
            using (var archiveStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                {
                    var zipArchiveEntry = archive.CreateEntry(fileTuple.FileName, CompressionLevel.Fastest);
                    using (var zipStream = zipArchiveEntry.Open())
                        zipStream.Write(fileTuple.Content, 0, fileTuple.Content.Length);
                }

                archiveFile = archiveStream.ToArray();
            }

            return archiveFile;
        }
    }
}
