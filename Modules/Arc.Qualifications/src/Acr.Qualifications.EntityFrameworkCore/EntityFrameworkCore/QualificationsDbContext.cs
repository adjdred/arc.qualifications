using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acr.Qualifications.EntityFrameworkCore;

[ConnectionStringName(QualificationsDbProperties.ConnectionStringName)]
public class QualificationsDbContext : AbpDbContext<QualificationsDbContext>, IQualificationsDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public QualificationsDbContext(DbContextOptions<QualificationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureQualifications();
    }
}
