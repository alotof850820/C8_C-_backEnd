namespace WebApplication1.Routes
{
    public static class Init
    {
        public static void InitRouter(this IEndpointRouteBuilder r)
        {
            // WithTags (swagger)
            r.MapGroup("/user").InitUserRouter().WithTags("User");
        }
    }
}
