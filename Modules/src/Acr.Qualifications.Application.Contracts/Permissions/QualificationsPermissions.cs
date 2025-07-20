using Volo.Abp.Reflection;

namespace Acr.Qualifications.Permissions;

public class QualificationsPermissions
{
    public const string GroupName = "Qualifications";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(QualificationsPermissions));
    }
}
