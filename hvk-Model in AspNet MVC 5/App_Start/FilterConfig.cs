using System.Web;
using System.Web.Mvc;

namespace hvk_Model_in_AspNet_MVC_5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
