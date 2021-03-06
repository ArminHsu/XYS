using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using XYS.Blog.Localization;
using XYS.Blog.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace XYS.Blog.Web.Menus
{
    public class BlogMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<BlogResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(BlogMenus.Home, l["Menu:Home"], "~/"));
        }
    }
}
