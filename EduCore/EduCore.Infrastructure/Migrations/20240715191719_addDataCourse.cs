using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDataCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 5,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Description", "Duration", "InstructorID", "Level", "Price", "Rating", "Sale", "SubCategoryId", "Title", "URL" },
                values: new object[,]
                {
                    { 30, "Learn the basics of entrepreneurship.", "10 hours", 2, "Beginner", 150000m, 4.5m, 15, 6, "Entrepreneurship Basics", "https://example.com/course1" },
                    { 31, "Master the fundamentals of starting a business.", "12 hours", 3, "Intermediate", 150000m, 4.7m, 20, 6, "Startup Fundamentals", "https://example.com/course2" },
                    { 32, "Strategies for scaling your startup.", "15 hours", 2, "Advanced", 320000m, 4.9m, 25, 6, "Scaling Your Startup", "https://example.com/course3" },
                    { 33, "Essential management techniques.", "12 hours", 3, "Intermediate", 150000m, 4.6m, 10, 7, "Management Essentials", "https://example.com/course4" },
                    { 34, "Develop essential leadership skills.", "18 hours", 2, "Advanced", 320000m, 4.8m, 20, 7, "Leadership Skills", "https://example.com/course5" },
                    { 35, "Master the art of team building.", "8 hours", 3, "Beginner", 320000m, 4.6m, 15, 7, "Team Building Strategies", "https://example.com/course6" },
                    { 36, "A beginner's guide to finance.", "12 hours", 2, "Beginner", 150000m, 4.7m, 10, 8, "Finance for Beginners", "https://example.com/course7" },
                    { 37, "Learn how to analyze financial statements.", "18 hours", 3, "Intermediate", 320000m, 4.8m, 20, 8, "Financial Analysis", "https://example.com/course8" },
                    { 38, "Advanced strategies for investing in the stock market.", "25 hours", 2, "Advanced", 320000m, 4.9m, 30, 8, "Advanced Investment Strategies", "https://example.com/course9" },
                    { 39, "An introduction to human resource management.", "10 hours", 2, "Beginner", 180000m, 4.5m, 15, 9, "Introduction to HR Management", "https://example.com/course10" },
                    { 40, "Effective strategies for managing employee relations.", "12 hours", 3, "Intermediate", 200000m, 4.7m, 20, 9, "Employee Relations", "https://example.com/course11" },
                    { 41, "Strategies for effective talent acquisition.", "15 hours", 2, "Advanced", 350000m, 4.9m, 25, 9, "Talent Acquisition", "https://example.com/course12" },
                    { 42, "Effective sales techniques.", "12 hours", 3, "Intermediate", 160000m, 4.6m, 10, 10, "Sales Techniques", "https://example.com/course13" },
                    { 43, "Mastering negotiation skills.", "18 hours", 2, "Advanced", 330000m, 4.8m, 20, 10, "Negotiation Skills", "https://example.com/course14" },
                    { 44, "Strategies for effective closing of sales.", "8 hours", 3, "Beginner", 330000m, 4.6m, 15, 10, "Closing Strategies", "https://example.com/course15" },
                    { 45, "An introduction to graphic design principles.", "12 hours", 2, "Beginner", 170000m, 4.7m, 10, 11, "Introduction to Graphic Design", "https://example.com/course16" },
                    { 46, "Mastering typography in design.", "18 hours", 3, "Intermediate", 300000m, 4.8m, 20, 11, "Typography Fundamentals", "https://example.com/course17" },
                    { 47, "Mastering the art of logo design.", "25 hours", 2, "Advanced", 300000m, 4.9m, 30, 11, "Logo Design Mastery", "https://example.com/course18" },
                    { 48, "Designing responsive websites.", "12 hours", 3, "Intermediate", 180000m, 4.6m, 15, 12, "Responsive Web Design", "https://example.com/course19" },
                    { 49, "Creating effective user interfaces.", "18 hours", 2, "Advanced", 330000m, 4.8m, 25, 12, "User Interface Design", "https://example.com/course20" },
                    { 50, "Ensuring web accessibility standards.", "8 hours", 3, "Beginner", 330000m, 4.6m, 20, 12, "Web Accessibility", "https://example.com/course21" },
                    { 51, "Fundamentals of UI design.", "10 hours", 2, "Beginner", 190000m, 4.5m, 15, 13, "UI Design Fundamentals", "https://example.com/course22" },
                    { 52, "Creating great user experiences.", "12 hours", 3, "Intermediate", 200000m, 4.7m, 20, 13, "User Experience Design", "https://example.com/course23" },
                    { 53, "Designing interactive experiences.", "15 hours", 2, "Advanced", 350000m, 4.9m, 25, 13, "Interaction Design", "https://example.com/course24" },
                    { 54, "Basics of 2D animation.", "12 hours", 3, "Intermediate", 160000m, 4.6m, 10, 14, "2D Animation Basics", "https://example.com/course25" },
                    { 55, "Creating character animations.", "18 hours", 2, "Advanced", 330000m, 4.8m, 20, 14, "Character Animation", "https://example.com/course26" },
                    { 56, "Creating engaging motion graphics.", "8 hours", 3, "Beginner", 330000m, 4.6m, 15, 14, "Motion Graphics", "https://example.com/course27" },
                    { 57, "Basic principles of interior design.", "12 hours", 2, "Beginner", 170000m, 4.7m, 10, 15, "Interior Design Basics", "https://example.com/course28" },
                    { 58, "Understanding color theory in design.", "18 hours", 3, "Intermediate", 300000m, 4.8m, 20, 15, "Color Theory in Design", "https://example.com/course29" },
                    { 59, "Effective space planning strategies.", "25 hours", 2, "Advanced", 300000m, 4.9m, 30, 15, "Space Planning", "https://example.com/course30" },
                    { 60, "Fundamentals of digital marketing.", "10 hours", 2, "Beginner", 180000m, 4.5m, 15, 16, "Digital Marketing Fundamentals", "https://example.com/course31" },
                    { 61, "Effective social media marketing strategies.", "12 hours", 3, "Intermediate", 200000m, 4.7m, 20, 16, "Social Media Strategies", "https://example.com/course32" },
                    { 62, "Fundamentals of search engine optimization.", "15 hours", 2, "Advanced", 350000m, 4.9m, 25, 16, "SEO Fundamentals", "https://example.com/course33" },
                    { 63, "Developing a content marketing strategy.", "12 hours", 3, "Intermediate", 160000m, 4.6m, 10, 17, "Content Marketing Strategy", "https://example.com/course34" },
                    { 64, "Starting a successful blog.", "18 hours", 2, "Advanced", 330000m, 4.8m, 20, 17, "Blogging for Beginners", "https://example.com/course35" },
                    { 65, "Using video for marketing purposes.", "8 hours", 3, "Beginner", 330000m, 4.6m, 15, 17, "Video Marketing", "https://example.com/course36" },
                    { 66, "Advertising on social media platforms.", "12 hours", 2, "Beginner", 170000m, 4.7m, 10, 18, "Social Media Advertising", "https://example.com/course37" },
                    { 67, "Strategies for influencer marketing.", "18 hours", 3, "Intermediate", 300000m, 4.8m, 20, 18, "Influencer Marketing", "https://example.com/course38" },
                    { 68, "Managing communities on social media.", "25 hours", 2, "Advanced", 300000m, 4.9m, 30, 18, "Community Management", "https://example.com/course39" },
                    { 69, "Optimizing on-page factors for SEO.", "12 hours", 3, "Intermediate", 180000m, 4.6m, 15, 19, "On-Page SEO", "https://example.com/course40" },
                    { 70, "Effective strategies for link building.", "18 hours", 2, "Advanced", 330000m, 4.8m, 20, 19, "Link Building Strategies", "https://example.com/course41" },
                    { 71, "Optimizing for local search results.", "8 hours", 3, "Beginner", 330000m, 4.6m, 10, 19, "Local SEO", "https://example.com/course42" },
                    { 72, "Essential practices in email marketing.", "10 hours", 2, "Beginner", 190000m, 4.5m, 15, 20, "Email Marketing Essentials", "https://example.com/course43" },
                    { 73, "Writing effective email copy.", "12 hours", 3, "Intermediate", 200000m, 4.7m, 20, 20, "Email Copywriting", "https://example.com/course44" },
                    { 74, "Setting up automated email campaigns.", "15 hours", 2, "Advanced", 350000m, 4.9m, 25, 20, "Automated Email Campaigns", "https://example.com/course45" },
                    { 75, "An introduction to supply chain management.", "12 hours", 2, "Beginner", 170000m, 4.7m, 10, 21, "Introduction to Supply Chain", "https://example.com/course46" },
                    { 76, "Managing logistics in supply chain.", "18 hours", 3, "Intermediate", 300000m, 4.8m, 20, 21, "Logistics Management", "https://example.com/course47" },
                    { 77, "Optimizing inventory management.", "25 hours", 2, "Advanced", 300000m, 4.9m, 30, 21, "Inventory Optimization", "https://example.com/course48" },
                    { 78, "Controlling inventory levels.", "12 hours", 3, "Intermediate", 180000m, 4.6m, 15, 22, "Inventory Control", "https://example.com/course49" },
                    { 79, "Managing warehouse operations.", "18 hours", 2, "Advanced", 330000m, 4.8m, 25, 22, "Warehouse Operations", "https://example.com/course50" },
                    { 80, "Analyzing supply chain data.", "8 hours", 3, "Beginner", 330000m, 4.6m, 20, 22, "Supply Chain Analytics", "https://example.com/course51" },
                    { 81, "Basics of transportation management.", "10 hours", 2, "Beginner", 190000m, 4.5m, 15, 23, "Transportation Basics", "https://example.com/course52" },
                    { 82, "Managing freight logistics.", "12 hours", 3, "Intermediate", 200000m, 4.7m, 20, 23, "Freight Management", "https://example.com/course53" },
                    { 83, "Strategies for global logistics.", "15 hours", 2, "Advanced", 350000m, 4.9m, 25, 23, "Global Logistics", "https://example.com/course54" },
                    { 84, "Designing efficient warehouses.", "12 hours", 3, "Intermediate", 160000m, 4.6m, 10, 24, "Warehouse Design", "https://example.com/course55" },
                    { 85, "Tracking inventory effectively.", "18 hours", 2, "Advanced", 330000m, 4.8m, 20, 24, "Inventory Tracking", "https://example.com/course56" },
                    { 86, "Ensuring safety in warehouse operations.", "8 hours", 3, "Beginner", 330000m, 4.6m, 15, 24, "Warehouse Safety", "https://example.com/course57" },
                    { 87, "Fundamentals of procurement.", "12 hours", 2, "Beginner", 170000m, 4.7m, 10, 25, "Procurement Fundamentals", "https://example.com/course58" },
                    { 88, "Managing supplier relationships.", "18 hours", 3, "Intermediate", 300000m, 4.8m, 20, 25, "Supplier Relationship Management", "https://example.com/course59" },
                    { 89, "Developing negotiation skills for procurement.", "25 hours", 2, "Advanced", 300000m, 4.9m, 30, 25, "Negotiation Skills in Procurement", "https://example.com/course60" }
                });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 5,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 17, 18, 408, DateTimeKind.Local).AddTicks(1901));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 89);

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 5,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 5,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 16, 2, 5, 28, 935, DateTimeKind.Local).AddTicks(4351));
        }
    }
}
