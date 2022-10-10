﻿// <auto-generated />
using System;
using Hospital_Management_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Management_WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phnNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specialist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_Doctors");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.MedicalReport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicalResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicalTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("patientId")
                        .HasColumnType("int");

                    b.Property<string>("patientProblem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("patientId");

                    b.ToTable("tbl_medicalReports");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phnNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_Patients");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.PatientBill", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("billAmount")
                        .HasColumnType("int");

                    b.Property<string>("billType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("patientId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("patientId");

                    b.ToTable("tbl_PatientBill");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.PatientDoctor", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("PatientId", "DoctorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("tbl_PatientDoctor");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.MedicalReport", b =>
                {
                    b.HasOne("Hospital_Management_WebAPI.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("patientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.PatientBill", b =>
                {
                    b.HasOne("Hospital_Management_WebAPI.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("patientId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.PatientDoctor", b =>
                {
                    b.HasOne("Hospital_Management_WebAPI.Models.Doctor", "Doctor")
                        .WithMany("patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_WebAPI.Models.Patient", "Patient")
                        .WithMany("doctors")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.Doctor", b =>
                {
                    b.Navigation("patients");
                });

            modelBuilder.Entity("Hospital_Management_WebAPI.Models.Patient", b =>
                {
                    b.Navigation("doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
