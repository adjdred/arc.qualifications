using Volo.Abp.Modularity;

namespace Acr.Qualifications;

[DependsOn(
    typeof(QualificationsApplicationModule),
    typeof(QualificationsDomainTestModule)
    )]
public class QualificationsApplicationTestModule : AbpModule
{

}
