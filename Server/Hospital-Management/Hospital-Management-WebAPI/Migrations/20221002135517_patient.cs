using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_WebAPI.Migrations
{
    public partial class patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phn_Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PatientDoctor",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PatientDoctor", x => new { x.PatientId, x.DoctorId });
                    table.ForeignKey(
                        name: "FK_tbl_PatientDoctor_tbl_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "tbl_Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_PatientDoctor_tbl_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "tbl_Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PatientDoctor_DoctorId",
                table: "tbl_PatientDoctor",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_PatientDoctor");

            migrationBuilder.DropTable(
                name: "tbl_Patients");
        }
    }
}
