﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("API.Models.AnswerOptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerOptions");
                });

            modelBuilder.Entity("API.Models.QuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageSource")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("API.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("API.Models.SolveRunModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("SolveRunModels");
                });

            modelBuilder.Entity("QuestionModelSolveRunModel", b =>
                {
                    b.Property<int>("QuestionRunId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SolveRunsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionRunId", "SolveRunsId");

                    b.HasIndex("SolveRunsId");

                    b.ToTable("QuestionModelSolveRunModel");
                });

            modelBuilder.Entity("API.Models.AnswerOptionModel", b =>
                {
                    b.HasOne("API.Models.QuestionModel", "Question")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("API.Models.QuestionModel", b =>
                {
                    b.HasOne("API.Models.RoomModel", "Room")
                        .WithMany("Questions")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("API.Models.SolveRunModel", b =>
                {
                    b.HasOne("API.Models.RoomModel", "Room")
                        .WithMany("SolveRuns")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("QuestionModelSolveRunModel", b =>
                {
                    b.HasOne("API.Models.QuestionModel", null)
                        .WithMany()
                        .HasForeignKey("QuestionRunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.SolveRunModel", null)
                        .WithMany()
                        .HasForeignKey("SolveRunsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.QuestionModel", b =>
                {
                    b.Navigation("AnswerOptions");
                });

            modelBuilder.Entity("API.Models.RoomModel", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("SolveRuns");
                });
#pragma warning restore 612, 618
        }
    }
}
