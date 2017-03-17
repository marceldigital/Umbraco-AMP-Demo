using System.Web.Optimization;

namespace MarcelDigital.OutingBlog.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/inline-bundle/css")
                .Include("~/Content/foundation.grid.css",
                         "~/Content/branding.css",
                         "~/Content/amp.css"));
        }
    }
}