using EPiServer.Core;
using EPiServer.DataAnnotations;
namespace SampleCMS.Models.Pages
{
    [ContentType(
        DisplayName ="Home Page",
        Description ="Home Content",
        GUID = "7ccbdd00-36a5-4ad5-b8d7-ee662f463d9a"
        )]
    public class HomePage : AbstractContentPage
    {

    }
}
