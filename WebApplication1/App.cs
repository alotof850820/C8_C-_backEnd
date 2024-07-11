using Microsoft.EntityFrameworkCore;
using Service.Instance.User;
using Service.Interface.User;
using WebApplication1.Instance.User;
using WebApplication1.Repository;
using WebApplication1.Repository.Instance.User;
using WebApplication1.Repository.Interface.User;
using WebApplication1.Routes;

namespace WebApplication1
{
    public class App
    {
        public static void Main(string[] args)
        {
            // 
            var builder = WebApplication.CreateBuilder(args);

            // 允许你在应用程序中使用授权功能。
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //  Swagger 生成
            builder.Services.AddSwaggerGen(
                options =>
                {
                    // import swagger xml
                    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{WebApplication1.AssemblyInfo.Assembly.GetName().Name}.xml"));
                }
                );
            // import 其他專案文件夾的interface和實例
            builder.Services.AddScoped<IUserServiceInterface, UserService>();
            builder.Services.AddScoped<IUserRepositoryInterface, UserRepository>();
            builder.Services.AddDbContext<AppContextDataBase>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"), x => x.MigrationsAssembly(WebApplication1.Repository.Migrations.AssemblyInfo.Assembly.GetName().Name!)));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            // 强制所有 HTTP 请求重定向到 HTTPS。
            app.UseHttpsRedirection();
            // 确保在请求到达控制器或端点之前进行授权检查。
            app.UseAuthorization();
            app.InitRouter();
            app.Run();
        }
    }
}
