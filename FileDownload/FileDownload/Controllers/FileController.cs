namespace FileDownload.Controllers
{
    using System.IO;
    using System.Web.Hosting;
    using System.Web.Mvc;

    public class FileController : Controller
    {


        public ActionResult DownloadFile()
        {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/testfile.txt");
            
            byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(filepath));
        }
    }
}