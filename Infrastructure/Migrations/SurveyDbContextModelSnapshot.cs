﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineSurvey.Infrastructure;

#nullable disable

namespace OnlineSurvey.Infrastructure.Migrations
{
    [DbContext(typeof(SurveyDbContext))]
    partial class SurveyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Interview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ParticipantName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("SurveyId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("SurveyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Result", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AnswerId")
                        .HasColumnType("bigint");

                    b.Property<long>("InterviewId")
                        .HasColumnType("bigint");

                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("InterviewId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Survey", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Answer", b =>
                {
                    b.HasOne("OnlineSurvey.Domain.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Interview", b =>
                {
                    b.HasOne("OnlineSurvey.Domain.Entities.Survey", "Survey")
                        .WithMany("Interviews")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Question", b =>
                {
                    b.HasOne("OnlineSurvey.Domain.Entities.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Result", b =>
                {
                    b.HasOne("OnlineSurvey.Domain.Entities.Answer", "Answer")
                        .WithMany("Results")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSurvey.Domain.Entities.Interview", "Interview")
                        .WithMany("Results")
                        .HasForeignKey("InterviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineSurvey.Domain.Entities.Question", "Question")
                        .WithMany("Results")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Interview");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Answer", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Interview", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("OnlineSurvey.Domain.Entities.Survey", b =>
                {
                    b.Navigation("Interviews");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}