using System.Web;
using System.Web.Optimization;

namespace TestApp
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Rutas CSS y scripts
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/plugins/fontawesome/css/all.min.css",
                "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                "~/Content/dist/css/adminlte.min.css",
                "~/Content/vendors/fontawesome/css/all.min.css",
                "~/Content/vendors/overlayScrollbars/css/OverlayScrollbars.min.css"
                ));

 
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Content/plugins/jquery/jquery.min.js",
                "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js", 
                "~/Content/dist/js/adminlte.min.js", 
                "~/Content/plugins/jquery/jquery.min.js", 
                "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                "~/Content/dist/js/adminlte.js",
                "~/Content/plugins/jquery-mousewheel/jquery.mousewheel.js",
                "~/Content/plugins/raphael/raphael.min.js",
                "~/Content/plugins/jquery-mapael/jquery.mapael.min.js", 
                "~/Content/plugins/jquery-mapael/maps/usa_states.min.js",
                "~/Content/plugins/chart.js/Chart.min.js",
                "~/Content/dist/js/demo.js",               
                "~/Content/dist/js/pages/dashboard2.js"
                ));
        }
    }
}
