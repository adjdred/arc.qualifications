using Volo.Abp.Modularity;

namespace Acr.Qualifications;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class QualificationsDomainTestBase<TStartupModule> : QualificationsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
