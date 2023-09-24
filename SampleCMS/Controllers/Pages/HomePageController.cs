using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SampleCMS.Models.Pages;

namespace SampleCMS.Controllers.Pages
{
    public class HomePageController : PageController<HomePage>
    {
        public IActionResult Index(HomePage currentContent)
        {
            return View(currentContent);
        }
    }
}
