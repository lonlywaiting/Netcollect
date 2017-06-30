using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace Netcollect
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //基础样式
            bundles.Add(new StyleBundle("~/Content/BaseCSS").Include(
                "~/Content/Plugin/Metronic/global/plugins/font-awesome/css/font-awesome.min.css",
                "~/Content/Plugin/Metronic/global/plugins/simple-line-icons/simple-line-icons.min.css",
                "~/Content/Plugin/Metronic/global/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/Plugin/Metronic/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                "~/Content/Plugin/Metronic/global/css/components.min.css",
                "~/Content/Plugin/Metronic/global/css/plugins.min.css",
                "~/Content/Plugin/Metronic/layouts/layout3/css/layout.min.css",
                "~/Content/Plugin/Metronic/layouts/layout3/css/themes/default.min.css",
                "~/Content/Plugin/Metronic/layouts/layout3/css/custom.min.css"));

            //基础JS
            bundles.Add(new ScriptBundle("~/Content/BaseJS").Include(
                "~/Content/Plugin/Metronic/global/plugins/jquery.min.js",
                "~/Content/Plugin/Metronic/global/plugins/bootstrap/js/bootstrap.min.js",
                "~/Content/Plugin/Metronic/global/plugins/js.cookie.min.js",
                "~/Content/Plugin/Metronic/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Content/Plugin/Metronic/global/plugins/jquery.blockui.min.js",
                "~/Content/Plugin/Metronic/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                "~/Content/Plugin/Metronic/global/scripts/app.min.js",
                "~/Content/Plugin/Metronic/layouts/layout3/scripts/layout.min.js",
                "~/Content/Plugin/Metronic/layouts/layout3/scripts/demo.min.js",
                "~/Content/Plugin/Metronic/layouts/global/scripts/quick-sidebar.min.js",
                "~/Content/Plugin/Metronic/global/scripts/quick-nav.min.js"));

            //IE9 使用
            bundles.Add(new ScriptBundle("~/Content/IE9JS").Include(
                "~/Content/Plugin/Metronic/global/plugins/respond.min.js",
                "~/Content/Plugin/Metronic/global/plugins/excanvas.min.js",
                "~/Content/Plugin/Metronic/global/plugins/ie8.fix.min.js"));
        }
    }
}