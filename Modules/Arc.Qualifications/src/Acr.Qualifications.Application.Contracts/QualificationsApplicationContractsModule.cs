using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Acr.Qualifications;

[DependsOn(
    typeof(QualificationsDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class QualificationsApplicationContractsModule : AbpModule
{

}
