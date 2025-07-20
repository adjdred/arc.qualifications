using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Acr.Qualifications;

[DependsOn(
    typeof(QualificationsApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class QualificationsHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(QualificationsApplicationContractsModule).Assembly,
            QualificationsRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<QualificationsHttpApiClientModule>();
        });

    }
}
