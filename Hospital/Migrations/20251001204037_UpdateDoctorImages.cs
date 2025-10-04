using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDoctorImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "ImagePath",
                value: "doctor1.jpg");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "ImagePath",
                value: "doctor2.jpg");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "ImagePath",
                value: "doctor3.jpg");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                column: "ImagePath",
                value: "doctor4.jpg");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                column: "ImagePath",
                value: "doctor5.jpg");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 6,
                column: "ImagePath",
                value: "doctor6.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/doctors/john.png");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/doctors/sarah.png");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/doctors/emily.png");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/doctors/michael.png");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/doctors/olivia.png");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/doctors/david.png");
        }
    }
}
