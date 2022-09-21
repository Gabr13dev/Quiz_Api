﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApi.Context;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuizApi.Models.Game", b =>
                {
                    b.Property<int>("IdGame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdGame");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("QuizApi.Models.Option", b =>
                {
                    b.Property<int>("IdOption")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdQuestion")
                        .HasColumnType("int");

                    b.Property<string>("TitleOption")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdOption");

                    b.HasIndex("IdQuestion");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.Property<int>("IdQuestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("GameIdGame")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdQuestion");

                    b.HasIndex("GameIdGame");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("QuizApi.Models.Session", b =>
                {
                    b.Property<Guid>("IdSession")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("IdGame")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("IdSession");

                    b.HasIndex("IdGame");

                    b.HasIndex("IdUser");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("QuizApi.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("QuizApi.Models.Option", b =>
                {
                    b.HasOne("QuizApi.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("IdQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizApi.Models.Question", b =>
                {
                    b.HasOne("QuizApi.Models.Game", null)
                        .WithMany("Questions")
                        .HasForeignKey("GameIdGame");
                });

            modelBuilder.Entity("QuizApi.Models.Session", b =>
                {
                    b.HasOne("QuizApi.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("IdGame")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuizApi.Models.Game", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
