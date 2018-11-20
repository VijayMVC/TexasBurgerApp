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


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/bootstrap-journal").Include("~/Content/bootstrap-journal.css"));

            bundles.Add(new StyleBundle("~/Content/cssbundles").Include(
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
