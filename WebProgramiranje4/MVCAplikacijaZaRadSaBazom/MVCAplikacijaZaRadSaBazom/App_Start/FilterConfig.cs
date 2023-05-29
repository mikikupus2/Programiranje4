using System.Web;
using System.Web.Mvc;

namespace MVCAplikacijaZaRadSaBazom
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
