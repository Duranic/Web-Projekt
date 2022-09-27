using System.Web;
using System.Web.Mvc;

namespace Spam_Detection_Chat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
