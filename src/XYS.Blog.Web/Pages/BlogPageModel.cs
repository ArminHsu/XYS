using XYS.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace XYS.Blog.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BlogPageModel : AbpPageModel
    {
        protected BlogPageModel()
        {
            LocalizationResourceType = typeof(BlogResource);
        }
    }
}