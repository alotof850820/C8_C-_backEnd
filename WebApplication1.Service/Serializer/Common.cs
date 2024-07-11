namespace Service.Serializer
{
    public class Response<T>
    {
        public int Status { get; init; }
        public T? Data { get; init; }
        public string? Msg { get; init; }
        public string? Error { get; init; }
    }
}
