using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Acr.Qualifications;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(QualificationsDomainSharedModule)
)]
public class QualificationsDomainModule : AbpModule
{

}
