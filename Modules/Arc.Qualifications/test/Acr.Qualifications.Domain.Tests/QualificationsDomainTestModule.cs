using Volo.Abp.Modularity;

namespace Acr.Qualifications;

[DependsOn(
    typeof(QualificationsDomainModule),
    typeof(QualificationsTestBaseModule)
)]
public class QualificationsDomainTestModule : AbpModule
{

}
