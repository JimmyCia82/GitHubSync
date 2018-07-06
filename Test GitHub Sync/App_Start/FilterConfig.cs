using System.Web;
using System.Web.Mvc;

namespace Test_GitHub_Sync
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
