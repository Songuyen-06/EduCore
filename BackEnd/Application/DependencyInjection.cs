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

        // Register scoped services
       services.AddScoped<ICourseService, CourseService>();
       services.AddScoped<ISectionService, SectionService>();
       services.AddScoped<ISubCategoryService, SubCategoryService>();
       services.AddScoped<ICategoryService, CategoryService>();
       services.AddScoped<IReviewService, ReviewService>();
       services.AddScoped<IInstructorService, InstructorService>();
       services.AddScoped<ICertificateService, CertificateService>();
       services.AddScoped<IStudentService, StudentService>();
       services.AddScoped<IUserService, UserService>();
       services.AddScoped<ILectureService, LectureService>();
       services.AddScoped<ICommentService, CommentService>();
        //builder.Services.AddScoped<IAIService, AIService>();
       services.AddScoped<IEnrollmentService, EnrollmentService>();
       services.AddScoped<ICheckoutService, CheckoutService>();
       //services.AddScoped<IEmailService, EmailService>();
       //services.AddScoped<IVnPayService, VnPayService>();
       //services.AddScoped<ICompletionStatusService, CompletionStatusServicec>();


        return services;

    }
}
