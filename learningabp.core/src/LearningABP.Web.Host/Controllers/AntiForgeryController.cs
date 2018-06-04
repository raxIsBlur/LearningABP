using Microsoft.AspNetCore.Antiforgery;
using LearningABP.Controllers;

namespace LearningABP.Web.Host.Controllers
{
    public class AntiForgeryController : LearningABPControllerBase
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
