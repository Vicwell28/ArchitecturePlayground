﻿// <auto-generated />
using ArchitecturePlayground.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArchitecturePlayground.Data.Migrations
{
    [DbContext(typeof(ArchitecturePlaygroundDbContext))]
    [Migration("20250109021747_AddMoreEntities")]
    partial class AddMoreEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArchitecturePlayground.Domain.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Streamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Streamers");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int?>("StreamerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("StreamerId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.VideoActor", b =>
                {
                    b.Property<int>("VideoId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("VideoId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("VideoActor");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Video", b =>
                {
                    b.HasOne("ArchitecturePlayground.Domain.Director", "Director")
                        .WithMany("Videos")
                        .HasForeignKey("DirectorId");

                    b.HasOne("ArchitecturePlayground.Domain.Streamer", "Streamer")
                        .WithMany("Videos")
                        .HasForeignKey("StreamerId");

                    b.Navigation("Director");

                    b.Navigation("Streamer");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.VideoActor", b =>
                {
                    b.HasOne("ArchitecturePlayground.Domain.Actor", "Actor")
                        .WithMany("Videos")
                        .HasForeignKey("ActorId")
                        .IsRequired();

                    b.HasOne("ArchitecturePlayground.Domain.Video", "Video")
                        .WithMany("Actors")
                        .HasForeignKey("VideoId")
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Actor", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Director", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Streamer", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("ArchitecturePlayground.Domain.Video", b =>
                {
                    b.Navigation("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}
