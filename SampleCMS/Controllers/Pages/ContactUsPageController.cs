using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using SampleCMS.Business.Interfaces;
using SampleCMS.Business.Models;
using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;

namespace SampleCMS.Controllers.Pages
{
    public class ContactUsPageController : BaseController<ContactUsPage>
    {
        private readonly IContactUsPageBuilder _contactUsPage;
        public ContactUsPageController(IContactUsPageBuilder contactUs) {
            _contactUsPage = contactUs;
        }
        public IActionResult Index(ContactUsPage contactUsPage, string returnUrl =" ")
        {
            var model = _contactUsPage.Build(contactUsPage);
            model.ReturnUrl = returnUrl;
            return PageView(model);
        }

        [HttpPost]
        public IActionResult SubmitContactUs([FromForm] SubmitContactUs form)
        {

            var data = new SubmitContactUs
            {
                FullName = form.FullName,
                Email = form.Email,
                Comment = form.Comment
            };
            TempData["Success"] = "Successful";
            return Redirect("contact-us-page");
        }
    }
}
