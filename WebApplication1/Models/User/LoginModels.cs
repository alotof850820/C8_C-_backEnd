using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.UserModels
{
    /// <summary>
    /// 登入求參
    /// </summary>
    public record class LoginRequest
    {
        /// <summary>
        /// 信箱
        /// </summary>
        public required string UserEmail { get; init; }
        /// <summary>
        /// 密碼
        /// </summary>
        public required string UserPassword { get; init; }
    }

    /// <summary>
    /// 登入回應
    /// </summary>
    public record class LoginResponse
    {
        /// <summary>
        /// 信箱
        /// </summary>
        public string? UserEmail { get; init; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string? UserPassword { get; init; }
    }

    public record class UserAppModels
    {
        public long Id { get; init; }
        public string? UserName { get; init; }
        public string? Email { get; init; }
        public string? PasswordDigest { get; init; }
        public string? NickName { get; init; }
        public string? Status { get; init; }
        public string? Avatar { get; init; }
        public string? Money { get; init; }
        public DateTime? CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
