using Microsoft.AspNetCore.Mvc;
using WebApplication1.Instance.User;

namespace WebApplication1.Routes
{
    public static class UserRouter
    {
        public static T InitUserRouter<T>(this T r) where T : IEndpointRouteBuilder
        {
            //r.MapPost("/login", ApiUser.UserLogin);
            r.MapGet("/getUser", UserAppInstance.GetAppUsers);
            //r.MapGet("/getUser", async () => await userAppInstance.GetAppUsers());
            //r.MapPost("/{id}", ([FromRoute] long id) => { });
            return r;
        }
    }
}
