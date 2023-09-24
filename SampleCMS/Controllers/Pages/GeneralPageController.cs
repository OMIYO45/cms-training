using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Cmp;
using SampleCMS.Models.Pages;

namespace SampleCMS.Controllers.Pages
{
    public class GeneralPageController : PageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentContent)
        {
            return View(currentContent);
        }
    }
}
