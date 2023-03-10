using System.Web;
using System.Web.Mvc;

namespace th_web_PhanLeBaTai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
