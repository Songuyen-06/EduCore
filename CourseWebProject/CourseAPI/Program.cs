using CourseDomain;
using CourseDomain.Contracts;
using CourseDomain.DTOs;
using CourseInfrastructure;
using CourseServices;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<ReviewDTO>("Review");
modelBuilder.EntitySet<CourseDetailDTO>("Course");
modelBuilder.EntitySet<SectionDTO>("Section");
modelBuilder.EntitySet<CategoryDTO>("Category");
modelBuilder.EntitySet<InstructorDTO>("Instructor");
modelBuilder.EntitySet<CertificateDTO>("Certificate");


modelBuilder.EntitySet<UserDTO>("User");
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddOData(opt => opt.Select().Filter().SetMaxTop(100).Expand().OrderBy().Count().AddRouteComponents("odata", modelBuilder.GetEdmModel()));

builder.Services.AddDbContext<CoursesDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyDatabase")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISectionService, SectionService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<ICertificateService, CertificateService>();




builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
