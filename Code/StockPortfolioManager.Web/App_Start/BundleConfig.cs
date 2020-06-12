﻿using System.Web.Optimization;

namespace StockPortfolioManager.Web
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

      bundles.Add(new ScriptBundle("~/bundles/jqueryAjax").Include(
                  "~/Scripts/jquery.unobtrusive-ajax.js"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                  "~/Scripts/materialize.js",
                  "~/Scripts/QS_Default.js"));

      bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
                  "~/Scripts/inputmask/jquery.inputmask.min.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Content/materialize.css",
                  "~/Content/font-awesome.css",
                  "~/Content/QS_Default.css"));
    }
  }
}