using Volo.Abp.Modularity;

namespace Acr.Qualifications;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class QualificationsApplicationTestBase<TStartupModule> : QualificationsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
