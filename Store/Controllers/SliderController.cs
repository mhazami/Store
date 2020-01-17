using DataStracture;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class SliderController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: Slider
        public ActionResult Index()
        {
            List<Slider> list = new List<Slider>();
            return View(list);
        }

        public ActionResult Create()
        {
            Slider slider = new Slider();
            return View(slider);
        }

        [HttpPost]
        public ActionResult Create(Slider slider, HttpPostedFileBase image)
        {
            DataStracture.File file = new File();

            if (image != null)
            {
                file.Content = new byte[image.ContentLength];
                file.Size = image.ContentLength / 1024;
                file.Name = image.FileName;
                file.ContentType = image.ContentType;
                image.InputStream.Read(file.Content, 0, image.ContentLength);
                file.Id = Guid.NewGuid();
                db.Files.Add(file);
                slider.FileId = file.Id;
            }
            slider.Id = Guid.NewGuid();
            db.Sliders.Add(slider);
            db.SaveChanges();

            return View();
        }
    }
}