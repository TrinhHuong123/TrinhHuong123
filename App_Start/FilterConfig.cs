using System.Web;
using System.Web.Mvc;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
