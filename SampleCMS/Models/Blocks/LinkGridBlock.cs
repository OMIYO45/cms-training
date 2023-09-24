using SampleCMS.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Blocks
{
    [ContentType(
        DisplayName = "Link Grid Block",
        GUID = "7bcbdd00-36a5-4ad8-b8d7-ee662f463d9a")]

    public class LinkGridBlock : BlockData
    {
        [Display(
            Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(AbstractContentPage) })]
        public virtual ContentArea? Links { get; set; }
    }
}
