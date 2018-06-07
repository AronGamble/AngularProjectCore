using Microsoft.AspNetCore.Antiforgery;
using AngularCoreProject.Controllers;

namespace AngularCoreProject.Web.Host.Controllers
{
    public class AntiForgeryController : AngularCoreProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
