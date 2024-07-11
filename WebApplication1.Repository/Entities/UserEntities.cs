

namespace WebApplication1.Repository.Entities
{
    /// <summary>
    /// 用戶實體
    /// </summary>
    public class UserEntities
    {
        /// <summary>
        /// 用戶ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public required DateTime CreatedAt { get; set; }
    }
}
