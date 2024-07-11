using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository.Configurations;
using WebApplication1.Repository.Entities;

namespace WebApplication1.Repository
{
    //  EF Core 数据库上下文
    public class AppContextDataBase : DbContext
    {
        public AppContextDataBase(DbContextOptions<AppContextDataBase> options) : base(options) { }
        // 重写了 DbContext 类的 OnModelCreating 方法 配置实体框架模型的细节。
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         // 配置表格和序列
         TableConfiguration.Configure(modelBuilder);
         SequenceConfiguration.Configure(modelBuilder);
        }
        // 定义数据库中的 UserEntities 表。允许用 LINQ 查询和操作 UserEntities 表中的数据。
        public DbSet<UserEntities> Users { get; set; }
    }
}
