using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Domain.Contracts;

namespace EduCore.BackEnd.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddScoped<IPaymentGatewayService, VnPayGatewayService>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddDbContext<CoursesDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("Database")));






    }
}
