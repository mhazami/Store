using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Store.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/script/bundel").Include(
                
                "~/App_Themes/Client/js/jquery.eislideshow.js",
                "~/App_Themes/Client/js/bootstrap.min.js",
                "~/App_Themes/Client/js/jquery.easing.js",
                "~/App_Themes/Client/js/jquery.dlmenu.js",
                "~/App_Themes/Client/js/jquery.smartwizard.js",
                "~/App_Themes/Client/js/jquery.formstyler.js",
                "~/App_Themes/Client/js/jquery.nicescroll.js",
                "~/App_Themes/Client/js/jquery.carouFredSel-6.2.1-packed.js",
                "~/App_Themes/Client/js/jquery.ui.core.js",
                "~/App_Themes/Client/js/jquery.ui.widget.js",
                "~/App_Themes/Client/js/jquery.ui.mouse.js",
                "~/App_Themes/Client/js/jquery.ui.slider.js",
                "~/App_Themes/Client/js/jquery.ui.tabs.js",
                "~/App_Themes/Client/js/jquery.modal.js",
                "~/App_Themes/Client/js/jquery.jcountdown.js",
                "~/App_Themes/Client/js/script.js"));



            bundles.Add(new StyleBundle("~/css/bundel").Include(
                "~/App_Themes/Client/css/style.css",
                "~/App_Themes/Client/css/jquery-ui.css",
                "~/App_Themes/Client/css/responsive-options.css",
                "~/App_Themes/Client/css/bootstrap.css",
                "~/App_Themes/Client/css/megamenu.css",
                "~/App_Themes/Client/css/bootstrap-responsive.css",
                "~/App_Themes/Client/css/jquery.formstyler.css",
                "~/App_Themes/Client/css/elastic-slideshow.css",
                "~/App_Themes/Client/css/dlmenu.css",
                "~/App_Themes/Client/css/smartwizard.css",
                "~/App_Themes/Client/css/font-awesome.css",
                "~/App_Themes/Client/css/multizoom.css",
                "~/App_Themes/Client/css/jquery.modal.css"));
        }
    }
}