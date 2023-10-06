using SampleCMS.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Pages
{
    [ContentType(
       DisplayName = "Contact Us Page",
       Description = "Contact Us Page Content",
       GUID = "7ccbdd00-36a5-1ad6-b8d7-ee662f463d9a"
       )]
    public class ContactUsPage : AbstractContentPage
    {
        [Display(
          Name = "Bottom Content Area",
          GroupName = SystemTabNames.Content,
          Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(BannerBlock) })]
        public virtual ContentArea? BottomContentArea { get; set; }

    }
}
