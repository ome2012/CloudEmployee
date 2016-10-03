using System.Web;
using System.Web.Mvc;

namespace CloudEmployee_Rommel_Reserva
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
