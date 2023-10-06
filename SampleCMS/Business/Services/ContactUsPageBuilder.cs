using SampleCMS.Business.Interfaces;
using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;

namespace SampleCMS.Business.Services
{
    public class ContactUsPageBuilder : IContactUsPageBuilder
    {
        public ContactUsPageBuilder() { }

        public ContactUsPageViewModel Build(ContactUsPage contactUsPage)
        {
            return new ContactUsPageViewModel(contactUsPage);
        }
    }
}
