using Localization.Resources.AbpUi;
using Acr.Qualifications.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Acr.Qualifications;

[DependsOn(
    typeof(QualificationsApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class QualificationsHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(QualificationsHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<QualificationsResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
