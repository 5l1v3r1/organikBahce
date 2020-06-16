using System.Web;
using System.Web.Optimization;

namespace organikBahce.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/assets/js/bootstrap.min.js",
                      "~/Content/assets/js/owl.carousel.min.js",
                      "~/Content/assets/js/jquery.themepunch.revolution.min.js",
                      "~/Content/assets/js/jquery.themepunch.plugins.min.js",
                      "~/Content/assets/js/engo-plugins.js",
                      "~/Content/assets/js/slick.min.js",
                      "~/Content/assets/js/store.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/css/bootstrap.css",
                      "~/Content/assets/vendor/owl-slider.css",
                      "~/Content/assets/vendor/settings.css",
                      "~/Content/assets/css/style.css"));
        }
    }
}
