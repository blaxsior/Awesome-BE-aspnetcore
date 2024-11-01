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
    [Migration("20241004051814_Fcfs_Add_PrizeInfo")]
    partial class Fcfs_Add_PrizeInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("domain.admin.AdminUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

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

                    b.HasIndex("EventUserId");

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

            modelBuilder.Entity("domain.eventcommon.EventMetadata", b =>
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

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.HasIndex("EventFrameId");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("EventMetadatas");
                });

            modelBuilder.Entity("domain.eventcommon.dto.EventFrame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("FrameId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FrameId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("FrameId")
                        .IsUnique();

                    b.ToTable("EventFrames");
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

                    b.Property<string>("PrizeInfo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("prize_info");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("domain.admin.AdminUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("domain.admin.AdminUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.admin.AdminUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("domain.admin.AdminUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("domain.comment.Comment", b =>
                {
                    b.HasOne("domain.eventcommon.dto.EventFrame", "EventFrame")
                        .WithMany()
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("domain.eventuser.EventUser", "EventUser")
                        .WithMany()
                        .HasForeignKey("EventUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");

                    b.Navigation("EventUser");
                });

            modelBuilder.Entity("domain.drawevent.DrawEvent", b =>
                {
                    b.HasOne("domain.eventcommon.EventMetadata", "EventMetadata")
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

            modelBuilder.Entity("domain.eventcommon.EventMetadata", b =>
                {
                    b.HasOne("domain.eventcommon.dto.EventFrame", "EventFrame")
                        .WithMany("EventMetadata")
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");
                });

            modelBuilder.Entity("domain.eventuser.EventUser", b =>
                {
                    b.HasOne("domain.eventcommon.dto.EventFrame", "EventFrame")
                        .WithMany()
                        .HasForeignKey("EventFrameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFrame");
                });

            modelBuilder.Entity("domain.fcfsevent.FcfsEvent", b =>
                {
                    b.HasOne("domain.eventcommon.EventMetadata", "EventMetadata")
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

            modelBuilder.Entity("domain.eventcommon.EventMetadata", b =>
                {
                    b.Navigation("DrawEvent");

                    b.Navigation("FcfsEvents");
                });

            modelBuilder.Entity("domain.eventcommon.dto.EventFrame", b =>
                {
                    b.Navigation("EventMetadata");
                });
#pragma warning restore 612, 618
        }
    }
}