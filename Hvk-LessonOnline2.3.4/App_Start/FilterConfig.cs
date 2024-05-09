using System.Web;
using System.Web.Mvc;

namespace Hvk_LessonOnline2._3._4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
