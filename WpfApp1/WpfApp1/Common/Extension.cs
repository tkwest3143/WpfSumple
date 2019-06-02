using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Common
{
    /// <summary>
    /// <see cref="PageEnum"/>クラスに設定されている属性とURIを取得するクラス。
    /// </summary>
    public static class pageExtension
    {
        private static Dictionary<PageEnum, UriAttribute> uriCache;

        static pageExtension()
        {
            //Pageのenumクラスから属性と値を取得する。
            var type = typeof(PageEnum);
            var lookup = type.GetFields()
                .Where(fi => fi.FieldType == type)
                .SelectMany(fi => fi.GetCustomAttributes(false),
                (fi, Attribute) => new { Page = (PageEnum)fi.GetValue(null), Attribute })
                .ToLookup(a => a.Attribute.GetType());

            uriCache = lookup[typeof(UriAttribute)].ToDictionary(a => a.Page, a => (UriAttribute)a.Attribute);
        }
        public static string ToStringUri(this PageEnum page)
        {
            return uriCache[page].Value;
        }

        /// <summary>
        /// Pageクラスに格納されているUriの相対パスを<see cref="System.Uri"/>クラスのインスタンスを作成し、
        /// 相対パスと設定して返却する。
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Uri ToRelativeUri(this PageEnum page)
        {
            return new Uri(uriCache[page].Value,UriKind.Relative);
        }
    }
}
