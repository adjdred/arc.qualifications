using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acr.Qualifications.EntityFrameworkCore;

[DependsOn(
    typeof(QualificationsDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class QualificationsEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<QualificationsDbContext>(options =>
        {
            options.AddDefaultRepositories<IQualificationsDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
