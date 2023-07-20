using System.Web.Mvc;

namespace FileDownload.Controllers
{
    public class FileController : Controller
    {
        public ActionResult DownloadFile()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"c:\audio.log");
            string fileName = "audio.log";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}