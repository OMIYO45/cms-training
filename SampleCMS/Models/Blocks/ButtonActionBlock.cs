using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Blocks
{
    [ContentType(
        DisplayName = "Button Action Block",
        GUID = "0d1c9743-4d48-470f-8afb-7e62d84f6092",
        Description ="A button",
        AvailableInEditMode =true)]
    public class ButtonActionBlock : BlockData
    {
        [Display(
            Name ="Action Text",
            Description ="Text to display",
            GroupName = SystemTabNames.Content,
            Order =10)]
        public virtual string? ActionText { get; set; }

        [Display(
           Name = "Action Text",
           Description = "Text to display",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual Url? ActionUrl { get; set; }

    }
}
