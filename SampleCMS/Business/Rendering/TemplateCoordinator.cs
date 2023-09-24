using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using SampleCMS.Models.Blocks;
using SampleCMS.Models.Pages;

namespace SampleCMS.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {        
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(SectionMediaBlock), new EPiServer.DataAbstraction.TemplateModel {
                Name = "SectionMediaBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/SectionMediaBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(LinkGridBlock), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "LinkGridBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/LinkGridBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "AbstractContentPage-LinkGrid",
                AvailableWithoutTag = false,
                Tags = new[] { "LinkGrid" },
                Inherit= true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }
    }
}
