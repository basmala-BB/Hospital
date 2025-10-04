using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Dermatology" },
                    { 3, "Neurology" },
                    { 4, "Pediatrics" },
                    { 5, "Orthopedics" },
                    { 6, "General Surgery" }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "DoctorId", "ImagePath", "Name", "Phone", "SpecializationId" },
                values: new object[,]
                {
                    { 1, "/images/doctors/john.png", "Dr. John Smith", "01000000001", 1 },
                    { 2, "/images/doctors/sarah.png", "Dr. Sarah Johnson", "01000000002", 2 },
                    { 3, "/images/doctors/emily.png", "Dr. Emily Davis", "01000000003", 3 },
                    { 4, "/images/doctors/michael.png", "Dr. Michael Brown", "01000000004", 4 },
                    { 5, "/images/doctors/olivia.png", "Dr. Olivia Wilson", "01000000005", 5 },
                    { 6, "/images/doctors/david.png", "Dr. David Miller", "01000000006", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "DoctorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specializations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "doctors");
        }
    }
}
