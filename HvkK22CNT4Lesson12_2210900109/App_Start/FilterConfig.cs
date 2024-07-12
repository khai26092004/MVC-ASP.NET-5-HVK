using System.Web;
using System.Web.Mvc;

namespace HvkK22CNT4Lesson12_2210900109
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
