using System.Threading.Tasks;

namespace NetRevision.Data;

public interface INetRevisionDbSchemaMigrator
{
    Task MigrateAsync();
}
