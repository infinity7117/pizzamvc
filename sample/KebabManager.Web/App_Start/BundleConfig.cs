﻿using System.Web;
using System.Web.Optimization;

namespace KebabManager.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/i18n/grid.locale-en.js",
                "~/Scripts/jquery.jqGrid.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"
            ));

            bundles.Add(new ScriptBundle("~/bundles/tinymce").Include(
                "~/Scripts/tinymce/tinymce.js",
                "~/Scripts/tinymce/jquery.tinymce.min.js"
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap-datepicker.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-datepicker3.css",

                "~/Content/jquery.ui.theme.css",
                
                "~/Content/site.css",

                "~/Content/jquery.jqGrid/ui.jqgrid.css",
                "~/Content/jqGrid.bootstrap.css"
                
                //"~/Content/themes/base/jquery.ui.core.css",
                //"~/Content/themes/base/jquery.ui.resizable.css",
                //"~/Content/themes/base/jquery.ui.selectable.css",
                //"~/Content/themes/base/jquery.ui.accordion.css",
                //"~/Content/themes/base/jquery.ui.autocomplete.css",
                //"~/Content/themes/base/jquery.ui.button.css",
                //"~/Content/themes/base/jquery.ui.dialog.css",
                //"~/Content/themes/base/jquery.ui.slider.css",
                //"~/Content/themes/base/jquery.ui.tabs.css",
                //"~/Content/themes/base/jquery.ui.datepicker.css",
                //"~/Content/themes/base/jquery.ui.progressbar.css",
                //"~/Content/themes/base/jquery.ui.theme.css"
            ));
        }
    }
}