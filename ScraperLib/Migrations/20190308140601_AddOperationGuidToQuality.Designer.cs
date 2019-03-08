﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using ScraperLib.DAL;

namespace ScraperLib.Migrations
{
    [DbContext(typeof(ScraperDbContext))]
    [Migration("20190308140601_AddOperationGuidToQuality")]
    partial class AddOperationGuidToQuality
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScraperLib.Models.Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageTemperature");

                    b.Property<double>("Length");

                    b.Property<int>("MarkerId");

                    b.Property<double>("MaxSalinity");

                    b.Property<double>("MinSalinity");

                    b.Property<string>("Shape")
                        .HasMaxLength(100);

                    b.Property<string>("SurfaceType")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<string>("Vegetation")
                        .HasMaxLength(100);

                    b.Property<double>("Width");

                    b.Property<string>("Wind")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("MarkerId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("ScraperLib.Models.Marker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int>("DataId");

                    b.Property<Point>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Markers");
                });

            modelBuilder.Entity("ScraperLib.Models.Quality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("MarkerId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("MarkerId");

                    b.ToTable("Qualities");
                });

            modelBuilder.Entity("ScraperLib.Models.QualityForUpdate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("MarkerId");

                    b.Property<Guid>("OperationGuid");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("QualitiesForUpdate");
                });

            modelBuilder.Entity("ScraperLib.Models.Details", b =>
                {
                    b.HasOne("ScraperLib.Models.Marker", "Marker")
                        .WithMany("Details")
                        .HasForeignKey("MarkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScraperLib.Models.Quality", b =>
                {
                    b.HasOne("ScraperLib.Models.Marker", "Marker")
                        .WithMany("Qualities")
                        .HasForeignKey("MarkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
