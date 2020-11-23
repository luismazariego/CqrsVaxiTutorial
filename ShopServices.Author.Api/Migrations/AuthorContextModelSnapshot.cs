﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopServices.Author.Api.Persistence;

namespace ShopServices.Author.Api.Migrations
{
    [DbContext(typeof(AuthorContext))]
    partial class AuthorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ShopServices.Author.Api.Models.AcademicDegree", b =>
                {
                    b.Property<int>("AcademicDegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AcademicCenter")
                        .HasColumnType("text");

                    b.Property<DateTime?>("AcademicDegreeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("AcademicDegreeGuid")
                        .HasColumnType("text");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("AcademicDegreeId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AcademicDegrees");
                });

            modelBuilder.Entity("ShopServices.Author.Api.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AuthorGuid")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ShopServices.Author.Api.Models.AcademicDegree", b =>
                {
                    b.HasOne("ShopServices.Author.Api.Models.Author", "Author")
                        .WithMany("AcademicDegrees")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ShopServices.Author.Api.Models.Author", b =>
                {
                    b.Navigation("AcademicDegrees");
                });
#pragma warning restore 612, 618
        }
    }
}
