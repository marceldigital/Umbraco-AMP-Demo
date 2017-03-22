using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace UWestFest.Demo.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString InlineStyles(this HtmlHelper htmlHelper, string bundleVirtualPath) {
            var bundleContent = LoadBundleContent(htmlHelper.ViewContext.HttpContext, bundleVirtualPath);
            var styleTag = $"<style>{bundleContent}</style>";

            return new HtmlString(styleTag);
        }

        public static IHtmlString RawBundleContent(this HtmlHelper htmlHelper, string bundleVirtualPath) {
            var bundleContent = LoadBundleContent(htmlHelper.ViewContext.HttpContext, bundleVirtualPath);

            return new HtmlString(bundleContent);
        }

        private static string LoadBundleContent(HttpContextBase httpContext, string bundleVirtualPath) {
            var bundleContext = new BundleContext(httpContext, BundleTable.Bundles, bundleVirtualPath);
            var bundle = BundleTable.Bundles.Single(b => b.Path == bundleVirtualPath);
            var bundleResponse = bundle.GenerateBundleResponse(bundleContext);

            return bundleResponse.Content;
        }
    }
}