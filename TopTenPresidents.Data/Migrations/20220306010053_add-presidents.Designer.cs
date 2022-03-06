﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopTenPresidents.Data.DbContexts;

#nullable disable

namespace TopTenPresidents.Data.Migrations
{
    [DbContext(typeof(TopTenPresidentsDbContext))]
    [Migration("20220306010053_add-presidents")]
    partial class addpresidents
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Name", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Office", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"), 1L, 1);

                    b.Property<string>("PolicitalParty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<short>("PresidentNameId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("PresidentNameId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Term", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"), 1L, 1);

                    b.Property<short>("ElectionNumber")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("InaugurationDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("LastDayInOffice")
                        .HasColumnType("date");

                    b.Property<short>("OfficeId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Terms");
                });

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Office", b =>
                {
                    b.HasOne("TopTenPresidents.Data.Entities.Name", "PresidentName")
                        .WithMany()
                        .HasForeignKey("PresidentNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PresidentName");
                });

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Term", b =>
                {
                    b.HasOne("TopTenPresidents.Data.Entities.Office", "Office")
                        .WithMany("Terms")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });

            modelBuilder.Entity("TopTenPresidents.Data.Entities.Office", b =>
                {
                    b.Navigation("Terms");
                });
#pragma warning restore 612, 618
        }
    }
}
