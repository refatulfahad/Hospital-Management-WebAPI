using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_WebAPI.Migrations
{
    public partial class medicalReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_medicalReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientProblem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalTest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_medicalReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_medicalReports_tbl_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "tbl_Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_medicalReports_PatientId",
                table: "tbl_medicalReports",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_medicalReports");
        }
    }
}
