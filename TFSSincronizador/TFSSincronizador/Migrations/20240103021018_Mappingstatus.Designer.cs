﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFSSincronizador.Context;

#nullable disable

namespace TFSSincronizador.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240103021018_Mappingstatus")]
    partial class Mappingstatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TFSSincronizador.Models.JiraFields", b =>
                {
                    b.Property<int>("JiraFieldsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JiraFieldsId"), 1L, 1);

                    b.Property<string>("JiraFieldsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JiraFieldsId");

                    b.ToTable("JiraFields");
                });

            modelBuilder.Entity("TFSSincronizador.Models.JiraStatus", b =>
                {
                    b.Property<int>("JiraStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JiraStatusId"), 1L, 1);

                    b.Property<string>("JiraStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JiraStatusId");

                    b.ToTable("JiraStatus");
                });

            modelBuilder.Entity("TFSSincronizador.Models.JiraType", b =>
                {
                    b.Property<int>("JiraTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JiraTypeId"), 1L, 1);

                    b.Property<string>("JiraTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JiraTypeId");

                    b.ToTable("JiraTypes");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingField", b =>
                {
                    b.Property<int>("MappingFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingFieldId"), 1L, 1);

                    b.Property<int>("JiraFieldId")
                        .HasColumnType("int");

                    b.Property<int?>("JiraFieldsId")
                        .HasColumnType("int");

                    b.Property<int>("MappingFieldProfile")
                        .HasColumnType("int");

                    b.Property<int>("TFSFieldId")
                        .HasColumnType("int");

                    b.Property<int?>("TFSFieldsId")
                        .HasColumnType("int");

                    b.HasKey("MappingFieldId");

                    b.HasIndex("JiraFieldsId");

                    b.HasIndex("MappingFieldProfile");

                    b.HasIndex("TFSFieldsId");

                    b.ToTable("MappingFields");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingStatus", b =>
                {
                    b.Property<int>("MappingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingStatusId"), 1L, 1);

                    b.Property<int>("JiraStatusId")
                        .HasColumnType("int");

                    b.Property<string>("MappingDirection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MappingMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingStatusProfile")
                        .HasColumnType("int");

                    b.Property<int>("TFSStatusId")
                        .HasColumnType("int");

                    b.HasKey("MappingStatusId");

                    b.HasIndex("JiraStatusId");

                    b.HasIndex("MappingStatusProfile");

                    b.HasIndex("TFSStatusId");

                    b.ToTable("MappingStatuses");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingType", b =>
                {
                    b.Property<int>("MappingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MappingTypeId"), 1L, 1);

                    b.Property<int>("JiraTypeId")
                        .HasColumnType("int");

                    b.Property<string>("MappingDirection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MappingMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingTypeProfile")
                        .HasColumnType("int");

                    b.Property<int>("TFSTypeId")
                        .HasColumnType("int");

                    b.HasKey("MappingTypeId");

                    b.HasIndex("JiraTypeId");

                    b.HasIndex("MappingTypeProfile");

                    b.HasIndex("TFSTypeId");

                    b.ToTable("MappingTypes");
                });

            modelBuilder.Entity("TFSSincronizador.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<string>("JProject")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyncDirection")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TFSCollection")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TFSProject")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("TFSSincronizador.Models.ProfileConfiguration", b =>
                {
                    b.Property<int>("ConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigId"), 1L, 1);

                    b.Property<string>("APIToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Collection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JiraURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MappingFieldProfile")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TFSCustom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TFSProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TFSUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfigId");

                    b.HasIndex("MappingFieldProfile");

                    b.ToTable("ProfileConfig");
                });

            modelBuilder.Entity("TFSSincronizador.Models.TFSFields", b =>
                {
                    b.Property<int>("TFSFieldsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TFSFieldsId"), 1L, 1);

                    b.Property<string>("TFSFieldsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TFSFieldsId");

                    b.ToTable("TFSFields");
                });

            modelBuilder.Entity("TFSSincronizador.Models.TFSStatus", b =>
                {
                    b.Property<int>("TFSStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TFSStatusId"), 1L, 1);

                    b.Property<string>("TFSStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TFSStatusId");

                    b.ToTable("TFSStatus");
                });

            modelBuilder.Entity("TFSSincronizador.Models.TFSType", b =>
                {
                    b.Property<int>("TFSTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TFSTypeId"), 1L, 1);

                    b.Property<string>("TFSTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TFSTypeId");

                    b.ToTable("TFSTypes");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingField", b =>
                {
                    b.HasOne("TFSSincronizador.Models.JiraFields", "JiraFields")
                        .WithMany()
                        .HasForeignKey("JiraFieldsId");

                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingFields")
                        .HasForeignKey("MappingFieldProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFSSincronizador.Models.TFSFields", "TFSFields")
                        .WithMany()
                        .HasForeignKey("TFSFieldsId");

                    b.Navigation("JiraFields");

                    b.Navigation("Profile");

                    b.Navigation("TFSFields");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingStatus", b =>
                {
                    b.HasOne("TFSSincronizador.Models.JiraStatus", "JiraStatus")
                        .WithMany()
                        .HasForeignKey("JiraStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingStatuses")
                        .HasForeignKey("MappingStatusProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFSSincronizador.Models.TFSStatus", "TFSStatus")
                        .WithMany()
                        .HasForeignKey("TFSStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JiraStatus");

                    b.Navigation("Profile");

                    b.Navigation("TFSStatus");
                });

            modelBuilder.Entity("TFSSincronizador.Models.MappingType", b =>
                {
                    b.HasOne("TFSSincronizador.Models.JiraType", "JiraType")
                        .WithMany()
                        .HasForeignKey("JiraTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany("MappingTypes")
                        .HasForeignKey("MappingTypeProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFSSincronizador.Models.TFSType", "TFSType")
                        .WithMany()
                        .HasForeignKey("TFSTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JiraType");

                    b.Navigation("Profile");

                    b.Navigation("TFSType");
                });

            modelBuilder.Entity("TFSSincronizador.Models.ProfileConfiguration", b =>
                {
                    b.HasOne("TFSSincronizador.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("MappingFieldProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("TFSSincronizador.Models.Profile", b =>
                {
                    b.Navigation("MappingFields");

                    b.Navigation("MappingStatuses");

                    b.Navigation("MappingTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
