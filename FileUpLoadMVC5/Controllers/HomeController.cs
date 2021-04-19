using FileUpLoadMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpLoadMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


             [HttpGet]
        public ActionResult PreviewMultipleFile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FilePreviewBeforeUpload()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(User user, HttpPostedFileBase file)
        {
            if (file == null){
                //in the case file is null
            }
            else
            {
                string path = Server.MapPath("~/Images");
                string fileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
                string fileExtension = System.IO.Path.GetExtension(file.FileName);
                fileName = Guid.NewGuid() + fileExtension;
                //string fileName = System.IO.Path.GetFileName(file.FileName);
                string fullPath = System.IO.Path.Combine(path, fileName);
                file.SaveAs(fullPath);
            }
            return View();
        }

        public FileResult FileDownload(User user, HttpPostedFileBase file)
        {
                string path = Server.MapPath("~/Images");
                string fileName = System.IO.Path.GetFileName("a025c4b7-fd28-459d-b417-28a9332e2563.jpg");
                //string fileExtension = System.IO.Path.GetExtension(file.FileName);
                //fileName = Guid.NewGuid() + fileExtension;
                //string fileName = System.IO.Path.GetFileName(file.FileName);
                string fullPath = System.IO.Path.Combine(path, fileName);
            return File(fullPath,"image/*","download.jpg");
        }

        public ActionResult FileUploadAjax()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUploadAjax(User user)
        {
            return View();
        }
    }
}