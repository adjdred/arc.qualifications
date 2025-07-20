using Acr.Qualifications.Localization;
using Volo.Abp.Application.Services;

namespace Acr.Qualifications;

public abstract class QualificationsAppService : ApplicationService
{
    protected QualificationsAppService()
    {
        LocalizationResource = typeof(QualificationsResource);
        ObjectMapperContext = typeof(QualificationsApplicationModule);
    }
}
