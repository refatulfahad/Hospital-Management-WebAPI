using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_WebAPI.Migrations
{
    public partial class patientBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_PatientBill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bill_Amount = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PatientBill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_PatientBill_tbl_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "tbl_Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PatientBill_PatientId",
                table: "tbl_PatientBill",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_PatientBill");
        }
    }
}
