namespace Acr.Qualifications;

public static class QualificationsDbProperties
{
    public static string DbTablePrefix { get; set; } = "Qualifications";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Qualifications";
}
