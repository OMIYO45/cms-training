namespace SampleCMS.Models.Pages.ViewModels
{
    public class ContactUsPageViewModel : PageViewModel<ContactUsPage>
    {
        public ContactUsPageViewModel(ContactUsPage page) : base(page)
        {

        }

        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public string? ReturnUrl { get; set; }
        public string? CancelUrl { get; set; }

    }
}
