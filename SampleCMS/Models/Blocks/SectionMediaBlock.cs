using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Blocks
{
    [ContentType(
        DisplayName ="Section Media Block",
        GUID = "7bcbdd00-36a5-4ad5-b8d7-ee662f463d9a")]
    public class SectionMediaBlock : BlockData
    {
        [Display(
            Name ="Headline",
            GroupName = SystemTabNames.Content,
            Order =10)]
        public virtual string? Headline { get; set; }

        [Display(
           Name = "Body",
            GroupName = SystemTabNames.Content,
           Order = 20)]
        public virtual XhtmlString? Body { get; set; }

        [Display(
           Name = "Image",
            GroupName = SystemTabNames.Content,
           Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
