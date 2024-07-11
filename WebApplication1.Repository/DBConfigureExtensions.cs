using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static WebApplication1.Repository.DatabaseObjects;

namespace WebApplication1.Repository
{
    public static class DBConfigureExtensions
    {
        // 扩展方法：配置表名
        public static EntityTypeBuilder ConfigTable(this EntityTypeBuilder builder,Table table )
            => builder.ToTable(table.Name);
        // 扩展方法：配置 HiLo 序列
        public static PropertyBuilder ConfigureHiLe(this PropertyBuilder builder,Sequence sequence )
            => builder.UseHiLo(sequence.Name);
        // 扩展方法：配置序列
        public static void ConfigureSequence(this ModelBuilder builder, Sequence sequence)
            => builder.HasSequence(sequence.Name).IncrementsBy(sequence.Increment);
    }
}
