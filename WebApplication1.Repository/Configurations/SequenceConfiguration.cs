using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Repository.Configurations
{
    public static class SequenceConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder) {
            // 配置 UsersId 序列
            modelBuilder.ConfigureSequence(DatabaseObjects.Sequences.UsersId);
        }
    }
}
