using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SampleCMS.Models.Pages;

namespace SampleCMS.Controllers.Pages
{
    public class BaseController<T> : PageController<T> where T : PageData
    {
        public IActionResult PageView( T model)
        {
            return View($"~/Views/Pages/{typeof(T).Name}.cshtml",model);
        }
    }
}
