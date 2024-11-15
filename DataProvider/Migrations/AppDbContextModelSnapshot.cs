﻿// <auto-generated />
using System;
using DataProvider.EntityFramework.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataProvider.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int>("PostCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostCategoryId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.PostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PostCategory");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostComment");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6300),
                            IsDeleted = false,
                            Name = "UserManagement",
                            Title = "مدیریت کاربران",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6312),
                            Value = "identity.users.command"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6462),
                            IsDeleted = false,
                            Name = "RoleManagement",
                            Title = "مدیریت نقش‌ها",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6464),
                            Value = "identity.roles.command"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6518),
                            IsDeleted = false,
                            Name = "ClaimManagement",
                            Title = "مدیریت دسترسی ها",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6520),
                            Value = "identity.claims.command"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6522),
                            IsDeleted = false,
                            Name = "UserView",
                            Title = "نمایش  مدیریت کاربران",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6524),
                            Value = "identity.users.query"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6526),
                            IsDeleted = false,
                            Name = "RoleView",
                            Title = "نمایش  مدیریت نقش ها",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6527),
                            Value = "identity.roles.query"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6532),
                            IsDeleted = false,
                            Name = "ClaimView",
                            Title = "نمایش  مدیریت دسترسی ها",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6534),
                            Value = "identity.claims.query"
                        });
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("nvarchar(140)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(8670),
                            IsDeleted = false,
                            Title = "Owner",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(8683)
                        });
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.RolePermission", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleId", "PermissionId", "Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(8955),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(8966)
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9525),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9532)
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9535),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9536)
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9538),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9539)
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9541),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9542)
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9547),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9548)
                        });
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FailedLoginCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLockedOut")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMobileConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastPasswordChangeTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LockoutEndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nchar(32)")
                        .IsFixedLength();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "56D75R3W50114RJ3BPDEM7L55KAZWKR0",
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7554),
                            Email = "bamdadtabari@outlook.com",
                            FailedLoginCount = 0,
                            IsDeleted = false,
                            IsLockedOut = false,
                            IsMobileConfirmed = false,
                            LastPasswordChangeTime = new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7111),
                            Mobile = "09301724389",
                            PasswordHash = "DTyAJQblQvN7NCr3jLHipsWuBY8q2Jr0jPFRZmQ+TOA=.H/BsoREiJFsQRumR6J3hvw==",
                            SecurityStamp = "EHSP1K6CW99ZAIN4I7CRFBRURA8NZEQH",
                            State = "Active",
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7564),
                            Username = "Illegible_Owner"
                        });
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId", "Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1,
                            Id = 0,
                            CreatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 657, DateTimeKind.Local).AddTicks(986),
                            IsDeleted = false,
                            UpdatedAt = new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(1416)
                        });
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.Post", b =>
                {
                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataProvider.EntityFramework.Entities.Blog.PostCategory", "PostCategory")
                        .WithMany("Posts")
                        .HasForeignKey("PostCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("PostCategory");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.PostComment", b =>
                {
                    b.HasOne("DataProvider.EntityFramework.Entities.Blog.Post", "Post")
                        .WithMany("PostComments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Claim", b =>
                {
                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.RolePermission", b =>
                {
                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.Role", "Role")
                        .WithMany("RolePermission")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataProvider.EntityFramework.Entities.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.Post", b =>
                {
                    b.Navigation("PostComments");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Blog.PostCategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.Role", b =>
                {
                    b.Navigation("RolePermission");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DataProvider.EntityFramework.Entities.Identity.User", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Posts");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
