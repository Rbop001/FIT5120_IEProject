using System.Web;
using System.Web.Optimization;

namespace NavigatingMelbourne
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/vendor/jquery/jquery.min.js",
                      "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",

                      "~/assets/vendor/jquery.easing/jquery.easing.min.js",
                      "~/assets/vendor/php-email-form/validate.js",
                      "~/assets/vendor/counterup/counterup.min.js",
                      "~/assets/vendor/isotope-layout/isotope.pkgd.min.js",
                      "~/assets/vendor/owl.carousel/owl.carousel.min.js",

                      "~/assets/vendor/waypoints/jquery.waypoints.min.js",
                      "~/assets/vendor/venobox/venobox.min.js",
                      "~/assets/vendor/aos/aos.js",
                      "~/assets/js/main.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                      "~/assets/vendor/font-awesome/css/font-awesome.min.css",
                      "~/assets/vendor/ionicons/css/ionicons.min.css",
                      "~/assets/vendor/owl.carousel/assets/owl.carousel.min.css",
                      "~/assets/vendor/venobox/venobox.css",
                      "~/assets/vendor/aos/aos.css",
                      "~/assets/css/style.css"
             ));
        }
    }
}
