using SampleCMS.Models.Pages;
using SampleCMS.Models.Pages.ViewModels;

namespace SampleCMS.Business.Interfaces
{
    public interface IContactUsPageBuilder
    {
        public ContactUsPageViewModel Build(ContactUsPage contactUsPageViewModel);
    }
}
