using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_WebAPI.Migrations
{
    public partial class smallLetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_medicalReports_tbl_Patients_PatientId",
                table: "tbl_medicalReports");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PatientBill_tbl_Patients_PatientId",
                table: "tbl_PatientBill");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Patients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "tbl_Patients",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "tbl_Patients",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbl_Patients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Phn_Number",
                table: "tbl_Patients",
                newName: "phnNumber");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "tbl_PatientBill",
                newName: "patientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbl_PatientBill",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Bill_Type",
                table: "tbl_PatientBill",
                newName: "billType");

            migrationBuilder.RenameColumn(
                name: "Bill_Amount",
                table: "tbl_PatientBill",
                newName: "billAmount");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_PatientBill_PatientId",
                table: "tbl_PatientBill",
                newName: "IX_tbl_PatientBill_patientId");

            migrationBuilder.RenameColumn(
                name: "PatientProblem",
                table: "tbl_medicalReports",
                newName: "patientProblem");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "tbl_medicalReports",
                newName: "patientId");

            migrationBuilder.RenameColumn(
                name: "MedicalTest",
                table: "tbl_medicalReports",
                newName: "medicalTest");

            migrationBuilder.RenameColumn(
                name: "MedicalResult",
                table: "tbl_medicalReports",
                newName: "medicalResult");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbl_medicalReports",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_medicalReports_PatientId",
                table: "tbl_medicalReports",
                newName: "IX_tbl_medicalReports_patientId");

            migrationBuilder.RenameColumn(
                name: "Specialist",
                table: "tbl_Doctors",
                newName: "specialist");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Doctors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tbl_Doctors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Phn_Number",
                table: "tbl_Doctors",
                newName: "phnNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_medicalReports_tbl_Patients_patientId",
                table: "tbl_medicalReports",
                column: "patientId",
                principalTable: "tbl_Patients",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PatientBill_tbl_Patients_patientId",
                table: "tbl_PatientBill",
                column: "patientId",
                principalTable: "tbl_Patients",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_medicalReports_tbl_Patients_patientId",
                table: "tbl_medicalReports");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_PatientBill_tbl_Patients_patientId",
                table: "tbl_PatientBill");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tbl_Patients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "tbl_Patients",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "tbl_Patients",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tbl_Patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "phnNumber",
                table: "tbl_Patients",
                newName: "Phn_Number");

            migrationBuilder.RenameColumn(
                name: "patientId",
                table: "tbl_PatientBill",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tbl_PatientBill",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "billType",
                table: "tbl_PatientBill",
                newName: "Bill_Type");

            migrationBuilder.RenameColumn(
                name: "billAmount",
                table: "tbl_PatientBill",
                newName: "Bill_Amount");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_PatientBill_patientId",
                table: "tbl_PatientBill",
                newName: "IX_tbl_PatientBill_PatientId");

            migrationBuilder.RenameColumn(
                name: "patientProblem",
                table: "tbl_medicalReports",
                newName: "PatientProblem");

            migrationBuilder.RenameColumn(
                name: "patientId",
                table: "tbl_medicalReports",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "medicalTest",
                table: "tbl_medicalReports",
                newName: "MedicalTest");

            migrationBuilder.RenameColumn(
                name: "medicalResult",
                table: "tbl_medicalReports",
                newName: "MedicalResult");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tbl_medicalReports",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_medicalReports_patientId",
                table: "tbl_medicalReports",
                newName: "IX_tbl_medicalReports_PatientId");

            migrationBuilder.RenameColumn(
                name: "specialist",
                table: "tbl_Doctors",
                newName: "Specialist");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tbl_Doctors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tbl_Doctors",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "phnNumber",
                table: "tbl_Doctors",
                newName: "Phn_Number");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_medicalReports_tbl_Patients_PatientId",
                table: "tbl_medicalReports",
                column: "PatientId",
                principalTable: "tbl_Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_PatientBill_tbl_Patients_PatientId",
                table: "tbl_PatientBill",
                column: "PatientId",
                principalTable: "tbl_Patients",
                principalColumn: "Id");
        }
    }
}
