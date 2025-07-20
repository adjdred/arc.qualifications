using Acr.Qualifications.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acr.Qualifications;

public abstract class QualificationsController : AbpControllerBase
{
    protected QualificationsController()
    {
        LocalizationResource = typeof(QualificationsResource);
    }
}
