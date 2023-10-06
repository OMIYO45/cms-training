using EPiServer.Core;
using EPiServer.DataAnnotations;
using SampleCMS.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Pages
{
    [ContentType(
        DisplayName ="Home Page",
        Description ="Home Content",
        GUID = "7ccbdd00-36a5-4ad5-b8d7-ee662f463d9a"
        )]
    public class HomePage : AbstractContentPage
    {
        [Display(
          Name = "Bottom Content Area",
          GroupName = SystemTabNames.Content,
          Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(ButtonActionBlock) })]
        public virtual ContentArea? BottomContentArea { get; set; }
    }
}
