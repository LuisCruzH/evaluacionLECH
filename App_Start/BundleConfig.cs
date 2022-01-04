
using System.Web;
using System.Web.Optimization;

namespace evaluacionLECH
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                     "~/Scripts/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                     "~/Scripts/modernizr-2.8.3.js"));
            bundles.Add(new ScriptBundle("~/bundles/alertify").Include(
                     "~/Scripts/alertify.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                    "~/Scripts/DataTables/jquery.dataTables.min.js",
                    "~/Scripts/DataTables/dataTables.bootstrap4.min.js",
                    "~/Scripts/DataTables/dataTables.select.min.js",
                    "~/Scripts/DataTables/dataTables.buttons.js",
                    "~/Scripts/DataTables/dataTables.fixedColumns.min.js"
                    ));
        }
    }
}