using System.Web.Optimization;

namespace MarcelDigital.OutingBlog.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/inline-bundle/css")
                .Include("~/css/layout-core.css",
                         "~/css/layout-nav.css",
                         "~/css/layout-listings.css",
                         "~/css/layout-page.css"));
        }
    }
}