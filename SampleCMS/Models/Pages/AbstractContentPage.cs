using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Pages
{
    public abstract class AbstractContentPage : PageData
    {
        [Display(
            Name = "Page Title",
            GroupName = "SEO",
            Order = 10)]
        public virtual string? PageTitle { get; set; }

        [Display(
            Name = "Meta Description",
            GroupName = "SEO",
            Order = 20)]
        public virtual string? MetaDescription { get; set; }
    }
}
