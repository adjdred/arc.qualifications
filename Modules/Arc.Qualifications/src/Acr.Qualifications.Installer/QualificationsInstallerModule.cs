using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Acr.Qualifications;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class QualificationsInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<QualificationsInstallerModule>();
        });
    }
}
