using DataStracture;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class SliderController : Controller
    {
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
                slider.Image = file;
            }

            return View();
        }
    }
}