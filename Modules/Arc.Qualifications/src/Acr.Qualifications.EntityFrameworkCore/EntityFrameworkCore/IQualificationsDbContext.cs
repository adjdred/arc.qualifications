using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acr.Qualifications.EntityFrameworkCore;

[ConnectionStringName(QualificationsDbProperties.ConnectionStringName)]
public interface IQualificationsDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
