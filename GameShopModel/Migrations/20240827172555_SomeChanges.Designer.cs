﻿// <auto-generated />
using System;
using GameShopModel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameShopModel.Migrations
{
    [DbContext(typeof(GameShopContext))]
    [Migration("20240827172555_SomeChanges")]
    partial class SomeChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameProductGenre", b =>
                {
                    b.Property<int>("GameProductsId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("GameProductsId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameProductGenre");
                });

            modelBuilder.Entity("GameShopModel.Entities.GameProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimumSystemRequirementId")
                        .HasColumnType("int");

                    b.Property<string>("PresentationImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RecommendedSystemRequirementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MinimumSystemRequirementId");

                    b.HasIndex("RecommendedSystemRequirementId");

                    b.ToTable("GameProducts");
                });

            modelBuilder.Entity("GameShopModel.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("GameShopModel.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GameProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("GameShopModel.Entities.MinimumSystemRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Additionally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiskSpace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Network")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RandomAccessMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MinimumSystemRequirements");
                });

            modelBuilder.Entity("GameShopModel.Entities.RecommendedSystemRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Additionally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiskSpace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Network")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RandomAccessMemory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecommendedSystemRequirements");
                });

            modelBuilder.Entity("GameShopModel.Entities.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GameProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameProductId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("GameProductGenre", b =>
                {
                    b.HasOne("GameShopModel.Entities.GameProduct", null)
                        .WithMany()
                        .HasForeignKey("GameProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameShopModel.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameShopModel.Entities.GameProduct", b =>
                {
                    b.HasOne("GameShopModel.Entities.MinimumSystemRequirement", "MinimumSystemRequirement")
                        .WithMany()
                        .HasForeignKey("MinimumSystemRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameShopModel.Entities.RecommendedSystemRequirement", "RecommendedSystemRequirement")
                        .WithMany()
                        .HasForeignKey("RecommendedSystemRequirementId");

                    b.Navigation("MinimumSystemRequirement");

                    b.Navigation("RecommendedSystemRequirement");
                });

            modelBuilder.Entity("GameShopModel.Entities.Image", b =>
                {
                    b.HasOne("GameShopModel.Entities.GameProduct", null)
                        .WithMany("Images")
                        .HasForeignKey("GameProductId");
                });

            modelBuilder.Entity("GameShopModel.Entities.Video", b =>
                {
                    b.HasOne("GameShopModel.Entities.GameProduct", null)
                        .WithMany("Videos")
                        .HasForeignKey("GameProductId");
                });

            modelBuilder.Entity("GameShopModel.Entities.GameProduct", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
