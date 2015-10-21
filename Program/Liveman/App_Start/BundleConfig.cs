using System.Web;
using System.Web.Optimization;

namespace Liveman
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/metismenu").Include(
                      "~/Scripts/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/charts").Include(
                      "~/Scripts/raphael-min.js",
                      "~/Scripts/morris.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/designjs").Include(
                      "~/Scripts/sb-admin-2.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/metisMenu.min.css",
                      "~/Content/morris.min.css",
                      "~/Content/sb-admin-2.css",
                      "~/Content/timeline.css",
                      "~/Content/font-awesome.min.css"));
        }
    }
}
