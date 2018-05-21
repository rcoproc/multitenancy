
namespace MultiTenancy.Admninistration.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.TenantsRow))]
    public class TenantsController : Controller
    {
        [Route("Admninistration/Tenants")]
        public ActionResult Index()
        {
            return View("~/Modules/Admninistration/Tenants/TenantsIndex.cshtml");
        }
    }
}