using XYS.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XYS.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}