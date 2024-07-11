namespace Service.Models.User
{
    public record class UserModels
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
