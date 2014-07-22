using System.Linq;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web;

namespace DependentBundles.Core
{
    public static class BundleExtensions
    {
        private static string BundleKeyPrefix = "registered_script_bundle_";
        /// <summary>
        /// Register the dependency on a bundle.
        /// Note: We have to return an empty string to be able to use this in views
        /// </summary>
        /// <param name="html"></param>
        /// <param name="bundleUrl"></param>
        /// <returns></returns>
        public static IHtmlString RegisterBundleDependency(this HtmlHelper html, string bundleUrl)
        {
            var registeredBundles = BundleTable.Bundles.GetRegisteredBundles();

            if (registeredBundles.All(x => x.Path != bundleUrl)) return MvcHtmlString.Empty;

            var bundleKey = string.Format("{0}{1}", BundleKeyPrefix, bundleUrl);

            if (html.ViewContext.HttpContext.Items[bundleKey] != null) return MvcHtmlString.Empty;

            html.ViewContext.HttpContext.Items[bundleKey] = bundleUrl;

            return MvcHtmlString.Empty;
        }

        public static IHtmlString RenderDependentScripts(this HtmlHelper html)
        {
            var bundles = html.ViewContext.HttpContext.Items.Keys.OfType<string>().Cast<string>().Where(x=>x.StartsWith(BundleKeyPrefix)).ToList();

            if (!bundles.Any()) return MvcHtmlString.Empty;

            var scripts = string.Empty;
            foreach (var bundle in bundles)
            {
                scripts += Scripts.Render(html.ViewContext.HttpContext.Items[bundle] as string);
            }

            return new MvcHtmlString(scripts);   
        }
    }
}
