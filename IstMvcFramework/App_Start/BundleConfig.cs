using System.Web.Optimization;

namespace IdentitySample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

           
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Bundle/CentaurusLibs")
               .Include("~/Content/Centaurus/Centaurus/js/demo-skin-changer.js")
               
               .Include("~/Content/Centaurus/Centaurus/js/jquery.nanoscroller.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/demo.js")
               .Include("~/Content/Centaurus/Centaurus/js/jquery.slimscroll.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/raphael-min.js")
               .Include("~/Content/Centaurus/Centaurus/js/morris.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/daterangepicker.js")
               .Include("~/Content/Centaurus/Centaurus/js/jquery-jvectormap-1.2.2.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/jquery-jvectormap-world-merc-en.js")
               .Include("~/Content/Centaurus/Centaurus/js/gdp-data.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.pie.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.stack.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.resize.min.js")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.time.min")
               .Include("~/Content/Centaurus/Centaurus/js/flot/jquery.flot.threshold.js")
               .Include("~/Content/Centaurus/Centaurus/js/scripts.js")
               .Include("~/Content/Centaurus/Centaurus/js/jquery.nestable.js")
               .Include("~/Content/Centaurus/Centaurus/js/jquery.nouislider.js")
               //.Include("~/Content/Centaurus/Centaurus/js/jquerySlider.js")
               );

            bundles.Add(new StyleBundle("~/Content/Centaurus/Centaurus/css/bundleCentaurus/css")
               //.Include("~/Content/Centaurus/Centaurus/css/bootstrap/bootstrap.min.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/font-awesome.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/nanoscroller.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/datepicker.css")
               .Include("~/Content/Centaurus/Centaurus/css/compiled/layout.css")
               .Include("~/Content/Centaurus/Centaurus/css/compiled/elements.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/dropzone.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/magnific-popup.css")
               .Include("~/Content/Centaurus/Centaurus/css/compiled/calendar.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/morris.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/daterangepicker.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/jquery-jvectormap-1.2.2.css")
               .Include("~/Content/Centaurus/Centaurus/css/compiled/wizard.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/bootstrap-wizard.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/select2.css")
               .Include("~/Content/Centaurus/Centaurus/css/libs/jquery.nouislider.css")
               .Include("~/Content/CSS/jquery-Slider.css"));

            bundles.Add(new StyleBundle("~/Bundles/BaseCss")
                .Include("~/Content/CSS/toastr.css")
                .Include("~/Content/colorpicker.css")
                .Include("~/Content/CSS/spectrum.css")
                .Include("~/RichTextEditor/skins/moono/editor.css")
                .Include("~/Content/CSS/custom.css"));
            
            bundles.Add(new ScriptBundle("~/Bundle/BaseLibs")
                //.Include("~/Scripts/jquery-ui-1.10.4.js")
                .Include("~/Scripts/json2.js")
                .Include("~/Scripts/knockout-3.1.0.js")
                .Include("~/Scripts/knockout.mapping-latest.js")
                .Include("~/Scripts/knockout.validation.js")
                .Include("~/Scripts/underscore.js")
                .Include("~/Scripts/underscore-ko-1.6.0.js")
                .Include("~/Scripts/moment.js")
                .Include("~/Scripts/toastr.js")
                .Include("~/Scripts/require.js")
                .Include("~/Scripts/amplify.js")
                .Include("~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/Centaurus/base/css").Include(
               "~/Content/Centaurus/base/jquery.ui.core.css",
               "~/Content/Centaurus/base/jquery.ui.resizable.css",
               "~/Content/Centaurus/base/jquery.ui.selectable.css",
               "~/Content/Centaurus/base/jquery.ui.accordion.css",
               "~/Content/Centaurus/base/jquery.ui.autocomplete.css",
               "~/Content/Centaurus/base/jquery.ui.button.css",
               "~/Content/Centaurus/base/jquery.ui.dialog.css",
               "~/Content/Centaurus/base/jquery.ui.slider.css",
               "~/Content/Centaurus/base/jquery.ui.tabs.css",
               "~/Content/Centaurus/base/jquery.ui.datepicker.css",
               "~/Content/Centaurus/base/jquery.ui.progressbar.css",
               "~/Content/Centaurus/Centaurus/css/libs/select2.css",
               "~/Content/Centaurus/base/jquery.ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-rtl").Include(
           "~/Scripts/bootstrap-rtl.js"));

            bundles.Add(new StyleBundle("~/Content/css-rtl").Include(
                      "~/Content/CSS/bootstrap-rtl.css"));

            bundles.Add(new StyleBundle("~/Content/siteCss").Include(
                      "~/Content/toastr.css",
                      "~/Content/site.css",
                      "~/Content/CSS/architecture.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                                        "~/Content/themes/base/jquery.ui.core.css",
                                        "~/Content/themes/base/jquery.ui.resizable.css",
                                        "~/Content/themes/base/jquery.ui.selectable.css",
                                        "~/Content/themes/base/jquery.ui.accordion.css",
                                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                                        "~/Content/themes/base/jquery.ui.button.css",
                                        "~/Content/themes/base/jquery.ui.dialog.css",
                                        "~/Content/themes/base/jquery.ui.slider.css",
                                        "~/Content/themes/base/jquery.ui.tabs.css",
                                        "~/Content/themes/base/jquery.ui.datepicker.css",
                                        "~/Content/themes/base/jquery.ui.progressbar.css",
                                        "~/Content/themes/base/jquery.ui.theme.css"));

        }
    }
}
