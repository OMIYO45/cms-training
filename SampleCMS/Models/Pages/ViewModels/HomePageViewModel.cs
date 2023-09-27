namespace SampleCMS.Models.Pages.ViewModels
{
    public class HomePageViewModel : PageViewModel<HomePage>
    {
        public HomePageViewModel(HomePage page) : base(page)
        {
            
        }

        public IEnumerable<AbstractContentPage> RelatedContent { get; internal set; } = Enumerable.Empty<AbstractContentPage>();
    }
}
