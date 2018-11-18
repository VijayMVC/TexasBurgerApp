using System.Web;
using System.Web.Optimization;

namespace TexasBurgerApp
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

            bundles.Add(new ScriptBundle("~/bundles/CreateBurgerJS").Include(
                        "~/Scripts/CreateBurgerJS.js*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-journal.css",
                      "~/Content/animations.css",
                      "~/Content/menu-icons.css",
                      "~/Content/menu-icons-codes.css",
                      "~/Content/menu-icons-embedded.css",
                      "~/Content/menu-icons-ie7.css",
                      "~/Content/menu-icons-ie7-codes.css",
                      "~/Content/site.css"));
        }
    }
}
