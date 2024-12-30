using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCourseDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__19093A2B4E099F62", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Role__8AFACE3A672CA399", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SubCategori__19093A2B4E099F62", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCACEF9D4767", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__Users__RoleID__398D8EEE",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Duration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Sale = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Courses__C92D71876D4CFFEC", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK__Courses__Instruc__3F466844",
                        column: x => x.InstructorID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK__Courses__SubCategor__3E52440B",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "SubCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "StudentCertificates",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CertificateId = table.Column<int>(type: "int", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCertificates", x => new { x.UserId, x.CertificateId });
                    table.ForeignKey(
                        name: "FK_StudentCertificates_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "CertificateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCertificates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    SettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Theme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SystemSe__54372AFDC5ADF01D", x => x.SettingID);
                    table.ForeignKey(
                        name: "FK__SystemSet__UserI__59FA5E80",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    CheckoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TransactionID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Checkout__E07EF51CCFBA1268", x => x.CheckoutID);
                    table.ForeignKey(
                        name: "FK__Checkouts__Cours__571DF1D5",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Checkouts__Stude__5629CD9C",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enrollme__7F6877FB59BADBB3", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK__Enrollmen__Cours__4F7CD00D",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Enrollmen__Stude__4E88ABD4",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "date", nullable: false),
                    ReOpen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__74BC79AEB05343AB", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK__Reviews__CourseI__534D60F1",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Reviews__Student__52593CB8",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", unicode: false, maxLength: 50, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sections__80EF08920752F11A", x => x.SectionID);
                    table.ForeignKey(
                        name: "FK__Sections__Course__4222D4EF",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    IsInCart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentC__7B1A1BB4D2465F24", x => new { x.UserID, x.CourseID });
                    table.ForeignKey(
                        name: "FK__StudentCo__Cours__4BAC3F29",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__StudentCo__UserI__4AB81AF0",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Document__1ABEEF6F6F6C41B2", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK__Documents__Secti__47DBAE45",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID");
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    LectureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionID = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    VideoURL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", unicode: false, maxLength: 50, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lectures__B739F69F45AA0B10", x => x.LectureID);
                    table.ForeignKey(
                        name: "FK__Lectures__Sectio__44FF419A",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Business" },
                    { 3, "Design" },
                    { 4, "Marketing" },
                    { 5, "Logistics" }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "CertificateId", "CertificateUrl", "Description", "IssuedBy", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/certificate1", "Description for Certificate 1", "Issuing Authority 1", "Certificate 1" },
                    { 2, "https://example.com/certificate2", "Description for Certificate 2", "Issuing Authority 2", "Certificate 2" },
                    { 3, "https://example.com/certificate3", "Description for Certificate 3", "Issuing Authority 3", "Certificate 3" },
                    { 4, "https://example.com/certificate4", "Description for Certificate 4", "Issuing Authority 4", "Certificate 4" },
                    { 5, "https://example.com/certificate5", "Description for Certificate 5", "Issuing Authority 5", "Certificate 5" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "Name" },
                values: new object[,]
                {
                    { 1, "Student" },
                    { 2, "Instructor" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "SubCategoryId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Software Development" },
                    { 2, 1, "Data Science" },
                    { 3, 1, "Networking" },
                    { 4, 1, "Cyber Security" },
                    { 5, 1, "Cloud Computing" },
                    { 6, 2, "Entrepreneurship" },
                    { 7, 2, "Management" },
                    { 8, 2, "Finance" },
                    { 9, 2, "Human Resources" },
                    { 10, 2, "Sales" },
                    { 11, 3, "Graphic Design" },
                    { 12, 3, "Web Design" },
                    { 13, 3, "UI/UX" },
                    { 14, 3, "Animation" },
                    { 15, 3, "Interior Design" },
                    { 16, 4, "Digital Marketing" },
                    { 17, 4, "Content Marketing" },
                    { 18, 4, "Social Media Marketing" },
                    { 19, 4, "SEO" },
                    { 20, 4, "Email Marketing" },
                    { 21, 5, "Supply Chain Management" },
                    { 22, 5, "Inventory Management" },
                    { 23, 5, "Transportation Management" },
                    { 24, 5, "Warehouse Management" },
                    { 25, 5, "Procurement" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Bio", "Email", "FullName", "Password", "Phone", "RoleID" },
                values: new object[,]
                {
                    { 1, "Enthusiastic learner and avid programmer.", "alice.johnson@example.com", "Alice Johnson", "password123", "555-1234", 1 },
                    { 2, "Experienced project manager with a passion for software development.", "bob.smith@example.com", "Bob Smith", "password123", "555-5678", 2 },
                    { 3, "Creative designer with a knack for UI/UX.", "carol.davis@example.com", "Carol Davis", "password123", "555-9876", 2 },
                    { 4, "Dedicated data scientist with a background in machine learning.", "david.brown@example.com", "David Brown", "password123", "555-4321", 1 },
                    { 5, "Marketing specialist with a love for digital strategies.", "eva.wilson@example.com", "Eva Wilson", "password123", "555-8765", 3 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Description", "Duration", "InstructorID", "Level", "Price", "Rating", "Sale", "SubCategoryId", "Title", "URL" },
                values: new object[,]
                {
                    { 1, "Learn the basics of C# programming.", "5 hours", 2, "Beginner", 150000m, 4.5m, 10, 1, "Introduction to C#", "https://example.com/course1" },
                    { 2, "Deep dive into advanced C# topics.", "10 hours", 2, "Advanced", 500000m, 4.7m, 15, 1, "Advanced C# Programming", "https://example.com/course2" },
                    { 3, "Build web applications using C#.", "8 hours", 3, "Intermediate", 459000m, 4.6m, 12, 1, "C# for Web Development", "https://example.com/course3" },
                    { 4, "Learn design patterns in C#.", "7 hours", 2, "Advanced", 280000m, 4.8m, 10, 1, "C# Design Patterns", "https://example.com/course4" },
                    { 5, "Develop mobile apps using C#.", "6 hours", 3, "Intermediate", 370000m, 4.4m, 8, 1, "C# for Mobile Development", "https://example.com/course5" },
                    { 6, "Learn the basics of Data Science.", "5 hours", 2, "Beginner", 400000m, 4.5m, 10, 2, "Introduction to Data Science", "https://example.com/course6" },
                    { 7, "Deep dive into Machine Learning.", "10 hours", 3, "Advanced", 320000m, 4.7m, 15, 2, "Machine Learning with Python", "https://example.com/course7" },
                    { 8, "Analyze data using R.", "8 hours", 2, "Intermediate", 280000m, 4.6m, 12, 2, "Data Analysis with R", "https://example.com/course8" },
                    { 9, "Learn Big Data technologies.", "7 hours", 3, "Advanced", 150000m, 4.8m, 10, 2, "Big Data with Hadoop", "https://example.com/course9" },
                    { 10, "Visualize data with Tableau.", "6 hours", 2, "Intermediate", 459000m, 4.4m, 8, 2, "Data Visualization with Tableau", "https://example.com/course10" },
                    { 11, "Learn the basics of networking.", "5 hours", 2, "Beginner", 280000m, 4.5m, 10, 3, "Networking Basics", "https://example.com/course11" },
                    { 12, "Deep dive into networking.", "10 hours", 3, "Advanced", 500000m, 4.7m, 15, 3, "Advanced Networking", "https://example.com/course12" },
                    { 13, "Learn network security.", "8 hours", 2, "Intermediate", 150000m, 4.6m, 12, 3, "Network Security", "https://example.com/course13" },
                    { 14, "Learn Cisco networking.", "7 hours", 3, "Advanced", 459000m, 4.8m, 10, 3, "Cisco Networking", "https://example.com/course14" },
                    { 15, "Learn wireless networking.", "6 hours", 2, "Intermediate", 370000m, 4.4m, 8, 3, "Wireless Networking", "https://example.com/course15" },
                    { 16, "Learn the basics of cyber security.", "5 hours", 2, "Beginner", 100000m, 4.5m, 10, 4, "Introduction to Cyber Security", "https://example.com/course16" },
                    { 17, "Deep dive into cyber security.", "10 hours", 3, "Advanced", 459000m, 4.7m, 15, 4, "Advanced Cyber Security", "https://example.com/course17" },
                    { 18, "Learn penetration testing.", "8 hours", 2, "Intermediate", 280000m, 4.6m, 12, 4, "Penetration Testing", "https://example.com/course18" },
                    { 19, "Manage cyber security projects.", "7 hours", 3, "Advanced", 320000m, 4.8m, 10, 4, "Cyber Security Management", "https://example.com/course19" },
                    { 20, "Learn cyber forensics.", "6 hours", 2, "Intermediate", 150000m, 4.4m, 8, 4, "Cyber Forensics", "https://example.com/course20" },
                    { 21, "Learn the basics of cloud computing.", "5 hours", 2, "Beginner", 459000m, 4.5m, 10, 5, "Cloud Computing Basics", "https://example.com/course21" },
                    { 22, "Deep dive into cloud computing.", "10 hours", 2, "Advanced", 280000m, 4.7m, 15, 5, "Advanced Cloud Computing", "https://example.com/course22" },
                    { 23, "Learn AWS basics.", "8 hours", 2, "Intermediate", 150000m, 4.6m, 12, 5, "AWS for Beginners", "https://example.com/course23" },
                    { 24, "Learn Azure fundamentals.", "7 hours", 3, "Advanced", 500000m, 4.8m, 10, 5, "Azure Fundamentals", "https://example.com/course24" },
                    { 25, "Learn Google Cloud Platform.", "6 hours", 3, "Intermediate", 370000m, 4.4m, 8, 5, "Google Cloud Platform", "https://example.com/course25" }
                });

            migrationBuilder.InsertData(
                table: "StudentCertificates",
                columns: new[] { "CertificateId", "UserId", "CompletionDate", "CompletionTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 2, 2, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0) },
                    { 1, 3, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0) },
                    { 2, 4, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 30, 0, 0) },
                    { 1, 5, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 48, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "SystemSettings",
                columns: new[] { "SettingID", "Language", "NotificationsEnabled", "Theme", "UserID" },
                values: new object[,]
                {
                    { 1, "English", true, "Dark", 1 },
                    { 2, "French", false, "Light", 2 },
                    { 3, "Spanish", true, "Light", 3 },
                    { 4, "German", false, "Dark", 4 },
                    { 5, "Chinese", true, "Dark", 5 }
                });

            migrationBuilder.InsertData(
                table: "Checkouts",
                columns: new[] { "CheckoutID", "Amount", "CourseID", "PaymentDate", "PaymentStatus", "StudentID", "TransactionID" },
                values: new object[,]
                {
                    { 1, 50m, 1, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5798), "Paid", 1, "1ABD" },
                    { 2, 75m, 2, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5809), "Pending", 1, "16AHD" },
                    { 3, 100m, 3, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5810), "Failed", 1, "1ABDOD" },
                    { 4, 120m, 4, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5812), "Paid", 4, "1ADFHBD" },
                    { 5, 80m, 5, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5814), "Pending", 4, "1ABDD" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentID", "CourseID", "EnrollmentDate", "StudentID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5835), 1 },
                    { 2, 2, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5840), 2 },
                    { 3, 3, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5841), 3 },
                    { 4, 4, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5842), 4 },
                    { 5, 5, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(5844), 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Comment", "CourseID", "Rating", "ReOpen", "ReviewDate", "StudentID" },
                values: new object[,]
                {
                    { 1, "Good course", 1, 4.5m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6014), 1 },
                    { 2, "Very informative", 1, 4.2m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6016), 1 },
                    { 3, "Helped me a lot", 1, 4.0m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6018), 1 },
                    { 4, "Could be better", 2, 3.8m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6020), 1 },
                    { 5, "Good content", 2, 4.1m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6022), 1 },
                    { 6, "Excellent content", 3, 4.7m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6023), 4 },
                    { 7, "Very detailed", 4, 4.8m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6025), 1 },
                    { 8, "Interesting course", 5, 3.9m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6026), 4 },
                    { 9, "Enjoyed learning from it", 5, 4.3m, null, new DateTime(2024, 7, 6, 12, 17, 17, 19, DateTimeKind.Local).AddTicks(6040), 4 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionID", "CourseID", "Duration", "Position", "Title" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 1, 0, 0, 0), null, "Introduction to C# - Section 1" },
                    { 2, 1, new TimeSpan(0, 1, 30, 0, 0), null, "Introduction to C# - Section 2" },
                    { 3, 1, new TimeSpan(0, 2, 0, 0, 0), null, "Introduction to C# - Section 3" },
                    { 4, 1, new TimeSpan(0, 1, 12, 0, 0), null, "Introduction to C# - Section 4" },
                    { 5, 1, new TimeSpan(0, 1, 48, 0, 0), null, "Introduction to C# - Section 5" },
                    { 6, 2, new TimeSpan(0, 1, 0, 0, 0), null, "Advanced C# Programming - Section 1" },
                    { 7, 2, new TimeSpan(0, 1, 30, 0, 0), null, "Advanced C# Programming - Section 2" },
                    { 8, 2, new TimeSpan(0, 2, 0, 0, 0), null, "Advanced C# Programming - Section 3" },
                    { 9, 2, new TimeSpan(0, 1, 12, 0, 0), null, "Advanced C# Programming - Section 4" },
                    { 10, 2, new TimeSpan(0, 1, 48, 0, 0), null, "Advanced C# Programming - Section 5" },
                    { 11, 3, new TimeSpan(0, 1, 0, 0, 0), null, "C# for Web Development - Section 1" },
                    { 12, 3, new TimeSpan(0, 1, 30, 0, 0), null, "C# for Web Development - Section 2" },
                    { 13, 3, new TimeSpan(0, 2, 0, 0, 0), null, "C# for Web Development - Section 3" },
                    { 14, 3, new TimeSpan(0, 1, 12, 0, 0), null, "C# for Web Development - Section 4" },
                    { 15, 3, new TimeSpan(0, 1, 48, 0, 0), null, "C# for Web Development - Section 5" },
                    { 16, 4, new TimeSpan(0, 1, 0, 0, 0), null, "C# Design Patterns - Section 1" },
                    { 17, 4, new TimeSpan(0, 1, 30, 0, 0), null, "C# Design Patterns - Section 2" },
                    { 18, 4, new TimeSpan(0, 2, 0, 0, 0), null, "C# Design Patterns - Section 3" },
                    { 19, 4, new TimeSpan(0, 1, 12, 0, 0), null, "C# Design Patterns - Section 4" },
                    { 20, 4, new TimeSpan(0, 1, 48, 0, 0), null, "C# Design Patterns - Section 5" },
                    { 21, 5, new TimeSpan(0, 1, 0, 0, 0), null, "C# for Mobile Development - Section 1" },
                    { 22, 5, new TimeSpan(0, 1, 30, 0, 0), null, "C# for Mobile Development - Section 2" },
                    { 23, 5, new TimeSpan(0, 2, 0, 0, 0), null, "C# for Mobile Development - Section 3" },
                    { 24, 5, new TimeSpan(0, 1, 12, 0, 0), null, "C# for Mobile Development - Section 4" },
                    { 25, 5, new TimeSpan(0, 1, 48, 0, 0), null, "C# for Mobile Development - Section 5" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentID", "CreateDate", "SectionID", "Title", "URL" },
                values: new object[,]
                {
                    { 1, null, 1, "Introduction to C# - Document 1", "https://example.com/document1" },
                    { 2, null, 1, "Introduction to C# - Document 2", "https://example.com/document2" },
                    { 3, null, 1, "Introduction to C# - Document 3", "https://example.com/document3" },
                    { 4, null, 1, "Introduction to C# - Document 4", "https://example.com/document4" },
                    { 5, null, 1, "Introduction to C# - Document 5", "https://example.com/document5" },
                    { 6, null, 2, "Advanced C# Programming - Document 1", "https://example.com/document6" },
                    { 7, null, 2, "Advanced C# Programming - Document 2", "https://example.com/document7" },
                    { 8, null, 2, "Advanced C# Programming - Document 3", "https://example.com/document8" },
                    { 9, null, 2, "Advanced C# Programming - Document 4", "https://example.com/document9" },
                    { 10, null, 2, "Advanced C# Programming - Document 5", "https://example.com/document10" },
                    { 11, null, 3, "C# for Web Development - Document 1", "https://example.com/document11" },
                    { 12, null, 3, "C# for Web Development - Document 2", "https://example.com/document12" },
                    { 13, null, 3, "C# for Web Development - Document 3", "https://example.com/document13" },
                    { 14, null, 3, "C# for Web Development - Document 4", "https://example.com/document14" },
                    { 15, null, 3, "C# for Web Development - Document 5", "https://example.com/document15" },
                    { 16, null, 4, "C# Design Patterns - Document 1", "https://example.com/document16" },
                    { 17, null, 4, "C# Design Patterns - Document 2", "https://example.com/document17" },
                    { 18, null, 4, "C# Design Patterns - Document 3", "https://example.com/document18" },
                    { 19, null, 4, "C# Design Patterns - Document 4", "https://example.com/document19" },
                    { 20, null, 4, "C# Design Patterns - Document 5", "https://example.com/document20" },
                    { 21, null, 5, "C# for Mobile Development - Document 1", "https://example.com/document21" },
                    { 22, null, 5, "C# for Mobile Development - Document 2", "https://example.com/document22" },
                    { 23, null, 5, "C# for Mobile Development - Document 3", "https://example.com/document23" },
                    { 24, null, 5, "C# for Mobile Development - Document 4", "https://example.com/document24" },
                    { 25, null, 5, "C# for Mobile Development - Document 5", "https://example.com/document25" }
                });

            migrationBuilder.InsertData(
                table: "Lectures",
                columns: new[] { "LectureID", "Content", "Duration", "Position", "SectionID", "Title", "VideoURL" },
                values: new object[,]
                {
                    { 1, "Introduction to C# content", new TimeSpan(0, 0, 30, 0, 0), null, 1, "Introduction to C#", "https://example.com/video1" },
                    { 2, "Basic syntax content", new TimeSpan(0, 0, 45, 0, 0), null, 1, "Basic Syntax", "https://example.com/video2" },
                    { 3, "Data types and variables content", new TimeSpan(0, 0, 40, 0, 0), null, 1, "Data Types and Variables", "https://example.com/video3" },
                    { 4, "Control flow statements content", new TimeSpan(0, 0, 50, 0, 0), null, 1, "Control Flow Statements", "https://example.com/video4" },
                    { 5, "Methods and functions content", new TimeSpan(0, 0, 55, 0, 0), null, 1, "Methods and Functions", "https://example.com/video5" },
                    { 6, "Advanced topics in C# content", new TimeSpan(0, 1, 0, 0, 0), null, 2, "Advanced Topics in C#", "https://example.com/video6" },
                    { 7, "LINQ and lambda expressions content", new TimeSpan(0, 0, 50, 0, 0), null, 2, "LINQ and Lambda Expressions", "https://example.com/video7" },
                    { 8, "Multithreading in C# content", new TimeSpan(0, 0, 55, 0, 0), null, 2, "Multithreading in C#", "https://example.com/video8" },
                    { 9, "Asynchronous programming content", new TimeSpan(0, 1, 5, 0, 0), null, 2, "Asynchronous Programming", "https://example.com/video9" },
                    { 10, "Advanced design patterns content", new TimeSpan(0, 1, 10, 0, 0), null, 2, "Advanced Design Patterns", "https://example.com/video10" },
                    { 11, "Introduction to ASP.NET Core content", new TimeSpan(0, 0, 45, 0, 0), null, 3, "Introduction to ASP.NET Core", "https://example.com/video11" },
                    { 12, "Building RESTful APIs content", new TimeSpan(0, 1, 0, 0, 0), null, 3, "Building RESTful APIs", "https://example.com/video12" },
                    { 13, "Entity Framework Core content", new TimeSpan(0, 0, 55, 0, 0), null, 3, "Entity Framework Core", "https://example.com/video13" },
                    { 14, "Authentication and authorization content", new TimeSpan(0, 0, 50, 0, 0), null, 3, "Authentication and Authorization", "https://example.com/video14" },
                    { 15, "Deploying ASP.NET Core applications content", new TimeSpan(0, 1, 5, 0, 0), null, 3, "Deploying ASP.NET Core Applications", "https://example.com/video15" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CourseID",
                table: "Checkouts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_StudentID",
                table: "Checkouts",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorID",
                table: "Courses",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubCategoryId",
                table: "Courses",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SectionID",
                table: "Documents",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseID",
                table: "Enrollments",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SectionID",
                table: "Lectures",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CourseID",
                table: "Reviews",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StudentID",
                table: "Reviews",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseID",
                table: "Sections",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCertificates_CertificateId",
                table: "StudentCertificates",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_UserID",
                table: "SystemSettings",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StudentCertificates");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
