﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webenglishfinal.Models;

#nullable disable

namespace Webenglishfinal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Webenglishfinal.Models.Account", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Catalouge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbols")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("catalouges");
                });

            modelBuilder.Entity("Webenglishfinal.Models.DetailGradeAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountusername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("gradeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idGrade")
                        .HasColumnType("int");

                    b.Property<int>("isActive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("accountusername");

                    b.HasIndex("gradeId");

                    b.ToTable("detailGradeAccounts");
                });

            modelBuilder.Entity("Webenglishfinal.Models.DetailRoleAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accountusername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("accountusername");

                    b.HasIndex("roleId");

                    b.ToTable("detailRoleAccounts");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Exercise", b =>
                {
                    b.Property<int>("IdExe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExe"), 1L, 1);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idTest")
                        .HasColumnType("int");

                    b.Property<int>("idTypeofExe")
                        .HasColumnType("int");

                    b.Property<int>("mark")
                        .HasColumnType("int");

                    b.Property<int>("passpercent")
                        .HasColumnType("int");

                    b.Property<int>("testIdTest")
                        .HasColumnType("int");

                    b.Property<int>("typeofExeIdType")
                        .HasColumnType("int");

                    b.HasKey("IdExe");

                    b.HasIndex("testIdTest");

                    b.HasIndex("typeofExeIdType");

                    b.ToTable("exercise");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Grade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("isActive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("Webenglishfinal.Models.IncorrectSen", b =>
                {
                    b.Property<int>("idSentences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSentences"), 1L, 1);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idReport")
                        .HasColumnType("int");

                    b.Property<int>("reportidReport")
                        .HasColumnType("int");

                    b.HasKey("idSentences");

                    b.HasIndex("reportidReport");

                    b.ToTable("incorrectSens");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Lesson", b =>
                {
                    b.Property<int>("IdLesson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLesson"), 1L, 1);

                    b.Property<DateTime>("DateTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatetimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gradeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idGrade")
                        .HasColumnType("int");

                    b.Property<int>("isActive")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<string>("nameLesson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLesson");

                    b.HasIndex("gradeId");

                    b.ToTable("lessons");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Rank", b =>
                {
                    b.Property<int>("idRank")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idRank"), 1L, 1);

                    b.Property<string>("accountusername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("mark")
                        .HasColumnType("real");

                    b.Property<long>("ranknumber")
                        .HasColumnType("bigint");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRank");

                    b.HasIndex("accountusername");

                    b.ToTable("ranks");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Recommand", b =>
                {
                    b.Property<int>("IdRecommand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRecommand"), 1L, 1);

                    b.Property<int>("idTest")
                        .HasColumnType("int");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRecommand");

                    b.ToTable("recommands");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Report", b =>
                {
                    b.Property<int>("idReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idReport"), 1L, 1);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datesend")
                        .HasColumnType("datetime2");

                    b.Property<int>("idStatus")
                        .HasColumnType("int");

                    b.Property<int>("statusIdstatus")
                        .HasColumnType("int");

                    b.HasKey("idReport");

                    b.HasIndex("statusIdstatus");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Status", b =>
                {
                    b.Property<int>("Idstatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idstatus"), 1L, 1);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountusername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idTest")
                        .HasColumnType("int");

                    b.Property<int>("mark")
                        .HasColumnType("int");

                    b.Property<int>("testIdTest")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("timeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Idstatus");

                    b.HasIndex("accountusername");

                    b.HasIndex("testIdTest");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Test", b =>
                {
                    b.Property<int>("IdTest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTest"), 1L, 1);

                    b.Property<int>("idLesson")
                        .HasColumnType("int");

                    b.Property<int>("lessonIdLesson")
                        .HasColumnType("int");

                    b.Property<int>("markpass")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTest");

                    b.HasIndex("lessonIdLesson");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("Webenglishfinal.Models.TypeofExe", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdType"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdType");

                    b.ToTable("typeofExes");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webenglishfinal.Models.DetailGradeAccount", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountusername");

                    b.HasOne("Webenglishfinal.Models.Grade", "grade")
                        .WithMany()
                        .HasForeignKey("gradeId");

                    b.Navigation("account");

                    b.Navigation("grade");
                });

            modelBuilder.Entity("Webenglishfinal.Models.DetailRoleAccount", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountusername");

                    b.HasOne("Webenglishfinal.Models.Role", "role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Exercise", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Test", "test")
                        .WithMany()
                        .HasForeignKey("testIdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webenglishfinal.Models.TypeofExe", "typeofExe")
                        .WithMany()
                        .HasForeignKey("typeofExeIdType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("test");

                    b.Navigation("typeofExe");
                });

            modelBuilder.Entity("Webenglishfinal.Models.IncorrectSen", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Report", "report")
                        .WithMany()
                        .HasForeignKey("reportidReport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("report");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Lesson", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Grade", "grade")
                        .WithMany()
                        .HasForeignKey("gradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grade");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Rank", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountusername");

                    b.Navigation("account");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Report", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Status", "status")
                        .WithMany()
                        .HasForeignKey("statusIdstatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("status");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Status", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountusername");

                    b.HasOne("Webenglishfinal.Models.Test", "test")
                        .WithMany()
                        .HasForeignKey("testIdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("test");
                });

            modelBuilder.Entity("Webenglishfinal.Models.Test", b =>
                {
                    b.HasOne("Webenglishfinal.Models.Lesson", "lesson")
                        .WithMany()
                        .HasForeignKey("lessonIdLesson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lesson");
                });
#pragma warning restore 612, 618
        }
    }
}
