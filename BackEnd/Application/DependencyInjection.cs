using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Application.Abstractions.Services;
using EduCore.BackEnd.Application.Services;

namespace EduCore.BackEnd.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddScoped<IPaymentGatewayService, VnPayGatewayService>();

        services.AddAutoMapper(typeof(CourseProfile).Assembly);
        services.AddScoped<ISubCategoryService, SubCategoryService>();
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ISectionService, SectionService>();
        services.AddScoped<IReviewService, ReviewService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IInstructorService, InstructorService>();
        services.AddScoped<ICertificateService, CertificateService>();
        services.AddScoped<ILectureService, LectureService>();
        services.AddScoped<ICommentService, CommentService>();
        services.AddScoped<ICheckoutService, CheckoutService>();
        services.AddScoped<IEnrollmentService, EnrollmentService>();
        services.AddScoped<IStudentService, StudentService>();


        return services;

    }
}
