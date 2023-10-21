using EPiServer.Data.Dynamic;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using SampleCMS.Business.Interfaces;
using SampleCMS.Business.Models;
using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;
using System;

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
            
            var store1 = (DynamicDataStore)DynamicDataStoreFactory.Instance.GetStore("SubmitContactUs");
            List<SubmitContactUs> cmtList = store1.Items<SubmitContactUs>().ToList();
            TempData["cmtList"] = cmtList;

            return PageView(model);
        }

        [HttpPost]
        public IActionResult SubmitContactUs([FromForm] SubmitContactUs form)
        {

            var data = new SubmitContactUs
            {
                FullName = form.FullName,
                Email = form.Email,
                Comment = form.Comment,
                Id = Guid.NewGuid()
            };

            var propertyBag = new PropertyBag();

            propertyBag.Add("FullName", form.FullName);
            propertyBag.Add("Email", form.Email);
            propertyBag.Add("Comment", form.Comment);
            propertyBag.Add("Id", Guid.NewGuid());


            var store = DynamicDataStoreFactory.Instance.CreateStore("SubmitContactUs", propertyBag.GenerateTypeBag());

            if (store.Save(propertyBag) != null)
            {
                TempData["Success"] = "Successful";
                
            }
            else
            {
                TempData["Success"] = "Unsuccessful";
            }
            return Redirect("~/contact-us-page");
        }
    }
}
