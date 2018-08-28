using System.Web.Optimization;

namespace CarRental.Web
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
            bundles.Add(new StyleBundle("~/Content/pickadatecss").Include(
                        "~/Content/pickadate/themes/classic.css",
                        "~/Content/pickadate/themes/classic.date.css",
                        "~/Content/pickadate/themes/classic.time.css",
                        "~/Content/pickadate/themes/default.date.css",
                        "~/Content/pickadate/themes/default.time.css",
                        "~/Content/pickadate/themes/custom.css",
                        "~/Content/pickatime/pickatime.css",
                        "~/Content/pickatime/style.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}