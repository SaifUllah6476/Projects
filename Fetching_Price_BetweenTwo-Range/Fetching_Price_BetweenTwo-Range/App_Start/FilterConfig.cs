using System.Web;
using System.Web.Mvc;

namespace Fetching_Price_BetweenTwo_Range
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
