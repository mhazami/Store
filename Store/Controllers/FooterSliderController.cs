using DataStracture;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class FooterSliderController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: FoterSlider
        public ActionResult Index()
        {
            List<Slider> list = new List<Slider>();
            return View();
        }

        public ActionResult Create()
        {
            FooterSlider footreslider = new FooterSlider();
            return View(footreslider);
        }

        [HttpPost]
        public ActionResult Create(FooterSlider footreslide, HttpPostedFileBase image)
        {
            DataStracture.File file = new File();
            if (image != null)
            {
                file.Content = new byte[image.ContentLength];
                file.Size = image.ContentLength / 1024;
                file.Name = image.FileName;
                file.ContentType = image.ContentType;
                image.InputStream.Read(file.Content, 0, image.ContentLength);
                db.Files.Add(file);
                footreslide.FileId = file.Id;
            }

            db.FooterSliders.Add(footreslide);
            db.SaveChanges();

            return View();
        }
    }
}