using DataStracture;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class FileController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: File
        public ActionResult ShowImage(Guid id)
        {
            File file = db.Files.Find(id);
            return File(file.Content, "image/Png"); ;
        }
    }
}