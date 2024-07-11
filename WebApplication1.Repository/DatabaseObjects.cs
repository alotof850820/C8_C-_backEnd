namespace WebApplication1.Repository
{
    public static class DatabaseObjects
    {
        // 定义一个记录类型 Table，用于表示数据库表
        public record Table(string Name);
        // 定义一个记录类型 Sequence，用于表示数据库序列
        public record Sequence(string Name,int Increment = 10);
        // 静态类，用于存储表信息
        public static class Tables
        {
            // 定义 User 表的静态实例
            public static Table User = new(nameof(User));
        }

        // 静态类，用于存储序列信息
        public static class Sequences
        {
            // 定义 UsersId 序列的静态实例
            public static Sequence UsersId = new(nameof(UsersId));
        }
    }
}
