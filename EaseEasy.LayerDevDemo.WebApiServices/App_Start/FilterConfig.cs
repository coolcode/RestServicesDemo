using System.Web;
using System.Web.Mvc;

namespace EaseEasy.LayerDevDemo.WebApiServices {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}