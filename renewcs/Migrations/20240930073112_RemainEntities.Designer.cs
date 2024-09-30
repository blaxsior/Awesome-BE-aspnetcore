﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using common.db;

#nullable disable

namespace renewcs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240930073112_RemainEntities")]
    partial class RemainEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("domain.comment.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<long>("EventFrameId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_frame_id");

                    b.Property<long>("EventUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_user_id");

                    b.HasKey("Id");

                    b.HasIndex("EventFrameId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("domain.drawevent.DrawEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EventMetadataId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_metadata_id");

                    b.Property<bool>("IsDrawn")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_drawn");

                    b.HasKey("Id");

                    b.HasIndex("EventMetadataId")
                        .IsUnique();

                    b.ToTable("DrawEvents");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventMetadata", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<long>("DrawEventId")
                        .HasColumnType("bigint")
                        .HasColumnName("draw_event_id");

                    b.Property<int>("Grade")
                        .HasColumnType("int")
                        .HasColumnName("grade");

                    b.Property<string>("PrizeInfo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("prize_info");

                    b.HasKey("Id");

                    b.HasIndex("DrawEventId");

                    b.ToTable("DrawEventMetadatas");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventParticipationInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("DrawEventId")
                        .HasColumnType("bigint")
                        .HasColumnName("draw_event_id");

                    b.Property<long>("EventUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_user_id");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.HasKey("Id");

                    b.HasIndex("DrawEventId");

                    b.HasIndex("EventUserId");

                    b.ToTable("DrawEventParticipationInfos");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventScorePolicy", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("action");

                    b.Property<long>("DrawEventId")
                        .HasColumnType("bigint")
                        .HasColumnName("draw_event_id");

                    b.Property<int>("Score")
                        .HasColumnType("int")
                        .HasColumnName("score");

                    b.HasKey("Id");

                    b.HasIndex("DrawEventId");

                    b.ToTable("DrawEventScorePolicies");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventWinningInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("DrawEventId")
                        .HasColumnType("bigint")
                        .HasColumnName("draw_event_id");

                    b.Property<long>("EventUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_user_id");

                    b.Property<int>("Ranking")
                        .HasColumnType("int")
                        .HasColumnName("ranking");

                    b.HasKey("Id");

                    b.HasIndex("DrawEventId");

                    b.HasIndex("EventUserId");

                    b.ToTable("DrawEventWinningInfos");
                });

            modelBuilder.Entity("domain.eventframe.EventFrame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("EventFrames");
                });

            modelBuilder.Entity("domain.eventmetadata.EventMetadata", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_time");

                    b.Property<long>("EventFrameId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_frame_id");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("event_id");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("event_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_time");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.HasIndex("EventFrameId");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("EventMetadatas");
                });

            modelBuilder.Entity("domain.eventuser.EventUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EventFrameId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_frame_id");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType(" varchar(30)")
                        .HasColumnName("phone_number");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("EventFrameId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("EventUsers");
                });

            modelBuilder.Entity("domain.fcfsevent.FcfsEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_time");

                    b.Property<long>("EventMetadataId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_metadata_id");

                    b.Property<int>("ParticipantCount")
                        .HasColumnType("int")
                        .HasColumnName("participant_count");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.HasIndex("EventMetadataId");

                    b.ToTable("FcfsEvents");
                });

            modelBuilder.Entity("domain.fcfsevent.FcfsEventWinningInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<long>("EventUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("event_user_id");

                    b.Property<long>("FcfsEventId")
                        .HasColumnType("bigint")
                        .HasColumnName("fcfs_event_id");

                    b.HasKey("Id");

                    b.HasIndex("EventUserId");

                    b.HasIndex("FcfsEventId");

                    b.ToTable("FcfsEventWinningInfos");
                });

            modelBuilder.Entity("domain.shorturl.ShortUrl", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("hash");

                    b.Property<string>("OriginalUrl")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("original_url");

                    b.HasKey("Id");

                    b.ToTable("ShortUrls");
                });

            modelBuilder.Entity("domain.comment.Comment", b =>
                {
                    b.HasOne("domain.eventframe.EventFrame", "EventFrame")
                        .WithMany()
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");
                });

            modelBuilder.Entity("domain.drawevent.DrawEvent", b =>
                {
                    b.HasOne("domain.eventmetadata.EventMetadata", "EventMetadata")
                        .WithOne("DrawEvent")
                        .HasForeignKey("domain.drawevent.DrawEvent", "EventMetadataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventMetadata");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventMetadata", b =>
                {
                    b.HasOne("domain.drawevent.DrawEvent", "DrawEvent")
                        .WithMany()
                        .HasForeignKey("DrawEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrawEvent");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventParticipationInfo", b =>
                {
                    b.HasOne("domain.drawevent.DrawEvent", "DrawEvent")
                        .WithMany()
                        .HasForeignKey("DrawEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.eventuser.EventUser", "EventUser")
                        .WithMany()
                        .HasForeignKey("EventUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrawEvent");

                    b.Navigation("EventUser");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventScorePolicy", b =>
                {
                    b.HasOne("domain.drawevent.DrawEvent", "DrawEvent")
                        .WithMany()
                        .HasForeignKey("DrawEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrawEvent");
                });

            modelBuilder.Entity("domain.drawevent.DrawEventWinningInfo", b =>
                {
                    b.HasOne("domain.drawevent.DrawEvent", "DrawEvent")
                        .WithMany()
                        .HasForeignKey("DrawEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.eventuser.EventUser", "EventUser")
                        .WithMany()
                        .HasForeignKey("EventUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DrawEvent");

                    b.Navigation("EventUser");
                });

            modelBuilder.Entity("domain.eventmetadata.EventMetadata", b =>
                {
                    b.HasOne("domain.eventframe.EventFrame", "EventFrame")
                        .WithMany("EventMetadata")
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");
                });

            modelBuilder.Entity("domain.eventuser.EventUser", b =>
                {
                    b.HasOne("domain.eventframe.EventFrame", "EventFrame")
                        .WithMany()
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");
                });

            modelBuilder.Entity("domain.fcfsevent.FcfsEvent", b =>
                {
                    b.HasOne("domain.eventmetadata.EventMetadata", "EventMetadata")
                        .WithMany("FcfsEvents")
                        .HasForeignKey("EventMetadataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventMetadata");
                });

            modelBuilder.Entity("domain.fcfsevent.FcfsEventWinningInfo", b =>
                {
                    b.HasOne("domain.eventuser.EventUser", "EventUser")
                        .WithMany()
                        .HasForeignKey("EventUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.fcfsevent.FcfsEvent", "FcfsEvent")
                        .WithMany()
                        .HasForeignKey("FcfsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventUser");

                    b.Navigation("FcfsEvent");
                });

            modelBuilder.Entity("domain.eventframe.EventFrame", b =>
                {
                    b.Navigation("EventMetadata");
                });

            modelBuilder.Entity("domain.eventmetadata.EventMetadata", b =>
                {
                    b.Navigation("DrawEvent");

                    b.Navigation("FcfsEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
