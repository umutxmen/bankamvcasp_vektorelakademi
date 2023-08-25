using Banka.Business;
using Banka.WebApi;

using Banka.WebApi.Middlewares;
using Banka.WebApi.Middlewares;

namespace Banka.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddApiService(builder.Configuration);
            builder.Services.AddBusinessServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Aþaðýdaki 2 middleware [Authorize] attributeunun çalýþabilmesi için mutlaka eklenmelidir
            //----------------------------------------------------
            app.UseAuthentication();
            app.UseAuthorization();
            //----------------------------------------------------
            app.MapControllers();

            app.UseCustomException();

            app.Run();
        }
    }
}
