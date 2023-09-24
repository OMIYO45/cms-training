using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace SampleCMS.Models.Media
{
    [ContentType(
            DisplayName = "Image",
            GUID = "7ccbdd00-36a5-4ad5-b8d7-ee662f463d9b")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile :ImageData
    {
        [Display(Name ="Alternate Text")]
        public virtual string? AltText { get; set; }
    }
}
