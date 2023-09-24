using SampleCMS.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Pages
{
    [ContentType(
        DisplayName ="General Page",
        Description ="General Content",
        GUID ="48724c3e-2538-43e8-8a38-a72b6bfa109c",
        GroupName = "General Content")]
    public class GeneralPage : AbstractContentPage
    {     
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Headline { get; set; }
        
        [Display(
            Name = "Headline Slug",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? HeadlineSlug { get; set; }
        
        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Bottom Content Area",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [AllowedTypes(AllowedTypes = new[] { typeof(SectionMediaBlock), typeof(LinkGridBlock) })]
        public virtual ContentArea? BottomContentArea { get; set; }
    }
}
