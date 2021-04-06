using System.Threading.Tasks;

namespace XYS.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
