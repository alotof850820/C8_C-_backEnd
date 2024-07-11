using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository.Entities;

namespace WebApplication1.Repository.Configurations
{
    public static class TableConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            // 配置实体框架模型中的 UserEntities 表
            #region 交易紀錄
            modelBuilder.Entity<UserEntities>(builder =>
            {
                // 配置表名
                builder.ConfigTable(DatabaseObjects.Tables.User);
                // 配置主键
                builder.HasKey(t => t.Id);
                // 配置 Id 列，使用 HiLo 序列
                builder.Property(x => x.Id).ConfigureHiLe(DatabaseObjects.Sequences.UsersId);
                // 配置 Name 列，最大长度为 20，且为必填
                builder.Property(x=>x.Name).HasMaxLength(20).IsRequired();
                // 配置 CreatTime 列，必填
                builder.Property(x=>x.CreatedAt).IsRequired();
            });
            #endregion
        }
    }
}
