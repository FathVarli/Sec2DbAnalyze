﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sec2DbAnalyze.Persistence.Context;

namespace Sec2DbAnalyze.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20240516132835_TestMig2")]
    partial class TestMig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Column10")
                        .HasColumnType("text");

                    b.Property<string>("Column11")
                        .HasColumnType("text");

                    b.Property<string>("Column12")
                        .HasColumnType("text");

                    b.Property<string>("Column13")
                        .HasColumnType("text");

                    b.Property<string>("Column14")
                        .HasColumnType("text");

                    b.Property<string>("Column15")
                        .HasColumnType("text");

                    b.Property<string>("Column16")
                        .HasColumnType("text");

                    b.Property<string>("Column17")
                        .HasColumnType("text");

                    b.Property<string>("Column18")
                        .HasColumnType("text");

                    b.Property<string>("Column19")
                        .HasColumnType("text");

                    b.Property<string>("Column2")
                        .HasColumnType("text");

                    b.Property<string>("Column20")
                        .HasColumnType("text");

                    b.Property<string>("Column21")
                        .HasColumnType("text");

                    b.Property<string>("Column22")
                        .HasColumnType("text");

                    b.Property<string>("Column23")
                        .HasColumnType("text");

                    b.Property<string>("Column24")
                        .HasColumnType("text");

                    b.Property<string>("Column25")
                        .HasColumnType("text");

                    b.Property<string>("Column26")
                        .HasColumnType("text");

                    b.Property<string>("Column27")
                        .HasColumnType("text");

                    b.Property<string>("Column28")
                        .HasColumnType("text");

                    b.Property<string>("Column29")
                        .HasColumnType("text");

                    b.Property<string>("Column3")
                        .HasColumnType("text");

                    b.Property<string>("Column30")
                        .HasColumnType("text");

                    b.Property<string>("Column31")
                        .HasColumnType("text");

                    b.Property<string>("Column32")
                        .HasColumnType("text");

                    b.Property<string>("Column33")
                        .HasColumnType("text");

                    b.Property<string>("Column34")
                        .HasColumnType("text");

                    b.Property<string>("Column35")
                        .HasColumnType("text");

                    b.Property<string>("Column36")
                        .HasColumnType("text");

                    b.Property<string>("Column37")
                        .HasColumnType("text");

                    b.Property<string>("Column38")
                        .HasColumnType("text");

                    b.Property<string>("Column39")
                        .HasColumnType("text");

                    b.Property<string>("Column4")
                        .HasColumnType("text");

                    b.Property<string>("Column40")
                        .HasColumnType("text");

                    b.Property<string>("Column41")
                        .HasColumnType("text");

                    b.Property<string>("Column42")
                        .HasColumnType("text");

                    b.Property<string>("Column43")
                        .HasColumnType("text");

                    b.Property<string>("Column44")
                        .HasColumnType("text");

                    b.Property<string>("Column45")
                        .HasColumnType("text");

                    b.Property<string>("Column46")
                        .HasColumnType("text");

                    b.Property<string>("Column47")
                        .HasColumnType("text");

                    b.Property<string>("Column48")
                        .HasColumnType("text");

                    b.Property<string>("Column49")
                        .HasColumnType("text");

                    b.Property<string>("Column5")
                        .HasColumnType("text");

                    b.Property<string>("Column50")
                        .HasColumnType("text");

                    b.Property<string>("Column51")
                        .HasColumnType("text");

                    b.Property<string>("Column52")
                        .HasColumnType("text");

                    b.Property<string>("Column53")
                        .HasColumnType("text");

                    b.Property<string>("Column54")
                        .HasColumnType("text");

                    b.Property<string>("Column55")
                        .HasColumnType("text");

                    b.Property<string>("Column56")
                        .HasColumnType("text");

                    b.Property<string>("Column57")
                        .HasColumnType("text");

                    b.Property<string>("Column58")
                        .HasColumnType("text");

                    b.Property<string>("Column59")
                        .HasColumnType("text");

                    b.Property<string>("Column6")
                        .HasColumnType("text");

                    b.Property<string>("Column60")
                        .HasColumnType("text");

                    b.Property<string>("Column61")
                        .HasColumnType("text");

                    b.Property<string>("Column62")
                        .HasColumnType("text");

                    b.Property<string>("Column7")
                        .HasColumnType("text");

                    b.Property<string>("Column8")
                        .HasColumnType("text");

                    b.Property<string>("Column9")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Identity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Column10")
                        .HasColumnType("text");

                    b.Property<string>("Column11")
                        .HasColumnType("text");

                    b.Property<string>("Column12")
                        .HasColumnType("text");

                    b.Property<string>("Column13")
                        .HasColumnType("text");

                    b.Property<string>("Column14")
                        .HasColumnType("text");

                    b.Property<string>("Column2")
                        .HasColumnType("text");

                    b.Property<string>("Column3")
                        .HasColumnType("text");

                    b.Property<string>("Column4")
                        .HasColumnType("text");

                    b.Property<string>("Column5")
                        .HasColumnType("text");

                    b.Property<string>("Column6")
                        .HasColumnType("text");

                    b.Property<string>("Column7")
                        .HasColumnType("text");

                    b.Property<string>("Column8")
                        .HasColumnType("text");

                    b.Property<string>("Column9")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdentitySectionId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdentitySectionId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.IdentitySection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Column15")
                        .HasColumnType("text");

                    b.Property<string>("Column16")
                        .HasColumnType("text");

                    b.Property<string>("Column17")
                        .HasColumnType("text");

                    b.Property<string>("Column18")
                        .HasColumnType("text");

                    b.Property<string>("Column19")
                        .HasColumnType("text");

                    b.Property<string>("Column20")
                        .HasColumnType("text");

                    b.Property<string>("Column21")
                        .HasColumnType("text");

                    b.Property<string>("Column22")
                        .HasColumnType("text");

                    b.Property<string>("Column23")
                        .HasColumnType("text");

                    b.Property<string>("Column24")
                        .HasColumnType("text");

                    b.Property<string>("Column25")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IdentitySections");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<long>("TotalTimeMs")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<string>("Column10")
                        .HasColumnType("text");

                    b.Property<string>("Column11")
                        .HasColumnType("text");

                    b.Property<string>("Column12")
                        .HasColumnType("text");

                    b.Property<string>("Column13")
                        .HasColumnType("text");

                    b.Property<string>("Column14")
                        .HasColumnType("text");

                    b.Property<string>("Column15")
                        .HasColumnType("text");

                    b.Property<string>("Column16")
                        .HasColumnType("text");

                    b.Property<string>("Column17")
                        .HasColumnType("text");

                    b.Property<string>("Column18")
                        .HasColumnType("text");

                    b.Property<string>("Column19")
                        .HasColumnType("text");

                    b.Property<string>("Column2")
                        .HasColumnType("text");

                    b.Property<string>("Column20")
                        .HasColumnType("text");

                    b.Property<string>("Column21")
                        .HasColumnType("text");

                    b.Property<string>("Column22")
                        .HasColumnType("text");

                    b.Property<string>("Column23")
                        .HasColumnType("text");

                    b.Property<string>("Column24")
                        .HasColumnType("text");

                    b.Property<string>("Column25")
                        .HasColumnType("text");

                    b.Property<string>("Column26")
                        .HasColumnType("text");

                    b.Property<string>("Column27")
                        .HasColumnType("text");

                    b.Property<string>("Column28")
                        .HasColumnType("text");

                    b.Property<string>("Column29")
                        .HasColumnType("text");

                    b.Property<string>("Column3")
                        .HasColumnType("text");

                    b.Property<string>("Column30")
                        .HasColumnType("text");

                    b.Property<string>("Column31")
                        .HasColumnType("text");

                    b.Property<string>("Column32")
                        .HasColumnType("text");

                    b.Property<string>("Column33")
                        .HasColumnType("text");

                    b.Property<string>("Column34")
                        .HasColumnType("text");

                    b.Property<string>("Column35")
                        .HasColumnType("text");

                    b.Property<string>("Column36")
                        .HasColumnType("text");

                    b.Property<string>("Column37")
                        .HasColumnType("text");

                    b.Property<string>("Column38")
                        .HasColumnType("text");

                    b.Property<string>("Column39")
                        .HasColumnType("text");

                    b.Property<string>("Column4")
                        .HasColumnType("text");

                    b.Property<string>("Column40")
                        .HasColumnType("text");

                    b.Property<string>("Column41")
                        .HasColumnType("text");

                    b.Property<string>("Column42")
                        .HasColumnType("text");

                    b.Property<string>("Column43")
                        .HasColumnType("text");

                    b.Property<string>("Column44")
                        .HasColumnType("text");

                    b.Property<string>("Column45")
                        .HasColumnType("text");

                    b.Property<string>("Column46")
                        .HasColumnType("text");

                    b.Property<string>("Column47")
                        .HasColumnType("text");

                    b.Property<string>("Column48")
                        .HasColumnType("text");

                    b.Property<string>("Column49")
                        .HasColumnType("text");

                    b.Property<string>("Column5")
                        .HasColumnType("text");

                    b.Property<string>("Column50")
                        .HasColumnType("text");

                    b.Property<string>("Column51")
                        .HasColumnType("text");

                    b.Property<string>("Column52")
                        .HasColumnType("text");

                    b.Property<string>("Column53")
                        .HasColumnType("text");

                    b.Property<string>("Column54")
                        .HasColumnType("text");

                    b.Property<string>("Column55")
                        .HasColumnType("text");

                    b.Property<string>("Column56")
                        .HasColumnType("text");

                    b.Property<string>("Column6")
                        .HasColumnType("text");

                    b.Property<string>("Column7")
                        .HasColumnType("text");

                    b.Property<string>("Column8")
                        .HasColumnType("text");

                    b.Property<string>("Column9")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ApiKey")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Column10")
                        .HasColumnType("text");

                    b.Property<string>("Column11")
                        .HasColumnType("text");

                    b.Property<string>("Column12")
                        .HasColumnType("text");

                    b.Property<string>("Column13")
                        .HasColumnType("text");

                    b.Property<string>("Column14")
                        .HasColumnType("text");

                    b.Property<string>("Column2")
                        .HasColumnType("text");

                    b.Property<string>("Column3")
                        .HasColumnType("text");

                    b.Property<string>("Column4")
                        .HasColumnType("text");

                    b.Property<string>("Column5")
                        .HasColumnType("text");

                    b.Property<string>("Column6")
                        .HasColumnType("text");

                    b.Property<string>("Column7")
                        .HasColumnType("text");

                    b.Property<string>("Column8")
                        .HasColumnType("text");

                    b.Property<string>("Column9")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserSectionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserProfileId");

                    b.HasIndex("UserSectionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Column27")
                        .HasColumnType("text");

                    b.Property<string>("Column28")
                        .HasColumnType("text");

                    b.Property<string>("Column29")
                        .HasColumnType("text");

                    b.Property<string>("Column30")
                        .HasColumnType("text");

                    b.Property<string>("Column31")
                        .HasColumnType("text");

                    b.Property<string>("Column32")
                        .HasColumnType("text");

                    b.Property<string>("Column33")
                        .HasColumnType("text");

                    b.Property<string>("Column34")
                        .HasColumnType("text");

                    b.Property<string>("Column35")
                        .HasColumnType("text");

                    b.Property<string>("Column36")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.UserSection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Column15")
                        .HasColumnType("text");

                    b.Property<string>("Column16")
                        .HasColumnType("text");

                    b.Property<string>("Column17")
                        .HasColumnType("text");

                    b.Property<string>("Column18")
                        .HasColumnType("text");

                    b.Property<string>("Column19")
                        .HasColumnType("text");

                    b.Property<string>("Column20")
                        .HasColumnType("text");

                    b.Property<string>("Column21")
                        .HasColumnType("text");

                    b.Property<string>("Column22")
                        .HasColumnType("text");

                    b.Property<string>("Column23")
                        .HasColumnType("text");

                    b.Property<string>("Column24")
                        .HasColumnType("text");

                    b.Property<string>("Column25")
                        .HasColumnType("text");

                    b.Property<string>("Column26")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserSections");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Identity", b =>
                {
                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.IdentitySection", "IdentitySection")
                        .WithMany()
                        .HasForeignKey("IdentitySectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.User", "User")
                        .WithMany("Identities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentitySection");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.Service", b =>
                {
                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.User", b =>
                {
                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sec2DbAnalyze.Domain.Concrete.UserSection", "UserSection")
                        .WithMany()
                        .HasForeignKey("UserSectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("UserProfile");

                    b.Navigation("UserSection");
                });

            modelBuilder.Entity("Sec2DbAnalyze.Domain.Concrete.User", b =>
                {
                    b.Navigation("Identities");
                });
#pragma warning restore 612, 618
        }
    }
}
