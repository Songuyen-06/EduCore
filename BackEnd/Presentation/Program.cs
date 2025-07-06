using EduCore.BackEnd.Application.DTOs;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using EduCore.BackEnd.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//odata
ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<ReviewDTO>("Review");
modelBuilder.EntitySet<CourseDTO>("Course");
modelBuilder.EntitySet<SectionDTO>("Section");
modelBuilder.EntitySet<CategoryDTO>("Category");
modelBuilder.EntitySet<InstructorDTO>("Instructor");
modelBuilder.EntitySet<CertificateDTO>("Certificate");
modelBuilder.EntitySet<CheckoutDTO>("Checkout");
modelBuilder.EntitySet<EnrollmentDetailDTO>("Enrollment");
modelBuilder.EntitySet<StudentDTO>("Student");
modelBuilder.EntitySet<UserDTO>("User");
builder.Services.AddControllers().AddOData(opt => opt.Select().Filter().SetMaxTop(100).Expand().OrderBy().Count().AddRouteComponents("odata", modelBuilder.GetEdmModel()));


//cors
var config = builder.Services.BuildServiceProvider().GetService<IConfiguration>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins(config.GetValue<string>("Frontend_url") ?? "http://localhost:3000") // fallback URL
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
//ref services
builder.Services.AddApplicationServices().AddInfrastructureServices(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();


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
