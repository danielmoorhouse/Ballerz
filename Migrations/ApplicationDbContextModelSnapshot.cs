﻿// <auto-generated />
using System;
using Ballerz.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ballerz.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Ballerz.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Ballerz.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime>("MemberSince");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileImageUrl");

                    b.Property<int>("Rating");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TeamId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ballerz.Data.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountriesId");

                    b.Property<int>("CountryId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Location");

                    b.Property<DateTime>("MemberSince");

                    b.Property<string>("ProfileImageUrl");

                    b.Property<string>("ShortDescription");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TeamsId");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserRating");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("TeamsId");

                    b.HasIndex("UserId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Ballerz.Forums.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("Ballerz.Forums.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("ForumId");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Ballerz.Forums.Models.PostReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("PostId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostReplies");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.ClubHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LeagueName");

                    b.Property<int?>("LeaguesId");

                    b.Property<string>("Points");

                    b.Property<string>("Position");

                    b.Property<string>("Season");

                    b.Property<int?>("SeasonsId");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TeamsId");

                    b.HasKey("Id");

                    b.HasIndex("LeaguesId");

                    b.HasIndex("SeasonsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("ClubHistories");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FlagUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Leagues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountriesId");

                    b.Property<int>("CountryId");

                    b.Property<string>("LeagueImageUrl");

                    b.Property<string>("LeagueName");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Managers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthPlace");

                    b.Property<int?>("CountriesId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("ManagerImageUrl");

                    b.Property<string>("ManagerName");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TeamsId");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("TeamsId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Players", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birthplace");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("PlayerImageUrl");

                    b.Property<string>("PlayerName");

                    b.Property<string>("Position");

                    b.Property<int>("PositionId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Positions", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Position");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Seasons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Season");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Stadiums", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("BuiltIn");

                    b.Property<string>("Capacity");

                    b.Property<int?>("CountriesId");

                    b.Property<int>("CountryId");

                    b.Property<string>("ImageUrl1");

                    b.Property<string>("ImageUrl2");

                    b.Property<string>("PostCode");

                    b.Property<string>("StadiumName");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TeamsId");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.HasIndex("TeamsId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LeagueId");

                    b.Property<string>("LeagueName");

                    b.Property<int?>("LeaguesId");

                    b.Property<string>("Nickname");

                    b.Property<string>("TeamBadgeUrl");

                    b.Property<string>("TeamName");

                    b.Property<string>("YearFounded");

                    b.HasKey("Id");

                    b.HasIndex("LeaguesId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ballerz.Data.Models.Profile", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId");

                    b.HasOne("Ballerz.KnowledgeBase.Models.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId");

                    b.HasOne("Ballerz.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ballerz.Forums.Models.Post", b =>
                {
                    b.HasOne("Ballerz.Forums.Models.Forum", "Forum")
                        .WithMany("Posts")
                        .HasForeignKey("ForumId");

                    b.HasOne("Ballerz.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ballerz.Forums.Models.PostReply", b =>
                {
                    b.HasOne("Ballerz.Forums.Models.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId");

                    b.HasOne("Ballerz.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.ClubHistory", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Leagues", "Leagues")
                        .WithMany()
                        .HasForeignKey("LeaguesId");

                    b.HasOne("Ballerz.KnowledgeBase.Models.Seasons", "Seasons")
                        .WithMany()
                        .HasForeignKey("SeasonsId");

                    b.HasOne("Ballerz.KnowledgeBase.Models.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Leagues", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Managers", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId");

                    b.HasOne("Ballerz.KnowledgeBase.Models.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Players", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Stadiums", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId");

                    b.HasOne("Ballerz.KnowledgeBase.Models.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId");
                });

            modelBuilder.Entity("Ballerz.KnowledgeBase.Models.Teams", b =>
                {
                    b.HasOne("Ballerz.KnowledgeBase.Models.Leagues", "Leagues")
                        .WithMany()
                        .HasForeignKey("LeaguesId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Ballerz.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ballerz.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ballerz.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Ballerz.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ballerz.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ballerz.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
