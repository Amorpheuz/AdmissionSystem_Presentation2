﻿// <auto-generated />
using System;
using AdmissionSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdmissionSystem.Migrations
{
    [DbContext(typeof(AdmissionContext))]
    [Migration("20181003060539_migratetest4")]
    partial class migratetest4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdmissionSystem.Models.AcademicRecord", b =>
                {
                    b.Property<int>("AcademicRecordID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoardOrUni")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LangOfInstruction")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("MarksObtained")
                        .IsRequired();

                    b.Property<decimal>("MeritNumber");

                    b.Property<DateTime>("MonthYearOfPass");

                    b.Property<string>("RollNumber")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("SchoolOrCollegeName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("ScoreValidity");

                    b.Property<int?>("StudentID");

                    b.HasKey("AcademicRecordID");

                    b.HasIndex("StudentID");

                    b.ToTable("AcademicRecord");
                });

            modelBuilder.Entity("AdmissionSystem.Models.AcademicYear", b =>
                {
                    b.Property<int>("AcademicYearID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AcaYear");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("IntakeCapacity");

                    b.Property<string>("ProgramsID");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("AcademicYearID");

                    b.HasIndex("ProgramsID");

                    b.ToTable("AcademicYear");
                });

            modelBuilder.Entity("AdmissionSystem.Models.ApplicationList", b =>
                {
                    b.Property<int>("ApplicationListID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcademicYearID");

                    b.Property<string>("ApplicationCategory")
                        .IsRequired();

                    b.Property<string>("PrioAreaOfResearch");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int?>("StudentID");

                    b.HasKey("ApplicationListID");

                    b.HasIndex("AcademicYearID");

                    b.HasIndex("StudentID");

                    b.ToTable("ApplicationList");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Documents", b =>
                {
                    b.Property<string>("DocumentsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DocumentPath");

                    b.Property<int?>("StudentID");

                    b.HasKey("DocumentsID");

                    b.HasIndex("StudentID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Fees", b =>
                {
                    b.Property<int>("FeesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcademicYearID");

                    b.Property<int>("FeesAmount");

                    b.Property<string>("FeesType")
                        .IsRequired();

                    b.HasKey("FeesID");

                    b.HasIndex("AcademicYearID");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Programs", b =>
                {
                    b.Property<string>("ProgramsID");

                    b.Property<string>("ProgramName")
                        .IsRequired();

                    b.HasKey("ProgramsID");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AadharNumber");

                    b.Property<string>("ApplicantsMobileNumber")
                        .IsRequired();

                    b.Property<string>("BloodGroup")
                        .IsRequired();

                    b.Property<string>("Caste");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<decimal>("FamilyIncome");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("GuardianMobileNumber")
                        .IsRequired();

                    b.Property<string>("GuradianOccupation")
                        .HasMaxLength(20);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("PHStatus")
                        .IsRequired();

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<string>("RelWithGuardian")
                        .IsRequired();

                    b.Property<string>("ResidencePhone");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("StudentAddress")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("StudentGuradianName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("StudentPhoto")
                        .IsRequired();

                    b.Property<string>("StudentSignature")
                        .IsRequired();

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AdmissionSystem.Models.AcademicRecord", b =>
                {
                    b.HasOne("AdmissionSystem.Models.Student", "Student")
                        .WithMany("AcademicRecords")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("AdmissionSystem.Models.AcademicYear", b =>
                {
                    b.HasOne("AdmissionSystem.Models.Programs", "Programs")
                        .WithMany("AcademicYears")
                        .HasForeignKey("ProgramsID");
                });

            modelBuilder.Entity("AdmissionSystem.Models.ApplicationList", b =>
                {
                    b.HasOne("AdmissionSystem.Models.AcademicYear", "AcademicYear")
                        .WithMany("ApplicationLists")
                        .HasForeignKey("AcademicYearID");

                    b.HasOne("AdmissionSystem.Models.Student", "Student")
                        .WithMany("ApplicationLists")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Documents", b =>
                {
                    b.HasOne("AdmissionSystem.Models.Student", "Student")
                        .WithMany("Documents")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("AdmissionSystem.Models.Fees", b =>
                {
                    b.HasOne("AdmissionSystem.Models.AcademicYear", "AcademicYear")
                        .WithMany()
                        .HasForeignKey("AcademicYearID");
                });
#pragma warning restore 612, 618
        }
    }
}
