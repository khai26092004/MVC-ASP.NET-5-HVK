using System.Web;
using System.Web.Mvc;

namespace Hvk_BaiThiGiuaKi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
