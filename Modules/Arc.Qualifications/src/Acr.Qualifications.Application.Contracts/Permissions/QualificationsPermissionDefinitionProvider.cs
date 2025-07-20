using Acr.Qualifications.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acr.Qualifications.Permissions;

public class QualificationsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QualificationsPermissions.GroupName, L("Permission:Qualifications"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QualificationsResource>(name);
    }
}
