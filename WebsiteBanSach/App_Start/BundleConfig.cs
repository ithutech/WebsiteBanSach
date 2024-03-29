﻿using System.Web;
using System.Web.Optimization;

namespace WebsiteBanSach
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //BundleTable.EnableOptimizations = true;

            //Style Grocery Template
            bundles.Add(new StyleBundle("~/Template/grocery/css").Include(
                      "~/Template/grocery/css/bootstrap.css",
                      "~/Template/grocery/css/style.css",
                      "~/Template/grocery/css/font-awesome.css"));
            //Javascript Grocery Template
            bundles.Add(new ScriptBundle("~/bundles/grocery").Include(
                        "~/Template/grocery/js/jquery-1.11.1.min.js",
                        "~/Template/grocery/js/move-top.js",
                        "~/Template/grocery/js/easing.js"));
            //Javascript Grocery Footer Template
            bundles.Add(new ScriptBundle("~/bundles/grocery/footer").Include(
                        "~/Template/grocery/js/bootstrap.min.js",
                        "~/Template/grocery/js/minicart.js"));
        }
    }
}
