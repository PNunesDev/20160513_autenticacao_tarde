using System.Web;
using System.Web.Mvc;

namespace _20160513_autorizacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
