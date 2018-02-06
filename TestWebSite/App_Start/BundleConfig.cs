using System.Web;
using System.Web.Optimization;

namespace TestWebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                        "~/Content/plugins/datatables.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.bootstrap.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.bootstrap4.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.colVis.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.flash.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.foundation.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.html5.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.jqueryui.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.print.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/buttons.semanticui.min.js",
                        "~/Content/plugins/Buttons-1.5.1/js/dataTables.buttons.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/dataTables.bootstrap.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/dataTables.bootstrap4.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/dataTables.foundation.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/dataTables.jqueryui.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/dataTables.semanticui.min.js",
                        "~/Content/plugins/DataTables-1.10.16/js/jquery.dataTables.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/dataTables.responsive.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/responsive.bootstrap.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/responsive.bootstrap4.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/responsive.foundation.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/responsive.jqueryui.min.js",
                        "~/Content/plugins/Responsive-2.2.1/js/responsive.semanticui.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
