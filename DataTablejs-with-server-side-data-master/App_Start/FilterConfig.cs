using System.Web;
using System.Web.Mvc;

namespace DataTablejs_with_server_side_data_master
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
