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
        public ActionResult Create(FooterSlider footreslider)
        {
            return View();
        }
    }
}