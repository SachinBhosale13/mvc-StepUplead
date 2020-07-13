using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using DataAccessLayer;
using System.IO;

namespace StepUplead_MVC.Controllers
{
    public class HomeController : Controller
    {
        DAL objData = new DAL();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp) 
        {
            bool result = false;
            try
            {
               result =  objData.SaveEmployeeDetails(emp);
               if (result) 
               {
                   return RedirectToAction("ThankYou");
               }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
            return View();
        }


        public ActionResult ThankYou() 
        {
            return View();
        }

        
        public FileResult DownloadPDF() 
        {
            try
            {
                String path = Server.MapPath("~/App_Data/MVC_tutorial.pdf");
                string fileName = Path.GetFileName(path); 
                String mimeType = MimeMapping.GetMimeMapping(path);
                byte[] stream = System.IO.File.ReadAllBytes(path);

                return File(stream, mimeType, fileName);
                

                //return File("/App_Data/ProASP.NET-MVC-5_Platform.pdf", "application/pdf");
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        
    }
}