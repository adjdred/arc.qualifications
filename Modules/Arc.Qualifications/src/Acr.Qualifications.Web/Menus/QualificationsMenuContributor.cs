using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Acr.Qualifications.Web.Menus;

public class QualificationsMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(QualificationsMenus.Prefix, displayName: "Qualifications", "~/Qualifications", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
