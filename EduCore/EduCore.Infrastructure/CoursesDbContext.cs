using System;
using System.Collections.Generic;
using EduCore.Domain;
using EduCore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace EduCore.Infrastructure;

public partial class CoursesDbContext : DbContext
{
    public CoursesDbContext()
    {
    }

    public CoursesDbContext(DbContextOptions<CoursesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Checkout> Checkouts { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Lecture> Lectures { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Certificate> Certificates { get; set; }
    public virtual DbSet<StudentCertificate> StudentCertificates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("server=.;database=CoursesDB;uid=sa;pwd=123;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
        new Category { CategoryId = 1, Name = "IT" },
        new Category { CategoryId = 2, Name = "Business" },
        new Category { CategoryId = 3, Name = "Design" },
        new Category { CategoryId = 4, Name = "Marketing" },
        new Category { CategoryId = 5, Name = "Logistics" }
    );

        // Seed data for SubCategory
        modelBuilder.Entity<SubCategory>().HasData(
            // IT SubCategories
            new SubCategory { SubCategoryId = 1, Name = "Software Development", CategoryId = 1 },
            new SubCategory { SubCategoryId = 2, Name = "Data Science", CategoryId = 1 },
            new SubCategory { SubCategoryId = 3, Name = "Networking", CategoryId = 1 },
            new SubCategory { SubCategoryId = 4, Name = "Cyber Security", CategoryId = 1 },
            new SubCategory { SubCategoryId = 5, Name = "Cloud Computing", CategoryId = 1 },

            // Business SubCategories
            new SubCategory { SubCategoryId = 6, Name = "Entrepreneurship", CategoryId = 2 },
            new SubCategory { SubCategoryId = 7, Name = "Management", CategoryId = 2 },
            new SubCategory { SubCategoryId = 8, Name = "Finance", CategoryId = 2 },
            new SubCategory { SubCategoryId = 9, Name = "Human Resources", CategoryId = 2 },
            new SubCategory { SubCategoryId = 10, Name = "Sales", CategoryId = 2 },

            // Design SubCategories
            new SubCategory { SubCategoryId = 11, Name = "Graphic Design", CategoryId = 3 },
            new SubCategory { SubCategoryId = 12, Name = "Web Design", CategoryId = 3 },
            new SubCategory { SubCategoryId = 13, Name = "UI/UX", CategoryId = 3 },
            new SubCategory { SubCategoryId = 14, Name = "Animation", CategoryId = 3 },
            new SubCategory { SubCategoryId = 15, Name = "Interior Design", CategoryId = 3 },

            // Marketing SubCategories
            new SubCategory { SubCategoryId = 16, Name = "Digital Marketing", CategoryId = 4 },
            new SubCategory { SubCategoryId = 17, Name = "Content Marketing", CategoryId = 4 },
            new SubCategory { SubCategoryId = 18, Name = "Social Media Marketing", CategoryId = 4 },
            new SubCategory { SubCategoryId = 19, Name = "SEO", CategoryId = 4 },
            new SubCategory { SubCategoryId = 20, Name = "Email Marketing", CategoryId = 4 },

            // Logistics SubCategories
            new SubCategory { SubCategoryId = 21, Name = "Supply Chain Management", CategoryId = 5 },
            new SubCategory { SubCategoryId = 22, Name = "Inventory Management", CategoryId = 5 },
            new SubCategory { SubCategoryId = 23, Name = "Transportation Management", CategoryId = 5 },
            new SubCategory { SubCategoryId = 24, Name = "Warehouse Management", CategoryId = 5 },
            new SubCategory { SubCategoryId = 25, Name = "Procurement", CategoryId = 5 }
        );

        // Insert 5 hàng vào bảng Role
        modelBuilder.Entity<Role>().HasData(
            new Role { RoleId = 1, Name = "Student" },
            new Role { RoleId = 2, Name = "Instructor" },
            new Role { RoleId = 3, Name = "Admin" }

        );

        // Insert 5 hàng vào bảng User
        modelBuilder.Entity<User>().HasData(
             new User { UserId = 1, FullName = "Alice Johnson", Email = "alice.johnson@example.com", RoleId = 1, Password = "password123", Phone = "555-1234", Bio = "Enthusiastic learner and avid programmer." },
             new User { UserId = 2, FullName = "Bob Smith", Email = "bob.smith@example.com", RoleId = 2, Password = "password123", Phone = "555-5678", Bio = "Experienced project manager with a passion for software development." },
             new User { UserId = 3, FullName = "Carol Davis", Email = "carol.davis@example.com", RoleId = 2, Password = "password123", Phone = "555-9876", Bio = "Creative designer with a knack for UI/UX." },
             new User { UserId = 4, FullName = "David Brown", Email = "david.brown@example.com", RoleId = 1, Password = "password123", Phone = "555-4321", Bio = "Dedicated data scientist with a background in machine learning." },
             new User { UserId = 5, FullName = "Eva Wilson", Email = "eva.wilson@example.com", RoleId = 3, Password = "password123", Phone = "555-8765", Bio = "Marketing specialist with a love for digital strategies." }
         );


        modelBuilder.Entity<Course>().HasData(
     // Software Development Courses
     new Course { CourseId = 1, Title = "Introduction to C#", SubCategoryId = 1, InstructorId = 2, Price = 150000, Level = "Beginner", Description = "Learn the basics of C# programming.", Duration = "5 hours", Rating = 4.5m, Url = "https://example.com/course1", Sale = 10 },
     new Course { CourseId = 2, Title = "Advanced C# Programming", SubCategoryId = 1, InstructorId = 2, Price = 500000, Level = "Advanced", Description = "Deep dive into advanced C# topics.", Duration = "10 hours", Rating = 4.7m, Url = "https://example.com/course2", Sale = 15 },
     new Course { CourseId = 3, Title = "C# for Web Development", SubCategoryId = 1, InstructorId = 3, Price = 459000, Level = "Intermediate", Description = "Build web applications using C#.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course3", Sale = 12 },
     new Course { CourseId = 4, Title = "C# Design Patterns", SubCategoryId = 1, InstructorId = 2, Price = 280000, Level = "Advanced", Description = "Learn design patterns in C#.", Duration = "7 hours", Rating = 4.8m, Url = "https://example.com/course4", Sale = 10 },
     new Course { CourseId = 5, Title = "C# for Mobile Development", SubCategoryId = 1, InstructorId = 3, Price = 370000, Level = "Intermediate", Description = "Develop mobile apps using C#.", Duration = "6 hours", Rating = 4.4m, Url = "https://example.com/course5", Sale = 8 },

     // Data Science Courses
     new Course { CourseId = 6, Title = "Introduction to Data Science", SubCategoryId = 2, InstructorId = 2, Price = 400000, Level = "Beginner", Description = "Learn the basics of Data Science.", Duration = "5 hours", Rating = 4.5m, Url = "https://example.com/course6", Sale = 10 },
     new Course { CourseId = 7, Title = "Machine Learning with Python", SubCategoryId = 2, InstructorId = 3, Price = 320000, Level = "Advanced", Description = "Deep dive into Machine Learning.", Duration = "10 hours", Rating = 4.7m, Url = "https://example.com/course7", Sale = 15 },
     new Course { CourseId = 8, Title = "Data Analysis with R", SubCategoryId = 2, InstructorId = 2, Price = 280000, Level = "Intermediate", Description = "Analyze data using R.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course8", Sale = 12 },
     new Course { CourseId = 9, Title = "Big Data with Hadoop", SubCategoryId = 2, InstructorId = 3, Price = 150000, Level = "Advanced", Description = "Learn Big Data technologies.", Duration = "7 hours", Rating = 4.8m, Url = "https://example.com/course9", Sale = 10 },
     new Course { CourseId = 10, Title = "Data Visualization with Tableau", SubCategoryId = 2, InstructorId = 2, Price = 459000, Level = "Intermediate", Description = "Visualize data with Tableau.", Duration = "6 hours", Rating = 4.4m, Url = "https://example.com/course10", Sale = 8 },

     // Networking Courses
     new Course { CourseId = 11, Title = "Networking Basics", SubCategoryId = 3, InstructorId = 2, Price = 280000, Level = "Beginner", Description = "Learn the basics of networking.", Duration = "5 hours", Rating = 4.5m, Url = "https://example.com/course11", Sale = 10 },
     new Course { CourseId = 12, Title = "Advanced Networking", SubCategoryId = 3, InstructorId = 3, Price = 500000, Level = "Advanced", Description = "Deep dive into networking.", Duration = "10 hours", Rating = 4.7m, Url = "https://example.com/course12", Sale = 15 },
     new Course { CourseId = 13, Title = "Network Security", SubCategoryId = 3, InstructorId = 2, Price = 150000, Level = "Intermediate", Description = "Learn network security.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course13", Sale = 12 },
     new Course { CourseId = 14, Title = "Cisco Networking", SubCategoryId = 3, InstructorId = 3, Price = 459000, Level = "Advanced", Description = "Learn Cisco networking.", Duration = "7 hours", Rating = 4.8m, Url = "https://example.com/course14", Sale = 10 },
     new Course { CourseId = 15, Title = "Wireless Networking", SubCategoryId = 3, InstructorId = 2, Price = 370000, Level = "Intermediate", Description = "Learn wireless networking.", Duration = "6 hours", Rating = 4.4m, Url = "https://example.com/course15", Sale = 8 },

     // Cyber Security Courses
     new Course { CourseId = 16, Title = "Introduction to Cyber Security", SubCategoryId = 4, InstructorId = 2, Price = 100000, Level = "Beginner", Description = "Learn the basics of cyber security.", Duration = "5 hours", Rating = 4.5m, Url = "https://example.com/course16", Sale = 10 },
     new Course { CourseId = 17, Title = "Advanced Cyber Security", SubCategoryId = 4, InstructorId = 3, Price = 459000, Level = "Advanced", Description = "Deep dive into cyber security.", Duration = "10 hours", Rating = 4.7m, Url = "https://example.com/course17", Sale = 15 },
     new Course { CourseId = 18, Title = "Penetration Testing", SubCategoryId = 4, InstructorId = 2, Price = 280000, Level = "Intermediate", Description = "Learn penetration testing.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course18", Sale = 12 },
     new Course { CourseId = 19, Title = "Cyber Security Management", SubCategoryId = 4, InstructorId = 3, Price = 320000, Level = "Advanced", Description = "Manage cyber security projects.", Duration = "7 hours", Rating = 4.8m, Url = "https://example.com/course19", Sale = 10 },
     new Course { CourseId = 20, Title = "Cyber Forensics", SubCategoryId = 4, InstructorId = 2, Price = 150000, Level = "Intermediate", Description = "Learn cyber forensics.", Duration = "6 hours", Rating = 4.4m, Url = "https://example.com/course20", Sale = 8 },

     // Cloud Computing Courses
     new Course { CourseId = 21, Title = "Cloud Computing Basics", SubCategoryId = 5, InstructorId = 2, Price = 459000, Level = "Beginner", Description = "Learn the basics of cloud computing.", Duration = "5 hours", Rating = 4.5m, Url = "https://example.com/course21", Sale = 10 },
     new Course { CourseId = 22, Title = "Advanced Cloud Computing", SubCategoryId = 5, InstructorId = 2, Price = 280000, Level = "Advanced", Description = "Deep dive into cloud computing.", Duration = "10 hours", Rating = 4.7m, Url = "https://example.com/course22", Sale = 15 },
     new Course { CourseId = 23, Title = "AWS for Beginners", SubCategoryId = 5, InstructorId = 2, Price = 150000, Level = "Intermediate", Description = "Learn AWS basics.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course23", Sale = 12 },
     new Course { CourseId = 24, Title = "Azure Fundamentals", SubCategoryId = 5, InstructorId = 3, Price = 500000, Level = "Advanced", Description = "Learn Azure fundamentals.", Duration = "7 hours", Rating = 4.8m, Url = "https://example.com/course24", Sale = 10 },
     new Course { CourseId = 25, Title = "Google Cloud Platform", SubCategoryId = 5, InstructorId = 3, Price = 370000, Level = "Intermediate", Description = "Learn Google Cloud Platform.", Duration = "6 hours", Rating = 4.4m, Url = "https://example.com/course25", Sale = 8 },

// Entrepreneurship SubCategory (SubCategoryId = 6)
new Course { CourseId = 30, Title = "Entrepreneurship Basics", SubCategoryId = 6, InstructorId = 2, Price = 150000, Level = "Beginner", Description = "Learn the basics of entrepreneurship.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course1", Sale = 15 },
new Course { CourseId = 31, Title = "Startup Fundamentals", SubCategoryId = 6, InstructorId = 3, Price = 150000, Level = "Intermediate", Description = "Master the fundamentals of starting a business.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course2", Sale = 20 },
new Course { CourseId = 32, Title = "Scaling Your Startup", SubCategoryId = 6, InstructorId = 2, Price = 320000, Level = "Advanced", Description = "Strategies for scaling your startup.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course3", Sale = 25 },

// Management SubCategory (SubCategoryId = 7)
new Course { CourseId = 33, Title = "Management Essentials", SubCategoryId = 7, InstructorId = 3, Price = 150000, Level = "Intermediate", Description = "Essential management techniques.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course4", Sale = 10 },
new Course { CourseId = 34, Title = "Leadership Skills", SubCategoryId = 7, InstructorId = 2, Price = 320000, Level = "Advanced", Description = "Develop essential leadership skills.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course5", Sale = 20 },
new Course { CourseId = 35, Title = "Team Building Strategies", SubCategoryId = 7, InstructorId = 3, Price = 320000, Level = "Beginner", Description = "Master the art of team building.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course6", Sale = 15 },

// Finance SubCategory (SubCategoryId = 8)
new Course { CourseId = 36, Title = "Finance for Beginners", SubCategoryId = 8, InstructorId = 2, Price = 150000, Level = "Beginner", Description = "A beginner's guide to finance.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course7", Sale = 10 },
new Course { CourseId = 37, Title = "Financial Analysis", SubCategoryId = 8, InstructorId = 3, Price = 320000, Level = "Intermediate", Description = "Learn how to analyze financial statements.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course8", Sale = 20 },
new Course { CourseId = 38, Title = "Advanced Investment Strategies", SubCategoryId = 8, InstructorId = 2, Price = 320000, Level = "Advanced", Description = "Advanced strategies for investing in the stock market.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course9", Sale = 30 },

// Human Resources SubCategory (SubCategoryId = 9)
new Course { CourseId = 39, Title = "Introduction to HR Management", SubCategoryId = 9, InstructorId = 2, Price = 180000, Level = "Beginner", Description = "An introduction to human resource management.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course10", Sale = 15 },
new Course { CourseId = 40, Title = "Employee Relations", SubCategoryId = 9, InstructorId = 3, Price = 200000, Level = "Intermediate", Description = "Effective strategies for managing employee relations.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course11", Sale = 20 },
new Course { CourseId = 41, Title = "Talent Acquisition", SubCategoryId = 9, InstructorId = 2, Price = 350000, Level = "Advanced", Description = "Strategies for effective talent acquisition.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course12", Sale = 25 },

// Sales SubCategory (SubCategoryId = 10)
new Course { CourseId = 42, Title = "Sales Techniques", SubCategoryId = 10, InstructorId = 3, Price = 160000, Level = "Intermediate", Description = "Effective sales techniques.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course13", Sale = 10 },
new Course { CourseId = 43, Title = "Negotiation Skills", SubCategoryId = 10, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Mastering negotiation skills.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course14", Sale = 20 },
new Course { CourseId = 44, Title = "Closing Strategies", SubCategoryId = 10, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Strategies for effective closing of sales.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course15", Sale = 15 },

// Graphic Design SubCategory (SubCategoryId = 11)
new Course { CourseId = 45, Title = "Introduction to Graphic Design", SubCategoryId = 11, InstructorId = 2, Price = 170000, Level = "Beginner", Description = "An introduction to graphic design principles.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course16", Sale = 10 },
new Course { CourseId = 46, Title = "Typography Fundamentals", SubCategoryId = 11, InstructorId = 3, Price = 300000, Level = "Intermediate", Description = "Mastering typography in design.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course17", Sale = 20 },
new Course { CourseId = 47, Title = "Logo Design Mastery", SubCategoryId = 11, InstructorId = 2, Price = 300000, Level = "Advanced", Description = "Mastering the art of logo design.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course18", Sale = 30 },

// Web Design SubCategory (SubCategoryId = 12)
new Course { CourseId = 48, Title = "Responsive Web Design", SubCategoryId = 12, InstructorId = 3, Price = 180000, Level = "Intermediate", Description = "Designing responsive websites.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course19", Sale = 15 },
new Course { CourseId = 49, Title = "User Interface Design", SubCategoryId = 12, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Creating effective user interfaces.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course20", Sale = 25 },
new Course { CourseId = 50, Title = "Web Accessibility", SubCategoryId = 12, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Ensuring web accessibility standards.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course21", Sale = 20 },

// UI/UX SubCategory (SubCategoryId = 13)
new Course { CourseId = 51, Title = "UI Design Fundamentals", SubCategoryId = 13, InstructorId = 2, Price = 190000, Level = "Beginner", Description = "Fundamentals of UI design.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course22", Sale = 15 },
new Course { CourseId = 52, Title = "User Experience Design", SubCategoryId = 13, InstructorId = 3, Price = 200000, Level = "Intermediate", Description = "Creating great user experiences.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course23", Sale = 20 },
new Course { CourseId = 53, Title = "Interaction Design", SubCategoryId = 13, InstructorId = 2, Price = 350000, Level = "Advanced", Description = "Designing interactive experiences.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course24", Sale = 25 },

// Animation SubCategory (SubCategoryId = 14)
new Course { CourseId = 54, Title = "2D Animation Basics", SubCategoryId = 14, InstructorId = 3, Price = 160000, Level = "Intermediate", Description = "Basics of 2D animation.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course25", Sale = 10 },
new Course { CourseId = 55, Title = "Character Animation", SubCategoryId = 14, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Creating character animations.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course26", Sale = 20 },
new Course { CourseId = 56, Title = "Motion Graphics", SubCategoryId = 14, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Creating engaging motion graphics.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course27", Sale = 15 },

// Interior Design SubCategory (SubCategoryId = 15)
new Course { CourseId = 57, Title = "Interior Design Basics", SubCategoryId = 15, InstructorId = 2, Price = 170000, Level = "Beginner", Description = "Basic principles of interior design.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course28", Sale = 10 },
new Course { CourseId = 58, Title = "Color Theory in Design", SubCategoryId = 15, InstructorId = 3, Price = 300000, Level = "Intermediate", Description = "Understanding color theory in design.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course29", Sale = 20 },
new Course { CourseId = 59, Title = "Space Planning", SubCategoryId = 15, InstructorId = 2, Price = 300000, Level = "Advanced", Description = "Effective space planning strategies.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course30", Sale = 30 },

// Digital Marketing SubCategory (SubCategoryId = 16)
new Course { CourseId = 60, Title = "Digital Marketing Fundamentals", SubCategoryId = 16, InstructorId = 2, Price = 180000, Level = "Beginner", Description = "Fundamentals of digital marketing.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course31", Sale = 15 },
new Course { CourseId = 61, Title = "Social Media Strategies", SubCategoryId = 16, InstructorId = 3, Price = 200000, Level = "Intermediate", Description = "Effective social media marketing strategies.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course32", Sale = 20 },
new Course { CourseId = 62, Title = "SEO Fundamentals", SubCategoryId = 16, InstructorId = 2, Price = 350000, Level = "Advanced", Description = "Fundamentals of search engine optimization.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course33", Sale = 25 },

// Content Marketing SubCategory (SubCategoryId = 17)
new Course { CourseId = 63, Title = "Content Marketing Strategy", SubCategoryId = 17, InstructorId = 3, Price = 160000, Level = "Intermediate", Description = "Developing a content marketing strategy.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course34", Sale = 10 },
new Course { CourseId = 64, Title = "Blogging for Beginners", SubCategoryId = 17, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Starting a successful blog.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course35", Sale = 20 },
new Course { CourseId = 65, Title = "Video Marketing", SubCategoryId = 17, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Using video for marketing purposes.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course36", Sale = 15 },

// Social Media Marketing SubCategory (SubCategoryId = 18)
new Course { CourseId = 66, Title = "Social Media Advertising", SubCategoryId = 18, InstructorId = 2, Price = 170000, Level = "Beginner", Description = "Advertising on social media platforms.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course37", Sale = 10 },
new Course { CourseId = 67, Title = "Influencer Marketing", SubCategoryId = 18, InstructorId = 3, Price = 300000, Level = "Intermediate", Description = "Strategies for influencer marketing.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course38", Sale = 20 },
new Course { CourseId = 68, Title = "Community Management", SubCategoryId = 18, InstructorId = 2, Price = 300000, Level = "Advanced", Description = "Managing communities on social media.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course39", Sale = 30 },

// SEO SubCategory (SubCategoryId = 19)
new Course { CourseId = 69, Title = "On-Page SEO", SubCategoryId = 19, InstructorId = 3, Price = 180000, Level = "Intermediate", Description = "Optimizing on-page factors for SEO.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course40", Sale = 15 },
new Course { CourseId = 70, Title = "Link Building Strategies", SubCategoryId = 19, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Effective strategies for link building.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course41", Sale = 20 },
new Course { CourseId = 71, Title = "Local SEO", SubCategoryId = 19, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Optimizing for local search results.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course42", Sale = 10 },

// Email Marketing SubCategory (SubCategoryId = 20)
new Course { CourseId = 72, Title = "Email Marketing Essentials", SubCategoryId = 20, InstructorId = 2, Price = 190000, Level = "Beginner", Description = "Essential practices in email marketing.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course43", Sale = 15 },
new Course { CourseId = 73, Title = "Email Copywriting", SubCategoryId = 20, InstructorId = 3, Price = 200000, Level = "Intermediate", Description = "Writing effective email copy.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course44", Sale = 20 },
new Course { CourseId = 74, Title = "Automated Email Campaigns", SubCategoryId = 20, InstructorId = 2, Price = 350000, Level = "Advanced", Description = "Setting up automated email campaigns.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course45", Sale = 25 },

// Supply Chain Management SubCategory (SubCategoryId = 21)
new Course { CourseId = 75, Title = "Introduction to Supply Chain", SubCategoryId = 21, InstructorId = 2, Price = 170000, Level = "Beginner", Description = "An introduction to supply chain management.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course46", Sale = 10 },
new Course { CourseId = 76, Title = "Logistics Management", SubCategoryId = 21, InstructorId = 3, Price = 300000, Level = "Intermediate", Description = "Managing logistics in supply chain.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course47", Sale = 20 },
new Course { CourseId = 77, Title = "Inventory Optimization", SubCategoryId = 21, InstructorId = 2, Price = 300000, Level = "Advanced", Description = "Optimizing inventory management.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course48", Sale = 30 },

// Inventory Management SubCategory (SubCategoryId = 22)
new Course { CourseId = 78, Title = "Inventory Control", SubCategoryId = 22, InstructorId = 3, Price = 180000, Level = "Intermediate", Description = "Controlling inventory levels.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course49", Sale = 15 },
new Course { CourseId = 79, Title = "Warehouse Operations", SubCategoryId = 22, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Managing warehouse operations.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course50", Sale = 25 },
new Course { CourseId = 80, Title = "Supply Chain Analytics", SubCategoryId = 22, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Analyzing supply chain data.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course51", Sale = 20 },

// Transportation Management SubCategory (SubCategoryId = 23)
new Course { CourseId = 81, Title = "Transportation Basics", SubCategoryId = 23, InstructorId = 2, Price = 190000, Level = "Beginner", Description = "Basics of transportation management.", Duration = "10 hours", Rating = 4.5m, Url = "https://example.com/course52", Sale = 15 },
new Course { CourseId = 82, Title = "Freight Management", SubCategoryId = 23, InstructorId = 3, Price = 200000, Level = "Intermediate", Description = "Managing freight logistics.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course53", Sale = 20 },
new Course { CourseId = 83, Title = "Global Logistics", SubCategoryId = 23, InstructorId = 2, Price = 350000, Level = "Advanced", Description = "Strategies for global logistics.", Duration = "15 hours", Rating = 4.9m, Url = "https://example.com/course54", Sale = 25 },

// Warehouse Management SubCategory (SubCategoryId = 24)
new Course { CourseId = 84, Title = "Warehouse Design", SubCategoryId = 24, InstructorId = 3, Price = 160000, Level = "Intermediate", Description = "Designing efficient warehouses.", Duration = "12 hours", Rating = 4.6m, Url = "https://example.com/course55", Sale = 10 },
new Course { CourseId = 85, Title = "Inventory Tracking", SubCategoryId = 24, InstructorId = 2, Price = 330000, Level = "Advanced", Description = "Tracking inventory effectively.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course56", Sale = 20 },
new Course { CourseId = 86, Title = "Warehouse Safety", SubCategoryId = 24, InstructorId = 3, Price = 330000, Level = "Beginner", Description = "Ensuring safety in warehouse operations.", Duration = "8 hours", Rating = 4.6m, Url = "https://example.com/course57", Sale = 15 },

// Procurement SubCategory (SubCategoryId = 25)
new Course { CourseId = 87, Title = "Procurement Fundamentals", SubCategoryId = 25, InstructorId = 2, Price = 170000, Level = "Beginner", Description = "Fundamentals of procurement.", Duration = "12 hours", Rating = 4.7m, Url = "https://example.com/course58", Sale = 10 },
new Course { CourseId = 88, Title = "Supplier Relationship Management", SubCategoryId = 25, InstructorId = 3, Price = 300000, Level = "Intermediate", Description = "Managing supplier relationships.", Duration = "18 hours", Rating = 4.8m, Url = "https://example.com/course59", Sale = 20 },
new Course { CourseId = 89, Title = "Negotiation Skills in Procurement", SubCategoryId = 25, InstructorId = 2, Price = 300000, Level = "Advanced", Description = "Developing negotiation skills for procurement.", Duration = "25 hours", Rating = 4.9m, Url = "https://example.com/course60", Sale = 30 }

     // Courses for SubCategory with SubCategoryId = 6 (Entrepreneurship)


     );



        modelBuilder.Entity<Checkout>().HasData(
       new Checkout { CheckoutId = 1, CourseId = 1, StudentId = 1, Amount = 50, PaymentStatus = "Paid", PaymentDate = DateTime.Now, TransactionId = "1ABD" },
       new Checkout { CheckoutId = 2, CourseId = 2, StudentId = 1, Amount = 75, PaymentStatus = "Pending", PaymentDate = DateTime.Now, TransactionId = "16AHD" },
       new Checkout { CheckoutId = 3, CourseId = 3, StudentId = 1, Amount = 100, PaymentStatus = "Failed", PaymentDate = DateTime.Now, TransactionId = "1ABDOD" },
       new Checkout { CheckoutId = 4, CourseId = 4, StudentId = 4, Amount = 120, PaymentStatus = "Paid", PaymentDate = DateTime.Now, TransactionId = "1ADFHBD" },
       new Checkout { CheckoutId = 5, CourseId = 5, StudentId = 4, Amount = 80, PaymentStatus = "Pending", PaymentDate = DateTime.Now, TransactionId = "1ABDD" }
   );



        // Insert 5 hàng vào bảng Enrollment
        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { EnrollmentId = 1, CourseId = 1, StudentId = 1, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 2, CourseId = 2, StudentId = 2, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 3, CourseId = 3, StudentId = 3, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 4, CourseId = 4, StudentId = 4, EnrollmentDate = DateTime.Now },
            new Enrollment { EnrollmentId = 5, CourseId = 5, StudentId = 5, EnrollmentDate = DateTime.Now }
        );
        modelBuilder.Entity<Section>().HasData(
         // Software Development Courses
         new Section { SectionId = 1, CourseId = 1, Title = "Introduction to C# - Section 1", Duration = TimeSpan.FromHours(1) },
         new Section { SectionId = 2, CourseId = 1, Title = "Introduction to C# - Section 2", Duration = TimeSpan.FromHours(1.5) },
         new Section { SectionId = 3, CourseId = 1, Title = "Introduction to C# - Section 3", Duration = TimeSpan.FromHours(2) },
         new Section { SectionId = 4, CourseId = 1, Title = "Introduction to C# - Section 4", Duration = TimeSpan.FromHours(1.2) },
         new Section { SectionId = 5, CourseId = 1, Title = "Introduction to C# - Section 5", Duration = TimeSpan.FromHours(1.8) },

         new Section { SectionId = 6, CourseId = 2, Title = "Advanced C# Programming - Section 1", Duration = TimeSpan.FromHours(1) },
         new Section { SectionId = 7, CourseId = 2, Title = "Advanced C# Programming - Section 2", Duration = TimeSpan.FromHours(1.5) },
         new Section { SectionId = 8, CourseId = 2, Title = "Advanced C# Programming - Section 3", Duration = TimeSpan.FromHours(2) },
         new Section { SectionId = 9, CourseId = 2, Title = "Advanced C# Programming - Section 4", Duration = TimeSpan.FromHours(1.2) },
         new Section { SectionId = 10, CourseId = 2, Title = "Advanced C# Programming - Section 5", Duration = TimeSpan.FromHours(1.8) },

         new Section { SectionId = 11, CourseId = 3, Title = "C# for Web Development - Section 1", Duration = TimeSpan.FromHours(1) },
         new Section { SectionId = 12, CourseId = 3, Title = "C# for Web Development - Section 2", Duration = TimeSpan.FromHours(1.5) },
         new Section { SectionId = 13, CourseId = 3, Title = "C# for Web Development - Section 3", Duration = TimeSpan.FromHours(2) },
         new Section { SectionId = 14, CourseId = 3, Title = "C# for Web Development - Section 4", Duration = TimeSpan.FromHours(1.2) },
         new Section { SectionId = 15, CourseId = 3, Title = "C# for Web Development - Section 5", Duration = TimeSpan.FromHours(1.8) },

         new Section { SectionId = 16, CourseId = 4, Title = "C# Design Patterns - Section 1", Duration = TimeSpan.FromHours(1) },
         new Section { SectionId = 17, CourseId = 4, Title = "C# Design Patterns - Section 2", Duration = TimeSpan.FromHours(1.5) },
         new Section { SectionId = 18, CourseId = 4, Title = "C# Design Patterns - Section 3", Duration = TimeSpan.FromHours(2) },
         new Section { SectionId = 19, CourseId = 4, Title = "C# Design Patterns - Section 4", Duration = TimeSpan.FromHours(1.2) },
         new Section { SectionId = 20, CourseId = 4, Title = "C# Design Patterns - Section 5", Duration = TimeSpan.FromHours(1.8) },

         new Section { SectionId = 21, CourseId = 5, Title = "C# for Mobile Development - Section 1", Duration = TimeSpan.FromHours(1) },
         new Section { SectionId = 22, CourseId = 5, Title = "C# for Mobile Development - Section 2", Duration = TimeSpan.FromHours(1.5) },
         new Section { SectionId = 23, CourseId = 5, Title = "C# for Mobile Development - Section 3", Duration = TimeSpan.FromHours(2) },
         new Section { SectionId = 24, CourseId = 5, Title = "C# for Mobile Development - Section 4", Duration = TimeSpan.FromHours(1.2) },
         new Section { SectionId = 25, CourseId = 5, Title = "C# for Mobile Development - Section 5", Duration = TimeSpan.FromHours(1.8) }
     );

        // Insert 5 hàng vào bảng Lecture
        modelBuilder.Entity<Lecture>().HasData(
     // Lectures for Section 1 of "Introduction to C#"
     new Lecture { LectureId = 1, SectionId = 1, Title = "Introduction to C#", Content = "Introduction to C# content", Duration = TimeSpan.FromMinutes(30), VideoUrl = "https://example.com/video1" },
     new Lecture { LectureId = 2, SectionId = 1, Title = "Basic Syntax", Content = "Basic syntax content", Duration = TimeSpan.FromMinutes(45), VideoUrl = "https://example.com/video2" },
     new Lecture { LectureId = 3, SectionId = 1, Title = "Data Types and Variables", Content = "Data types and variables content", Duration = TimeSpan.FromMinutes(40), VideoUrl = "https://example.com/video3" },
     new Lecture { LectureId = 4, SectionId = 1, Title = "Control Flow Statements", Content = "Control flow statements content", Duration = TimeSpan.FromMinutes(50), VideoUrl = "https://example.com/video4" },
     new Lecture { LectureId = 5, SectionId = 1, Title = "Methods and Functions", Content = "Methods and functions content", Duration = TimeSpan.FromMinutes(55), VideoUrl = "https://example.com/video5" },

     // Lectures for Section 2 of "Advanced C# Programming"
     new Lecture { LectureId = 6, SectionId = 2, Title = "Advanced Topics in C#", Content = "Advanced topics in C# content", Duration = TimeSpan.FromMinutes(60), VideoUrl = "https://example.com/video6" },
     new Lecture { LectureId = 7, SectionId = 2, Title = "LINQ and Lambda Expressions", Content = "LINQ and lambda expressions content", Duration = TimeSpan.FromMinutes(50), VideoUrl = "https://example.com/video7" },
     new Lecture { LectureId = 8, SectionId = 2, Title = "Multithreading in C#", Content = "Multithreading in C# content", Duration = TimeSpan.FromMinutes(55), VideoUrl = "https://example.com/video8" },
     new Lecture { LectureId = 9, SectionId = 2, Title = "Asynchronous Programming", Content = "Asynchronous programming content", Duration = TimeSpan.FromMinutes(65), VideoUrl = "https://example.com/video9" },
     new Lecture { LectureId = 10, SectionId = 2, Title = "Advanced Design Patterns", Content = "Advanced design patterns content", Duration = TimeSpan.FromMinutes(70), VideoUrl = "https://example.com/video10" },

     // Lectures for Section 3 of "C# for Web Development"
     new Lecture { LectureId = 11, SectionId = 3, Title = "Introduction to ASP.NET Core", Content = "Introduction to ASP.NET Core content", Duration = TimeSpan.FromMinutes(45), VideoUrl = "https://example.com/video11" },
     new Lecture { LectureId = 12, SectionId = 3, Title = "Building RESTful APIs", Content = "Building RESTful APIs content", Duration = TimeSpan.FromMinutes(60), VideoUrl = "https://example.com/video12" },
     new Lecture { LectureId = 13, SectionId = 3, Title = "Entity Framework Core", Content = "Entity Framework Core content", Duration = TimeSpan.FromMinutes(55), VideoUrl = "https://example.com/video13" },
     new Lecture { LectureId = 14, SectionId = 3, Title = "Authentication and Authorization", Content = "Authentication and authorization content", Duration = TimeSpan.FromMinutes(50), VideoUrl = "https://example.com/video14" },
     new Lecture { LectureId = 15, SectionId = 3, Title = "Deploying ASP.NET Core Applications", Content = "Deploying ASP.NET Core applications content", Duration = TimeSpan.FromMinutes(65), VideoUrl = "https://example.com/video15" }
 );


        // Insert 5 hàng vào bảng Document
        modelBuilder.Entity<Document>().HasData(
      // Documents for Section 1
      new Document { DocumentId = 1, SectionId = 1, Title = "Introduction to C# - Document 1", Url = "https://example.com/document1" },
      new Document { DocumentId = 2, SectionId = 1, Title = "Introduction to C# - Document 2", Url = "https://example.com/document2" },
      new Document { DocumentId = 3, SectionId = 1, Title = "Introduction to C# - Document 3", Url = "https://example.com/document3" },
      new Document { DocumentId = 4, SectionId = 1, Title = "Introduction to C# - Document 4", Url = "https://example.com/document4" },
      new Document { DocumentId = 5, SectionId = 1, Title = "Introduction to C# - Document 5", Url = "https://example.com/document5" },

      // Documents for Section 2
      new Document { DocumentId = 6, SectionId = 2, Title = "Advanced C# Programming - Document 1", Url = "https://example.com/document6" },
      new Document { DocumentId = 7, SectionId = 2, Title = "Advanced C# Programming - Document 2", Url = "https://example.com/document7" },
      new Document { DocumentId = 8, SectionId = 2, Title = "Advanced C# Programming - Document 3", Url = "https://example.com/document8" },
      new Document { DocumentId = 9, SectionId = 2, Title = "Advanced C# Programming - Document 4", Url = "https://example.com/document9" },
      new Document { DocumentId = 10, SectionId = 2, Title = "Advanced C# Programming - Document 5", Url = "https://example.com/document10" },

      // Documents for Section 3
      new Document { DocumentId = 11, SectionId = 3, Title = "C# for Web Development - Document 1", Url = "https://example.com/document11" },
      new Document { DocumentId = 12, SectionId = 3, Title = "C# for Web Development - Document 2", Url = "https://example.com/document12" },
      new Document { DocumentId = 13, SectionId = 3, Title = "C# for Web Development - Document 3", Url = "https://example.com/document13" },
      new Document { DocumentId = 14, SectionId = 3, Title = "C# for Web Development - Document 4", Url = "https://example.com/document14" },
      new Document { DocumentId = 15, SectionId = 3, Title = "C# for Web Development - Document 5", Url = "https://example.com/document15" },

      // Documents for Section 4
      new Document { DocumentId = 16, SectionId = 4, Title = "C# Design Patterns - Document 1", Url = "https://example.com/document16" },
      new Document { DocumentId = 17, SectionId = 4, Title = "C# Design Patterns - Document 2", Url = "https://example.com/document17" },
      new Document { DocumentId = 18, SectionId = 4, Title = "C# Design Patterns - Document 3", Url = "https://example.com/document18" },
      new Document { DocumentId = 19, SectionId = 4, Title = "C# Design Patterns - Document 4", Url = "https://example.com/document19" },
      new Document { DocumentId = 20, SectionId = 4, Title = "C# Design Patterns - Document 5", Url = "https://example.com/document20" },

      // Documents for Section 5
      new Document { DocumentId = 21, SectionId = 5, Title = "C# for Mobile Development - Document 1", Url = "https://example.com/document21" },
      new Document { DocumentId = 22, SectionId = 5, Title = "C# for Mobile Development - Document 2", Url = "https://example.com/document22" },
      new Document { DocumentId = 23, SectionId = 5, Title = "C# for Mobile Development - Document 3", Url = "https://example.com/document23" },
      new Document { DocumentId = 24, SectionId = 5, Title = "C# for Mobile Development - Document 4", Url = "https://example.com/document24" },
      new Document { DocumentId = 25, SectionId = 5, Title = "C# for Mobile Development - Document 5", Url = "https://example.com/document25" }
  );


        // Insert 5 hàng vào bảng Review
        modelBuilder.Entity<Review>().HasData(
      // Reviews for Course 1
      new Review { ReviewId = 1, CourseId = 1, StudentId = 1, Rating = 4.5m, Comment = "Good course", ReviewDate = DateTime.Now },
      new Review { ReviewId = 2, CourseId = 1, StudentId = 1, Rating = 4.2m, Comment = "Very informative", ReviewDate = DateTime.Now },
      new Review { ReviewId = 3, CourseId = 1, StudentId = 1, Rating = 4.0m, Comment = "Helped me a lot", ReviewDate = DateTime.Now },

      // Reviews for Course 2
      new Review { ReviewId = 4, CourseId = 2, StudentId = 1, Rating = 3.8m, Comment = "Could be better", ReviewDate = DateTime.Now },
      new Review { ReviewId = 5, CourseId = 2, StudentId = 1, Rating = 4.1m, Comment = "Good content", ReviewDate = DateTime.Now },

      // Reviews for Course 3
      new Review { ReviewId = 6, CourseId = 3, StudentId = 4, Rating = 4.7m, Comment = "Excellent content", ReviewDate = DateTime.Now },

      // Reviews for Course 4
      new Review { ReviewId = 7, CourseId = 4, StudentId = 1, Rating = 4.8m, Comment = "Very detailed", ReviewDate = DateTime.Now },

      // Reviews for Course 5
      new Review { ReviewId = 8, CourseId = 5, StudentId = 4, Rating = 3.9m, Comment = "Interesting course", ReviewDate = DateTime.Now },
      new Review { ReviewId = 9, CourseId = 5, StudentId = 4, Rating = 4.3m, Comment = "Enjoyed learning from it", ReviewDate = DateTime.Now }
  );


        // Insert 5 hàng vào bảng Section

        modelBuilder.Entity<Certificate>().HasData(
     new Certificate { CertificateId = 1, Title = "Certificate 1", Description = "Description for Certificate 1", IssuedBy = "Issuing Authority 1", CertificateUrl = "https://example.com/certificate1" },
     new Certificate { CertificateId = 2, Title = "Certificate 2", Description = "Description for Certificate 2", IssuedBy = "Issuing Authority 2", CertificateUrl = "https://example.com/certificate2" },
     new Certificate { CertificateId = 3, Title = "Certificate 3", Description = "Description for Certificate 3", IssuedBy = "Issuing Authority 3", CertificateUrl = "https://example.com/certificate3" },
     new Certificate { CertificateId = 4, Title = "Certificate 4", Description = "Description for Certificate 4", IssuedBy = "Issuing Authority 4", CertificateUrl = "https://example.com/certificate4" },
     new Certificate { CertificateId = 5, Title = "Certificate 5", Description = "Description for Certificate 5", IssuedBy = "Issuing Authority 5", CertificateUrl = "https://example.com/certificate5" }
 );


        modelBuilder.Entity<StudentCertificate>().HasData(
    new StudentCertificate { UserId = 1, CertificateId = 1, CompletionDate = new DateTime(2023, 5, 15), CompletionTime = TimeSpan.FromHours(2) },
    new StudentCertificate { UserId = 2, CertificateId = 2, CompletionDate = new DateTime(2023, 6, 20), CompletionTime = TimeSpan.FromHours(1.5) },
    new StudentCertificate { UserId = 3, CertificateId = 1, CompletionDate = new DateTime(2023, 4, 10), CompletionTime = TimeSpan.FromHours(1) },
    new StudentCertificate { UserId = 4, CertificateId = 2, CompletionDate = new DateTime(2023, 7, 5), CompletionTime = TimeSpan.FromHours(2.5) },
    new StudentCertificate { UserId = 5, CertificateId = 1, CompletionDate = new DateTime(2023, 8, 15), CompletionTime = TimeSpan.FromHours(1.8) }
);



        modelBuilder.Entity<SystemSetting>().HasData(
     new SystemSetting { SettingId = 1, UserId = 1, Theme = "Dark", Language = "English", NotificationsEnabled = true },
     new SystemSetting { SettingId = 2, UserId = 2, Theme = "Light", Language = "French", NotificationsEnabled = false },
     new SystemSetting { SettingId = 3, UserId = 3, Theme = "Light", Language = "Spanish", NotificationsEnabled = true },
     new SystemSetting { SettingId = 4, UserId = 4, Theme = "Dark", Language = "German", NotificationsEnabled = false },
     new SystemSetting { SettingId = 5, UserId = 5, Theme = "Dark", Language = "Chinese", NotificationsEnabled = true }
 );




        modelBuilder.Entity<StudentCertificate>()
           .HasKey(sc => new { sc.UserId, sc.CertificateId });

        modelBuilder.Entity<StudentCertificate>()
            .HasOne(sc => sc.User)
            .WithMany(u => u.StudentCertificates)
            .HasForeignKey(sc => sc.UserId);

        modelBuilder.Entity<StudentCertificate>()
            .HasOne(sc => sc.Certificate)
            .WithMany(c => c.StudentCertificates)
            .HasForeignKey(sc => sc.CertificateId);

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2B4E099F62");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });
        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.HasKey(e => e.SubCategoryId).HasName("PK__SubCategori__19093A2B4E099F62");

            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.HasMany(sc => sc.Courses).WithOne(c => c.SubCategory);
            entity.HasOne(sc => sc.Category).WithMany(c => c.SubCategories);


        });


        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => e.CheckoutId).HasName("PK__Checkout__E07EF51CCFBA1268");

            entity.Property(e => e.CheckoutId).HasColumnName("CheckoutID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.PaymentDate).HasColumnType("date");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TransactionID");

            entity.HasOne(d => d.Course).WithMany(p => p.Checkouts)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Checkouts__Cours__571DF1D5");

            entity.HasOne(d => d.Student).WithMany(p => p.Checkouts)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Checkouts__Stude__5629CD9C");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__C92D71876D4CFFEC");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryId");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstructorId).HasColumnName("InstructorID");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.Courses)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK__Courses__SubCategor__3E52440B");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Courses)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK__Courses__Instruc__3F466844");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__Document__1ABEEF6F6F6C41B2");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Section).WithMany(p => p.Documents)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK__Documents__Secti__47DBAE45");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__7F6877FB59BADBB3");

            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.EnrollmentDate).HasColumnType("date");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Enrollmen__Cours__4F7CD00D");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Enrollmen__Stude__4E88ABD4");
        });

        modelBuilder.Entity<Lecture>(entity =>
        {
            entity.HasKey(e => e.LectureId).HasName("PK__Lectures__B739F69F45AA0B10");

            entity.Property(e => e.LectureId).HasColumnName("LectureID");
            entity.Property(e => e.Content).HasColumnType("text");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VideoURL");

            entity.HasOne(d => d.Section).WithMany(p => p.Lectures)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK__Lectures__Sectio__44FF419A");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79AEB05343AB");

            entity.Property(e => e.ReviewId).HasColumnName("ReviewID");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.ReviewDate).HasColumnType("date");
            entity.Property(e => e.ReOpen).HasColumnType("int");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Reviews__CourseI__534D60F1");

            entity.HasOne(d => d.Student).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Reviews__Student__52593CB8");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A672CA399");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PK__Sections__80EF08920752F11A");

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Sections)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Sections__Course__4222D4EF");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CourseId }).HasName("PK__StudentC__7B1A1BB4D2465F24");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentCo__Cours__4BAC3F29");

            entity.HasOne(d => d.User).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentCo__UserI__4AB81AF0");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK__SystemSe__54372AFDC5ADF01D");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SystemSettings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SystemSet__UserI__59FA5E80");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACEF9D4767");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Bio).HasMaxLength(500);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleID__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
