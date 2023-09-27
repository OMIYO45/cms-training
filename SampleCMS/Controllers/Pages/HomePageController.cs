using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;

namespace SampleCMS.Controllers.Pages
{
    public class HomePageController : BaseController<HomePage>
    {
        private readonly IContentLoader contentLoader;
        public HomePageController(IContentLoader contentLoader)
        {
            this.contentLoader = contentLoader; ;
        }
        public IActionResult Index(HomePage currentContent)
        {
            var viewModel = new HomePageViewModel(currentContent);
            viewModel.RelatedContent = contentLoader.GetChildren<AbstractContentPage>(currentContent.ContentLink);
            
            return PageView(viewModel);
        }
    }
}
