﻿using System.Web.Optimization;

namespace MVC5Template
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // jquery-validate
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css"));

            // Handsontable
            bundles.Add(new ScriptBundle("~/bundles/handsontable").Include(
                        "~/Scripts/ZeroClipboard.js",
                        "~/Scripts/pikaday.js",
                        "~/Scripts/moment.js",
                        "~/Scripts/handsontable/handsontable.js"));

            bundles.Add(new StyleBundle("~/Content/handsontable").Include(
                        "~/Content/handsontable/handsontable.css"));

            // DataTables
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/DataTables-1.10.10/media/js/jquery.dataTables.js",
                        "~/Scripts/DataTables-1.10.10/media/js/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                        "~/Content/DataTables-1.10.10/media/css/dataTables.bootstrap.css"));

            // moment
            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                        "~/Scripts/moment.js"));

            // fullcalendar
            bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
                        "~/Scripts/moment.js",
                        "~/Scripts/fullcalendar.js"));

            bundles.Add(new StyleBundle("~/Content/fullcalendar").Include(
                        "~/Content/fullcalendar.css"));

            // bootstrap datepicker
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/locales/bootstrap-datepicker.ja.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-datepicker").Include(
                        "~/Content/bootstrap-datepicker.min.css"));


        }
    }
}
