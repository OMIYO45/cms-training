using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace SampleCMS.Business.Models
{
    public class SubmitContactUs : IDynamicData
    {

        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public Identity? Id { get; set; }
    }
}
