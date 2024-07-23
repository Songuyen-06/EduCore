using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAtributeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "CheckoutID",
                keyValue: 5,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 4,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentID",
                keyValue: 5,
                column: "EnrollmentDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 7, 17, 20, 24, 34, 130, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4,
                column: "UrlImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5,
                column: "UrlImage",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Users");

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
    }
}
