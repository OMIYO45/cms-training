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
            RegisterBlock<SectionMediaBlock>(viewTemplateModelRegistrator);
            RegisterBlock<LinkGridBlock>(viewTemplateModelRegistrator);
            RegisterBlock<BannerBlock>(viewTemplateModelRegistrator);
            RegisterBlock<ButtonActionBlock>(viewTemplateModelRegistrator);
            RegisterPartial<AbstractContentPage>(viewTemplateModelRegistrator, "ArticlePartial");
            RegisterPartial<AbstractContentPage>(viewTemplateModelRegistrator, "LinkGrid");
            

            //Previous used
            //viewTemplateModelRegistrator.Add(typeof(SectionMediaBlock), new EPiServer.DataAbstraction.TemplateModel {
            //    Name = "SectionMediaBlock-Default",
            //    AvailableWithoutTag = true,
            //    TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
            //    Path = "~/Views/SectionMediaBlock/Index.cshtml"
            //});

            //viewTemplateModelRegistrator.Add(typeof(LinkGridBlock), new EPiServer.DataAbstraction.TemplateModel
            //{
            //    Name = "LinkGridBlock-Default",
            //    AvailableWithoutTag = true,
            //    TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
            //    Path = "~/Views/LinkGridBlock/Index.cshtml"
            //});

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

        private void RegisterPartial<T>(TemplateModelCollection viewTemplateModelRegistrator, string tageName) where T : AbstractContentPage
        {
            viewTemplateModelRegistrator.Add(typeof(T), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = $"{typeof(T).Name}-{tageName}",
                AvailableWithoutTag = false,
                Tags = new[] { tageName},
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/{(typeof(T).Name)}/{tageName}.cshtml"
            });
        }

        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = $"{typeof(T).Name}-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }        
    }
}
