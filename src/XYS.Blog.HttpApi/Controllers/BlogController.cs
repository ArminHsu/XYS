using XYS.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XYS.Blog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlogController : AbpController
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}