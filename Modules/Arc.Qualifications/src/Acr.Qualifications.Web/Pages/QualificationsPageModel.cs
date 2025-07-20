using Acr.Qualifications.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acr.Qualifications.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QualificationsPageModel : AbpPageModel
{
    protected QualificationsPageModel()
    {
        LocalizationResourceType = typeof(QualificationsResource);
        ObjectMapperContext = typeof(QualificationsWebModule);
    }
}
