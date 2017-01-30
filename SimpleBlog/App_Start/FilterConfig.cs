using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.App_Start
{
    public class FilterConfig
    {
         public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new TransactionFilter());
        }
    }
}
