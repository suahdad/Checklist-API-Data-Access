﻿// <auto-generated />
using System;
using EquipmentChecklistDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EquipmentChecklistDataAccess.Migrations
{
    [DbContext(typeof(EquipmentChecklistDBContext))]
    [Migration("20200416082401_FKNamingwithID_2.0")]
    partial class FKNamingwithID_20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Breakdown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("RTGFormId")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RTGFormId");

                    b.ToTable("Breakdowns");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Component", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Equipment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Issue", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.RTGForm", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("CreatedById")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("EquipmentId")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ModifiedById");

                    b.ToTable("RTGForms");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Remark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentId")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("IssueId")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("RTGFormId")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("IssueId");

                    b.HasIndex("RTGFormId");

                    b.ToTable("Remarks");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<bool>("isActive")
                        .HasColumnType("BIT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Breakdown", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.RTGForm", "RTGForm")
                        .WithMany("Breakdowns")
                        .HasForeignKey("RTGFormId");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.RTGForm", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("EquipmentChecklistDataAccess.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");

                    b.HasOne("EquipmentChecklistDataAccess.Models.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Remark", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentId");

                    b.HasOne("EquipmentChecklistDataAccess.Models.Issue", "Issue")
                        .WithMany()
                        .HasForeignKey("IssueId");

                    b.HasOne("EquipmentChecklistDataAccess.Models.RTGForm", "RTGForm")
                        .WithMany("Remarks")
                        .HasForeignKey("RTGFormId");
                });
#pragma warning restore 612, 618
        }
    }
}
