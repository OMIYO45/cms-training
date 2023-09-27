using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SampleCMS.Models.Pages;

namespace SampleCMS.Controllers.Pages
{
    public class HomePageController : BaseController<HomePage>
    {
        public IActionResult Index(HomePage currentContent)
        {
            return PageView(currentContent);
        }
    }
}
