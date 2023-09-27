using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;

namespace SampleCMS.Controllers.Pages
{
    public class BaseController<T> : PageController<T> where T : AbstractContentPage
    {
        public IActionResult PageView( T model)
        {
            var viewModel = new PageViewModel<T>(model);
            viewModel.PageTitle ??= String.IsNullOrEmpty(model.PageTitle) ? model.Name : model.PageTitle; 
            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", viewModel);
        }
    }
}
