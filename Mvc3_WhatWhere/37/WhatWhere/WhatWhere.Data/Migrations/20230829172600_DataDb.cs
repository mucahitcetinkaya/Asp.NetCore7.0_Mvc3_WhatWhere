using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhatWhere.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    BirthOfYear = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sehir = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleMemberships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleMemberships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ilce = table.Column<string>(type: "TEXT", nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleMembershipId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_SaleMemberships_SaleMembershipId",
                        column: x => x.SaleMembershipId,
                        principalTable: "SaleMemberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleMembershipId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_SaleMemberships_SaleMembershipId",
                        column: x => x.SaleMembershipId,
                        principalTable: "SaleMemberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BossId = table.Column<int>(type: "INTEGER", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    CityId = table.Column<int>(type: "INTEGER", nullable: true),
                    TownId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_Bosses_BossId",
                        column: x => x.BossId,
                        principalTable: "Bosses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Shops_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Shops_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Shops_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cd324f7-60e2-412b-a199-a007617eb80a", null, "Diğer tüm kullanıcıların rolü bu.", "Strict", "STRICT" },
                    { "1f9dcf84-59ba-4de7-b09b-17a03085fac7", null, "Diğer tüm kullanıcıların rolü bu.", "User", "USER" },
                    { "76c1c1dd-86df-4cb0-a6f1-d89753d8a782", null, "Yöneticilerin rolü bu.", "Admin", "ADMIN" },
                    { "f24c0ef1-518f-4903-84e2-bce0fef70edc", null, "Diğer tüm kullanıcıların rolü bu.", "Normal", "NORMAL" },
                    { "f7a285b2-f48d-4ed2-bb44-dc4cfb5d8af8", null, "Diğer tüm kullanıcıların rolü bu.", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7a7f06be-80ae-4f27-8f37-80544d63547d", 0, "Kadıköy", "İstanbul", "1023655f-dc76-46e1-b08a-9b5ac1739bd2", new DateTime(1994, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "mucahitcetinkaya@outlook.com", true, "Mücahit", "Male", "Çetinkaya", true, null, " ", "MUCAHITCETINKAYA@OUTLOOK.COM", "ADMIN", "AQAAAAIAAYagAAAAEOKIpvO5rIcvgpoiipr2qZndHLYTSQYenGUPWtIwDsqkVuVfy2feckFbUIo/THsfEg==", "+901234567", true, "", false, "admin" },
                    { "ff4c0d4c-8bf8-45bd-af69-5b5adebfe6fd", 0, "Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş", "İstanbul", "0f963a5b-90f4-45d0-b730-3902632829d8", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmetkaya@example.com", true, "Mehmet", "Male", "Kaya", true, null, " ", "MEHMETKAYA@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEC/1brKqdDTD3uAoQ8FgmmhBESVVK7zhLbTGhDu7djYRh8dVFfFgrcRUMJESca0kag==", "+901234567", true, "", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "Address", "BirthOfYear", "CreatedDate", "Description", "FirstName", "Gender", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "LastName", "MailAdress", "ModifiedDate", "PhoneNumber", "Url" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1994, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8101), null, "Mücahit", "Male", null, true, false, true, "Çetinkaya", "mucahitcetinkaya@outlook.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8118), "+901234567", "www.mucahitcetinkaya.com" },
                    { 2, null, new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8127), null, "Mehmet", "Male", null, true, false, true, "Kaya", "mehmetkaya@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8128), "+901234567", "www.mehmetkaya.com" },
                    { 3, null, new DateTime(1993, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8131), null, "Ayşe", "Female", null, true, false, true, "Demir", "aysedemir@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8131), "+901234567", "www.aysedemir.com" },
                    { 4, null, new DateTime(1994, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8133), null, "Fatma", "Female", null, true, false, true, "Yıldırım", "fatmayildirim@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8134), "+901234567", "www.fatmayildirim.com" },
                    { 5, null, new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8136), null, "Ali", "Male", null, true, false, true, "Öztürk", "aliozturk@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8136), "+901234567", "www.aliozturk.com" },
                    { 6, null, new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8138), null, "Zeynep", "Female", null, true, false, true, "Aktaş", "zeynepaktas@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8139), "+901234567", "www.zeynepaktas.com" },
                    { 7, null, new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8142), null, "Hakan", "Male", null, true, false, true, "Koç", "hakankoc@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8142), "+901234567", "www.hakankoc.com" },
                    { 8, null, new DateTime(1998, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8144), null, "Selin", "Female", null, true, false, true, "Can", "selincan@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8145), "+901234567", "www.selincan.com" },
                    { 9, null, new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8146), null, "Murat", "Male", null, true, false, true, "Şahin", "muratsahin@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8147), "+901234567", "www.muratsahin.com" },
                    { 10, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8149), null, "Deniz", "Female", null, true, false, true, "Arslan", "denizarslan@example.com", new DateTime(2023, 8, 29, 20, 26, 0, 426, DateTimeKind.Local).AddTicks(8149), "+901234567", "www.denizarslan.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8266), "Kasap Kategorisi", "kasap.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8268), "Kasap" },
                    { 2, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8272), "Eczane Kategorisi", "eczane.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8272), "Eczane" },
                    { 3, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8274), "Kırtasiye Kategorisi", "kirtasiye.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8274), "Kırtasiye" },
                    { 4, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8276), "Terzi Kategorisi", "terzi.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8276), "Terzi" },
                    { 5, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8277), "Dişçi Kategorisi", "disci.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8278), "Dişçi" },
                    { 6, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8279), "Kiralık Katil Kategorisi", "kiralik-katil.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8279), "Kiralık Katil" },
                    { 7, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8281), "Gym Kategorisi", "gym.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8281), "Gym" },
                    { 8, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8282), "Mantıcı Kategorisi", "mantici.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8283), "Mantıcı" },
                    { 9, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8284), "Futbol Sahası Kategorisi", "futbol-sahasi.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8284), "Futbol Sahası" },
                    { 10, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8286), "Lostra Kategorisi", "lostra.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8286), "Lostra" },
                    { 11, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8287), "Bakkal Kategorisi", "bakkal.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8288), "Bakkal" },
                    { 12, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8289), "Restoran Kategorisi", "restoran.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8289), "Restoran" },
                    { 13, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8290), "Kafe Kategorisi", "kafe.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8291), "Kafe" },
                    { 14, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8292), "Butik Kategorisi", "butik.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8292), "Butik" },
                    { 15, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8293), "Optik Kategorisi", "optik.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8294), "Optik" },
                    { 16, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8295), "Mobilya Mağazası Kategorisi", "mobilya.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8296), "Mobilya Mağazası" },
                    { 17, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8297), "Oyuncakçı Kategorisi", "oyuncakci.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8297), "Oyuncakçı" },
                    { 18, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8298), "Elektronik Mağaza Kategorisi", "elektronik.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8299), "Elektronik Mağaza" },
                    { 19, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8300), "Çiçekçi Kategorisi", "cicekci.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8300), "Çiçekçi" },
                    { 20, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8302), "Kitapçı Kategorisi", "kitapci.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8303), "Kitapçı" },
                    { 21, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8304), "Genel Kategorisi", "genel.jpg", true, false, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(8304), "Genel" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Sehir" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 2, "Adıyaman" },
                    { 3, "Afyonkarahisar" },
                    { 4, "Ağrı" },
                    { 5, "Amasya" },
                    { 6, "Ankara" },
                    { 7, "Antalya" },
                    { 8, "Artvin" },
                    { 9, "Aydın" },
                    { 10, "Balıkesir" },
                    { 11, "Bilecik" },
                    { 12, "Bingöl" },
                    { 13, "Bitlis" },
                    { 14, "Bolu" },
                    { 15, "Burdur" },
                    { 16, "Bursa" },
                    { 17, "Çanakkale" },
                    { 18, "Çankırı" },
                    { 19, "Çorum" },
                    { 20, "Denizli" },
                    { 21, "Diyarbakır" },
                    { 22, "Edirne" },
                    { 23, "Elazığ" },
                    { 24, "Erzincan" },
                    { 25, "Erzurum" },
                    { 26, "Eskişehir" },
                    { 27, "Gaziantep" },
                    { 28, "Giresun" },
                    { 29, "Gümüşhane" },
                    { 30, "Hakkari" },
                    { 31, "Hatay" },
                    { 32, "Isparta" },
                    { 33, "Mersin" },
                    { 34, "İstanbul" },
                    { 35, "İzmir" },
                    { 36, "Kars" },
                    { 37, "Kastamonu" },
                    { 38, "Kayseri" },
                    { 39, "Kırklareli" },
                    { 40, "Kırşehir" },
                    { 41, "Kocaeli" },
                    { 42, "Konya" },
                    { 43, "Kütahya" },
                    { 44, "Malatya" },
                    { 45, "Manisa" },
                    { 46, "Kahramanmaraş" },
                    { 47, "Mardin" },
                    { 48, "Muğla" },
                    { 49, "Muş" },
                    { 50, "Nevşehir" },
                    { 51, "Niğde" },
                    { 52, "Ordu" },
                    { 53, "Rize" },
                    { 54, "Sakarya" },
                    { 55, "Samsun" },
                    { 56, "Siirt" },
                    { 57, "Sinop" },
                    { 58, "Sivas" },
                    { 59, "Tekirdağ" },
                    { 60, "Tokat" },
                    { 61, "Trabzon" },
                    { 62, "Tunceli" },
                    { 63, "Şanlıurfa" },
                    { 64, "Uşak" },
                    { 65, "Van" },
                    { 66, "Yozgat" },
                    { 67, "Zonguldak" },
                    { 68, "Aksaray" },
                    { 69, "Bayburt" },
                    { 70, "Karaman" },
                    { 71, "Kırıkkale" },
                    { 72, "Batman" },
                    { 73, "Şırnak" },
                    { 74, "Bartın" },
                    { 75, "Ardahan" },
                    { 76, "Iğdır" },
                    { 77, "Yalova" },
                    { 78, "Karabük" },
                    { 79, "Kilis" },
                    { 80, "Osmaniye" },
                    { 81, "Düzce" }
                });

            migrationBuilder.InsertData(
                table: "SaleMemberships",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6821), "1 Aylık üyelik ücretsizdir. Birinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-1.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6825), "1 Aylık Üyelik", 0m },
                    { 2, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6832), "2 Aylık üyelik. İkinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-2.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6833), "2 Aylık Üyelik", 20m },
                    { 3, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6838), "3 Aylık üyelik. Üçüncü ay sonunda hesaplar pasif olur.", "aylik-uyelik-3.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6838), "3 Aylık Üyelik", 30m },
                    { 4, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6841), "4 Aylık üyelik. Dördüncü ay sonunda hesaplar pasif olur.", "aylik-uyelik-4.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6841), "4 Aylık Üyelik", 40m },
                    { 5, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6843), "5 Aylık üyelik. Beşinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-5.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6843), "5 Aylık Üyelik", 50m },
                    { 6, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6845), "6 Aylık üyelik. Altıncı ay sonunda hesaplar pasif olur.", "aylik-uyelik-6.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6846), "6 Aylık Üyelik", 60m },
                    { 7, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6848), "7 Aylık üyelik. Yedinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-7.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6848), "7 Aylık Üyelik", 70m },
                    { 8, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6850), "8 Aylık üyelik. Sekizinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-8.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6851), "8 Aylık Üyelik", 80m },
                    { 9, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6852), "9 Aylık üyelik. Dokuzuncu ay sonunda hesaplar pasif olur.", "aylik-uyelik-9.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6853), "9 Aylık Üyelik", 90m },
                    { 10, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6855), "10 Aylık üyelik. Onuncu ay sonunda hesaplar pasif olur.", "aylik-uyelik-10.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6855), "10 Aylık Üyelik", 100m },
                    { 11, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6857), "11 Aylık üyelik. Onbirinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-11.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6857), "11 Aylık Üyelik", 110m },
                    { 12, new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6859), "12 Aylık üyelik. Onikinci ay sonunda hesaplar pasif olur.", "aylik-uyelik-12.jpg", new DateTime(2023, 8, 29, 20, 26, 0, 428, DateTimeKind.Local).AddTicks(6859), "12 Aylık Üyelik", 120m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "76c1c1dd-86df-4cb0-a6f1-d89753d8a782", "7a7f06be-80ae-4f27-8f37-80544d63547d" },
                    { "1f9dcf84-59ba-4de7-b09b-17a03085fac7", "ff4c0d4c-8bf8-45bd-af69-5b5adebfe6fd" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 29, 20, 26, 0, 637, DateTimeKind.Local).AddTicks(1745), true, false, new DateTime(2023, 8, 29, 20, 26, 0, 637, DateTimeKind.Local).AddTicks(1759), "7a7f06be-80ae-4f27-8f37-80544d63547d" },
                    { 2, new DateTime(2023, 8, 29, 20, 26, 0, 637, DateTimeKind.Local).AddTicks(1763), true, false, new DateTime(2023, 8, 29, 20, 26, 0, 637, DateTimeKind.Local).AddTicks(1764), "ff4c0d4c-8bf8-45bd-af69-5b5adebfe6fd" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CityId", "Ilce" },
                values: new object[,]
                {
                    { 1, 1, "Aladağ" },
                    { 2, 1, "Ceyhan" },
                    { 3, 1, "Çukurova" },
                    { 4, 1, "Feke" },
                    { 5, 1, "İmamoğlu" },
                    { 6, 1, "Karaisalı" },
                    { 7, 1, "Karataş" },
                    { 8, 1, "Kozan" },
                    { 9, 1, "Pozantı" },
                    { 10, 1, "Saimbeyli" },
                    { 11, 1, "Sarıçam" },
                    { 12, 1, "Seyhan" },
                    { 13, 1, "Tufanbeyli" },
                    { 14, 1, "Yumurtalık" },
                    { 15, 1, "Yüreğir" },
                    { 16, 2, "Besni" },
                    { 17, 2, "Çelikhan" },
                    { 18, 2, "Gerger" },
                    { 19, 2, "Gölbaşı" },
                    { 20, 2, "Kahta" },
                    { 21, 2, "Merkez" },
                    { 22, 2, "Samsat" },
                    { 23, 2, "Sincik" },
                    { 24, 2, "Tut" },
                    { 25, 3, "Başmakçı" },
                    { 26, 3, "Bayat" },
                    { 27, 3, "Bolvadin" },
                    { 28, 3, "Çay" },
                    { 29, 3, "Çobanlar" },
                    { 30, 3, "Dazkırı" },
                    { 31, 3, "Dinar" },
                    { 32, 3, "Emirdağ" },
                    { 33, 3, "Evciler" },
                    { 34, 3, "Hocalar" },
                    { 35, 3, "İhsaniye" },
                    { 36, 3, "İscehisar" },
                    { 37, 3, "Kızılören" },
                    { 38, 3, "Merkez" },
                    { 39, 3, "Sandıklı" },
                    { 40, 3, "Sinanpaşa" },
                    { 41, 3, "Sultandağı" },
                    { 42, 3, "Şuhut" },
                    { 43, 4, "Diyadin" },
                    { 44, 4, "Doğubayazıt" },
                    { 45, 4, "Eleşkirt" },
                    { 46, 4, "Hamur" },
                    { 47, 4, "Merkez" },
                    { 48, 4, "Patnos" },
                    { 49, 4, "Taşlıçay" },
                    { 50, 4, "Tutak" },
                    { 51, 5, "Göynücek" },
                    { 52, 5, "Gümüşhacıköy" },
                    { 53, 5, "Hamamözü" },
                    { 54, 5, "Merkez" },
                    { 55, 5, "Merzifon" },
                    { 56, 5, "Suluova" },
                    { 57, 5, "Taşova" },
                    { 58, 6, "Altındağ" },
                    { 59, 6, "Ayaş" },
                    { 60, 6, "Bala" },
                    { 61, 6, "Beypazarı" },
                    { 62, 6, "Çamlıdere" },
                    { 63, 6, "Çankaya" },
                    { 64, 6, "Çubuk" },
                    { 65, 6, "Elmadağ" },
                    { 66, 6, "Güdül" },
                    { 67, 6, "Haymana" },
                    { 68, 6, "Kalecik" },
                    { 69, 6, "Kızılcahamam" },
                    { 70, 6, "Nallıhan" },
                    { 71, 6, "Polatlı" },
                    { 72, 6, "Şereflikoçhisar" },
                    { 73, 6, "Yenimahalle" },
                    { 74, 6, "Gölbaşı" },
                    { 75, 6, "Keçiören" },
                    { 76, 6, "Mamak" },
                    { 77, 6, "Sincan" },
                    { 78, 6, "Kazan" },
                    { 79, 6, "Akyurt" },
                    { 80, 6, "Etimesgut" },
                    { 81, 6, "Evren" },
                    { 82, 6, "Pursaklar" },
                    { 83, 7, "Akseki" },
                    { 84, 7, "Alanya" },
                    { 85, 7, "Elmalı" },
                    { 86, 7, "Finike" },
                    { 87, 7, "Gazipaşa" },
                    { 88, 7, "Gündoğmuş" },
                    { 89, 7, "Kaş" },
                    { 90, 7, "Korkuteli" },
                    { 91, 7, "Kumluca" },
                    { 92, 7, "Manavgat" },
                    { 93, 7, "Serik" },
                    { 94, 7, "Demre" },
                    { 95, 7, "İbradı" },
                    { 96, 7, "Kemer" },
                    { 97, 7, "Aksu" },
                    { 98, 7, "Döşemealtı" },
                    { 99, 7, "Kepez" },
                    { 100, 7, "Konyaaltı" },
                    { 101, 7, "Muratpaşa" },
                    { 102, 8, "Ardanuç" },
                    { 103, 8, "Arhavi" },
                    { 104, 8, "Merkez" },
                    { 105, 8, "Borçka" },
                    { 106, 8, "Hopa" },
                    { 107, 8, "Şavşat" },
                    { 108, 8, "Yusufeli" },
                    { 109, 8, "Murgul" },
                    { 110, 9, "Merkez" },
                    { 111, 9, "Bozdoğan" },
                    { 112, 9, "Efeler" },
                    { 113, 9, "Çine" },
                    { 114, 9, "Germencik" },
                    { 115, 9, "Karacasu" },
                    { 116, 9, "Koçarlı" },
                    { 117, 9, "Kuşadası" },
                    { 118, 9, "Kuyucak" },
                    { 119, 9, "Nazilli" },
                    { 120, 9, "Söke" },
                    { 121, 9, "Sultanhisar" },
                    { 122, 9, "Yenipazar" },
                    { 123, 9, "Buharkent" },
                    { 124, 9, "İncirliova" },
                    { 125, 9, "Karpuzlu" },
                    { 126, 9, "Köşk" },
                    { 127, 9, "Didim" },
                    { 128, 10, "Altıeylül" },
                    { 129, 10, "Ayvalık" },
                    { 130, 10, "Merkez" },
                    { 131, 10, "Balya" },
                    { 132, 10, "Bandırma" },
                    { 133, 10, "Bigadiç" },
                    { 134, 10, "Burhaniye" },
                    { 135, 10, "Dursunbey" },
                    { 136, 10, "Edremit" },
                    { 137, 10, "Erdek" },
                    { 138, 10, "Gönen" },
                    { 139, 10, "Havran" },
                    { 140, 10, "İvrindi" },
                    { 141, 10, "Karesi" },
                    { 142, 10, "Kepsut" },
                    { 143, 10, "Manyas" },
                    { 144, 10, "Savaştepe" },
                    { 145, 10, "Sındırgı" },
                    { 146, 10, "Gömeç" },
                    { 147, 10, "Susurluk" },
                    { 148, 10, "Marmara" },
                    { 149, 11, "Merkez" },
                    { 150, 11, "Bozüyük" },
                    { 151, 11, "Gölpazarı" },
                    { 152, 11, "Osmaneli" },
                    { 153, 11, "Pazaryeri" },
                    { 154, 11, "Söğüt" },
                    { 155, 11, "Yenipazar" },
                    { 156, 11, "İnhisar" },
                    { 157, 12, "Merkez" },
                    { 158, 12, "Genç" },
                    { 159, 12, "Karlıova" },
                    { 160, 12, "Kiğı" },
                    { 161, 12, "Solhan" },
                    { 162, 12, "Adaklı" },
                    { 163, 12, "Yayladere" },
                    { 164, 12, "Yedisu" },
                    { 165, 13, "Adilcevaz" },
                    { 166, 13, "Ahlat" },
                    { 167, 13, "Merkez" },
                    { 168, 13, "Hizan" },
                    { 169, 13, "Mutki" },
                    { 170, 13, "Tatvan" },
                    { 171, 13, "Güroymak" },
                    { 172, 14, "Merkez" },
                    { 173, 14, "Gerede" },
                    { 174, 14, "Göynük" },
                    { 175, 14, "Kıbrıscık" },
                    { 176, 14, "Mengen" },
                    { 177, 14, "Mudurnu" },
                    { 178, 14, "Seben" },
                    { 179, 14, "Dörtdivan" },
                    { 180, 14, "Yeniçağa" },
                    { 181, 15, "Ağlasun" },
                    { 182, 15, "Bucak" },
                    { 183, 15, "Merkez" },
                    { 184, 15, "Gölhisar" },
                    { 185, 15, "Tefenni" },
                    { 186, 15, "Yeşilova" },
                    { 187, 15, "Karamanlı" },
                    { 188, 15, "Kemer" },
                    { 189, 15, "Altınyayla" },
                    { 190, 15, "Çavdır" },
                    { 191, 15, "Çeltikçi" },
                    { 192, 16, "Gemlik" },
                    { 193, 16, "İnegöl" },
                    { 194, 16, "İznik" },
                    { 195, 16, "Karacabey" },
                    { 196, 16, "Keles" },
                    { 197, 16, "Mudanya" },
                    { 198, 16, "Mustafakemalpaşa" },
                    { 199, 16, "Orhaneli" },
                    { 200, 16, "Orhangazi" },
                    { 201, 16, "Yenişehir" },
                    { 202, 16, "Büyükorhan" },
                    { 203, 16, "Harmancık" },
                    { 204, 16, "Nilüfer" },
                    { 205, 16, "Osmangazi" },
                    { 206, 16, "Yıldırım" },
                    { 207, 16, "Gürsu" },
                    { 208, 16, "Kestel" },
                    { 209, 17, "Ayvacık" },
                    { 210, 17, "Bayramiç" },
                    { 211, 17, "Biga" },
                    { 212, 17, "Bozcaada" },
                    { 213, 17, "Çan" },
                    { 214, 17, "Merkez" },
                    { 215, 17, "Eceabat" },
                    { 216, 17, "Ezine" },
                    { 217, 17, "Gelibolu" },
                    { 218, 17, "Gökçeada" },
                    { 219, 17, "Lapseki" },
                    { 220, 17, "Yenice" },
                    { 221, 18, "Merkez" },
                    { 222, 18, "Çerkeş" },
                    { 223, 18, "Eldivan" },
                    { 224, 18, "Ilgaz" },
                    { 225, 18, "Kurşunlu" },
                    { 226, 18, "Orta" },
                    { 227, 18, "Şabanözü" },
                    { 228, 18, "Yapraklı" },
                    { 229, 18, "Atkaracalar" },
                    { 230, 18, "Kızılırmak" },
                    { 231, 18, "Bayramören" },
                    { 232, 18, "Korgun" },
                    { 233, 19, "Alaca" },
                    { 234, 19, "Bayat" },
                    { 235, 19, "Merkez" },
                    { 236, 19, "İskilip" },
                    { 237, 19, "Kargı" },
                    { 238, 19, "Mecitözü" },
                    { 239, 19, "Ortaköy" },
                    { 240, 19, "Osmancık" },
                    { 241, 19, "Sungurlu" },
                    { 242, 19, "Boğazkale" },
                    { 243, 19, "Uğurludağ" },
                    { 244, 19, "Dodurga" },
                    { 245, 19, "Laçin" },
                    { 246, 19, "Oğuzlar" },
                    { 247, 20, "Acıpayam" },
                    { 248, 20, "Buldan" },
                    { 249, 20, "Çal" },
                    { 250, 20, "Çameli" },
                    { 251, 20, "Çardak" },
                    { 252, 20, "Çivril" },
                    { 253, 20, "Merkez" },
                    { 254, 20, "Merkezefendi" },
                    { 255, 20, "Pamukkale" },
                    { 256, 20, "Güney" },
                    { 257, 20, "Kale" },
                    { 258, 20, "Sarayköy" },
                    { 259, 20, "Tavas" },
                    { 260, 20, "Babadağ" },
                    { 261, 20, "Bekilli" },
                    { 262, 20, "Honaz" },
                    { 263, 20, "Serinhisar" },
                    { 264, 20, "Baklan" },
                    { 265, 20, "Beyağaç" },
                    { 266, 20, "Bozkurt" },
                    { 267, 21, "Kocaköy" },
                    { 268, 21, "Çermik" },
                    { 269, 21, "Çınar" },
                    { 270, 21, "Çüngüş" },
                    { 271, 21, "Dicle" },
                    { 272, 21, "Ergani" },
                    { 273, 21, "Hani" },
                    { 274, 21, "Hazro" },
                    { 275, 21, "Kulp" },
                    { 276, 21, "Lice" },
                    { 277, 21, "Silvan" },
                    { 278, 21, "Eğil" },
                    { 279, 21, "Bağlar" },
                    { 280, 21, "Kayapınar" },
                    { 281, 21, "Sur" },
                    { 282, 21, "Yenişehir" },
                    { 283, 21, "Bismil" },
                    { 284, 22, "Merkez" },
                    { 285, 22, "Enez" },
                    { 286, 22, "Havsa" },
                    { 287, 22, "İpsala" },
                    { 288, 22, "Keşan" },
                    { 289, 22, "Lalapaşa" },
                    { 290, 22, "Meriç" },
                    { 291, 22, "Uzunköprü" },
                    { 292, 22, "Süloğlu" },
                    { 293, 23, "Ağın" },
                    { 294, 23, "Baskil" },
                    { 295, 23, "Merkez" },
                    { 296, 23, "Karakoçan" },
                    { 297, 23, "Keban" },
                    { 298, 23, "Maden" },
                    { 299, 23, "Palu" },
                    { 300, 23, "Sivrice" },
                    { 301, 23, "Arıcak" },
                    { 302, 23, "Kovancılar" },
                    { 303, 23, "Alacakaya" },
                    { 304, 24, "Çayırlı" },
                    { 305, 24, "Merkez" },
                    { 306, 24, "İliç" },
                    { 307, 24, "Kemah" },
                    { 308, 24, "Kemaliye" },
                    { 309, 24, "Refahiye" },
                    { 310, 24, "Tercan" },
                    { 311, 24, "Üzümlü" },
                    { 312, 24, "Otlukbeli" },
                    { 313, 25, "Aşkale" },
                    { 314, 25, "Çat" },
                    { 315, 25, "Hınıs" },
                    { 316, 25, "Horasan" },
                    { 317, 25, "İspir" },
                    { 318, 25, "Karayazı" },
                    { 319, 25, "Narman" },
                    { 320, 25, "Oltu" },
                    { 321, 25, "Olur" },
                    { 322, 25, "Pasinler" },
                    { 323, 25, "Şenkaya" },
                    { 324, 25, "Tekman" },
                    { 325, 25, "Tortum" },
                    { 326, 25, "Karaçoban" },
                    { 327, 25, "Uzundere" },
                    { 328, 25, "Pazaryolu" },
                    { 329, 25, "Köprüköy" },
                    { 330, 25, "Palandöken" },
                    { 331, 25, "Yakutiye" },
                    { 332, 25, "Aziziye" },
                    { 333, 26, "Çifteler" },
                    { 334, 26, "Mahmudiye" },
                    { 335, 26, "Mihalıççık" },
                    { 336, 26, "Sarıcakaya" },
                    { 337, 26, "Seyitgazi" },
                    { 338, 26, "Sivrihisar" },
                    { 339, 26, "Alpu" },
                    { 340, 26, "Beylikova" },
                    { 341, 26, "İnönü" },
                    { 342, 26, "Günyüzü" },
                    { 343, 26, "Han" },
                    { 344, 26, "Mihalgazi" },
                    { 345, 26, "Odunpazarı" },
                    { 346, 26, "Tepebaşı" },
                    { 347, 27, "Araban" },
                    { 348, 27, "İslahiye" },
                    { 349, 27, "Nizip" },
                    { 350, 27, "Oğuzeli" },
                    { 351, 27, "Yavuzeli" },
                    { 352, 27, "Şahinbey" },
                    { 353, 27, "Şehitkamil" },
                    { 354, 27, "Karkamış" },
                    { 355, 27, "Nurdağı" },
                    { 356, 28, "Alucra" },
                    { 357, 28, "Bulancak" },
                    { 358, 28, "Dereli" },
                    { 359, 28, "Espiye" },
                    { 360, 28, "Eynesil" },
                    { 361, 28, "Merkez" },
                    { 362, 28, "Görele" },
                    { 363, 28, "Keşap" },
                    { 364, 28, "Şebinkarahisar" },
                    { 365, 28, "Tirebolu" },
                    { 366, 28, "Piraziz" },
                    { 367, 28, "Yağlıdere" },
                    { 368, 28, "Çamoluk" },
                    { 369, 28, "Çanakçı" },
                    { 370, 28, "Doğankent" },
                    { 371, 28, "Güce" },
                    { 372, 29, "Merkez" },
                    { 373, 29, "Kelkit" },
                    { 374, 29, "Şiran" },
                    { 375, 29, "Torul" },
                    { 376, 29, "Köse" },
                    { 377, 29, "Kürtün" },
                    { 378, 30, "Çukurca" },
                    { 379, 30, "Merkez" },
                    { 380, 30, "Şemdinli" },
                    { 381, 30, "Yüksekova" },
                    { 382, 31, "Altınözü" },
                    { 383, 31, "Arsuz" },
                    { 384, 31, "Defne" },
                    { 385, 31, "Dörtyol" },
                    { 386, 31, "Hassa" },
                    { 387, 31, "Antakya" },
                    { 388, 31, "İskenderun" },
                    { 389, 31, "Kırıkhan" },
                    { 390, 31, "Payas" },
                    { 391, 31, "Reyhanlı" },
                    { 392, 31, "Samandağ" },
                    { 393, 31, "Yayladağı" },
                    { 394, 31, "Erzin" },
                    { 395, 31, "Belen" },
                    { 396, 31, "Kumlu" },
                    { 397, 32, "Atabey" },
                    { 398, 32, "Eğirdir" },
                    { 399, 32, "Gelendost" },
                    { 400, 32, "Merkez" },
                    { 401, 32, "Keçiborlu" },
                    { 402, 32, "Senirkent" },
                    { 403, 32, "Sütçüler" },
                    { 404, 32, "Şarkikaraağaç" },
                    { 405, 32, "Uluborlu" },
                    { 406, 32, "Yalvaç" },
                    { 407, 32, "Aksu" },
                    { 408, 32, "Gönen" },
                    { 409, 32, "Yenişarbademli" },
                    { 410, 33, "Anamur" },
                    { 411, 33, "Erdemli" },
                    { 412, 33, "Gülnar" },
                    { 413, 33, "Mut" },
                    { 414, 33, "Silifke" },
                    { 415, 33, "Tarsus" },
                    { 416, 33, "Aydıncık" },
                    { 417, 33, "Bozyazı" },
                    { 418, 33, "Çamlıyayla" },
                    { 419, 33, "Akdeniz" },
                    { 420, 33, "Mezitli" },
                    { 421, 33, "Toroslar" },
                    { 422, 33, "Yenişehir" },
                    { 423, 34, "Adalar" },
                    { 424, 34, "Bakırköy" },
                    { 425, 34, "Beşiktaş" },
                    { 426, 34, "Beykoz" },
                    { 427, 34, "Beyoğlu" },
                    { 428, 34, "Çatalca" },
                    { 429, 34, "Eyüp" },
                    { 430, 34, "Fatih" },
                    { 431, 34, "Gaziosmanpaşa" },
                    { 432, 34, "Kadıköy" },
                    { 433, 34, "Kartal" },
                    { 434, 34, "Sarıyer" },
                    { 435, 34, "Silivri" },
                    { 436, 34, "Şile" },
                    { 437, 34, "Şişli" },
                    { 438, 34, "Üsküdar" },
                    { 439, 34, "Zeytinburnu" },
                    { 440, 34, "Büyükçekmece" },
                    { 441, 34, "Kağıthane" },
                    { 442, 34, "Küçükçekmece" },
                    { 443, 34, "Pendik" },
                    { 444, 34, "Ümraniye" },
                    { 445, 34, "Bayrampaşa" },
                    { 446, 34, "Avcılar" },
                    { 447, 34, "Bağcılar" },
                    { 448, 34, "Bahçelievler" },
                    { 449, 34, "Güngören" },
                    { 450, 34, "Maltepe" },
                    { 451, 34, "Sultanbeyli" },
                    { 452, 34, "Tuzla" },
                    { 453, 34, "Esenler" },
                    { 454, 34, "Arnavutköy" },
                    { 455, 34, "Ataşehir" },
                    { 456, 34, "Başakşehir" },
                    { 457, 34, "Beylikdüzü" },
                    { 458, 34, "Çekmeköy" },
                    { 459, 34, "Esenyurt" },
                    { 460, 34, "Sancaktepe" },
                    { 461, 34, "Sultangazi" },
                    { 462, 35, "Aliağa" },
                    { 463, 35, "Bayındır" },
                    { 464, 35, "Bergama" },
                    { 465, 35, "Bornova" },
                    { 466, 35, "Çeşme" },
                    { 467, 35, "Dikili" },
                    { 468, 35, "Foça" },
                    { 469, 35, "Karaburun" },
                    { 470, 35, "Karşıyaka" },
                    { 471, 35, "Kemalpaşa" },
                    { 472, 35, "Kınık" },
                    { 473, 35, "Kiraz" },
                    { 474, 35, "Menemen" },
                    { 475, 35, "Ödemiş" },
                    { 476, 35, "Seferihisar" },
                    { 477, 35, "Selçuk" },
                    { 478, 35, "Tire" },
                    { 479, 35, "Torbalı" },
                    { 480, 35, "Urla" },
                    { 481, 35, "Beydağ" },
                    { 482, 35, "Buca" },
                    { 483, 35, "Konak" },
                    { 484, 35, "Menderes" },
                    { 485, 35, "Balçova" },
                    { 486, 35, "Çiğli" },
                    { 487, 35, "Gaziemir" },
                    { 488, 35, "Narlıdere" },
                    { 489, 35, "Güzelbahçe" },
                    { 490, 35, "Bayraklı" },
                    { 491, 35, "Karabağlar" },
                    { 492, 36, "Arpaçay" },
                    { 493, 36, "Digor" },
                    { 494, 36, "Kağızman" },
                    { 495, 36, "Merkez" },
                    { 496, 36, "Sarıkamış" },
                    { 497, 36, "Selim" },
                    { 498, 36, "Susuz" },
                    { 499, 36, "Akyaka" },
                    { 500, 37, "Abana" },
                    { 501, 37, "Araç" },
                    { 502, 37, "Azdavay" },
                    { 503, 37, "Bozkurt" },
                    { 504, 37, "Cide" },
                    { 505, 37, "Çatalzeytin" },
                    { 506, 37, "Daday" },
                    { 507, 37, "Devrekani" },
                    { 508, 37, "İnebolu" },
                    { 509, 37, "Merkez" },
                    { 510, 37, "Küre" },
                    { 511, 37, "Taşköprü" },
                    { 512, 37, "Tosya" },
                    { 513, 37, "İhsangazi" },
                    { 514, 37, "Pınarbaşı" },
                    { 515, 37, "Şenpazar" },
                    { 516, 37, "Ağlı" },
                    { 517, 37, "Doğanyurt" },
                    { 518, 37, "Hanönü" },
                    { 519, 37, "Seydiler" },
                    { 520, 38, "Bünyan" },
                    { 521, 38, "Develi" },
                    { 522, 38, "Felahiye" },
                    { 523, 38, "İncesu" },
                    { 524, 38, "Pınarbaşı" },
                    { 525, 38, "Sarıoğlan" },
                    { 526, 38, "Sarız" },
                    { 527, 38, "Tomarza" },
                    { 528, 38, "Yahyalı" },
                    { 529, 38, "Yeşilhisar" },
                    { 530, 38, "Akkışla" },
                    { 531, 38, "Talas" },
                    { 532, 38, "Kocasinan" },
                    { 533, 38, "Melikgazi" },
                    { 534, 38, "Hacılar" },
                    { 535, 38, "Özvatan" },
                    { 536, 39, "Babaeski" },
                    { 537, 39, "Demirköy" },
                    { 538, 39, "Merkez" },
                    { 539, 39, "Kofçaz" },
                    { 540, 39, "Lüleburgaz" },
                    { 541, 39, "Pehlivanköy" },
                    { 542, 39, "Pınarhisar" },
                    { 543, 39, "Vize" },
                    { 544, 40, "Çiçekdağı" },
                    { 545, 40, "Kaman" },
                    { 546, 40, "Merkez" },
                    { 547, 40, "Mucur" },
                    { 548, 40, "Akpınar" },
                    { 549, 40, "Akçakent" },
                    { 550, 40, "Boztepe" },
                    { 551, 41, "Gebze" },
                    { 552, 41, "Gölcük" },
                    { 553, 41, "Kandıra" },
                    { 554, 41, "Karamürsel" },
                    { 555, 41, "Körfez" },
                    { 556, 41, "Derince" },
                    { 557, 41, "Başiskele" },
                    { 558, 41, "Çayırova" },
                    { 559, 41, "Darıca" },
                    { 560, 41, "Dilovası" },
                    { 561, 41, "İzmit" },
                    { 562, 41, "Kartepe" },
                    { 563, 42, "Akşehir" },
                    { 564, 42, "Beyşehir" },
                    { 565, 42, "Bozkır" },
                    { 566, 42, "Cihanbeyli" },
                    { 567, 42, "Çumra" },
                    { 568, 42, "Doğanhisar" },
                    { 569, 42, "Ereğli" },
                    { 570, 42, "Hadim" },
                    { 571, 42, "Ilgın" },
                    { 572, 42, "Kadınhanı" },
                    { 573, 42, "Karapınar" },
                    { 574, 42, "Kulu" },
                    { 575, 42, "Sarayönü" },
                    { 576, 42, "Seydişehir" },
                    { 577, 42, "Yunak" },
                    { 578, 42, "Akören" },
                    { 579, 42, "Altınekin" },
                    { 580, 42, "Derebucak" },
                    { 581, 42, "Hüyük" },
                    { 582, 42, "Karatay" },
                    { 583, 42, "Meram" },
                    { 584, 42, "Selçuklu" },
                    { 585, 42, "Taşkent" },
                    { 586, 42, "Ahırlı" },
                    { 587, 42, "Çeltik" },
                    { 588, 42, "Derbent" },
                    { 589, 42, "Emirgazi" },
                    { 590, 42, "Güneysınır" },
                    { 591, 42, "Halkapınar" },
                    { 592, 42, "Tuzlukçu" },
                    { 593, 42, "Yalıhüyük" },
                    { 594, 43, "Altıntaş" },
                    { 595, 43, "Domaniç" },
                    { 596, 43, "Emet" },
                    { 597, 43, "Gediz" },
                    { 598, 43, "Merkez" },
                    { 599, 43, "Simav" },
                    { 600, 43, "Tavşanlı" },
                    { 601, 43, "Aslanapa" },
                    { 602, 43, "Dumlupınar" },
                    { 603, 43, "Hisarcık" },
                    { 604, 43, "Şaphane" },
                    { 605, 43, "Çavdarhisar" },
                    { 606, 43, "Pazarlar" },
                    { 607, 44, "Akçadağ" },
                    { 608, 44, "Arapgir" },
                    { 609, 44, "Arguvan" },
                    { 610, 44, "Darende" },
                    { 611, 44, "Doğanşehir" },
                    { 612, 44, "Hekimhan" },
                    { 613, 44, "Merkez" },
                    { 614, 44, "Pütürge" },
                    { 615, 44, "Yeşilyurt" },
                    { 616, 44, "Battalgazi" },
                    { 617, 44, "Doğanyol" },
                    { 618, 44, "Kale" },
                    { 619, 44, "Kuluncak" },
                    { 620, 44, "Yazıhan" },
                    { 621, 45, "Akhisar" },
                    { 622, 45, "Alaşehir" },
                    { 623, 45, "Demirci" },
                    { 624, 45, "Gördes" },
                    { 625, 45, "Kırkağaç" },
                    { 626, 45, "Kula" },
                    { 627, 45, "Merkez" },
                    { 628, 45, "Salihli" },
                    { 629, 45, "Sarıgöl" },
                    { 630, 45, "Saruhanlı" },
                    { 631, 45, "Selendi" },
                    { 632, 45, "Soma" },
                    { 633, 45, "Şehzadeler" },
                    { 634, 45, "Yunusemre" },
                    { 635, 45, "Turgutlu" },
                    { 636, 45, "Ahmetli" },
                    { 637, 45, "Gölmarmara" },
                    { 638, 45, "Köprübaşı" },
                    { 639, 46, "Afşin" },
                    { 640, 46, "Andırın" },
                    { 641, 46, "Dulkadiroğlu" },
                    { 642, 46, "Onikişubat" },
                    { 643, 46, "Elbistan" },
                    { 644, 46, "Göksun" },
                    { 645, 46, "Merkez" },
                    { 646, 46, "Pazarcık" },
                    { 647, 46, "Türkoğlu" },
                    { 648, 46, "Çağlayancerit" },
                    { 649, 46, "Ekinözü" },
                    { 650, 46, "Nurhak" },
                    { 651, 47, "Derik" },
                    { 652, 47, "Kızıltepe" },
                    { 653, 47, "Artuklu" },
                    { 654, 47, "Merkez" },
                    { 655, 47, "Mazıdağı" },
                    { 656, 47, "Midyat" },
                    { 657, 47, "Nusaybin" },
                    { 658, 47, "Ömerli" },
                    { 659, 47, "Savur" },
                    { 660, 47, "Dargeçit" },
                    { 661, 47, "Yeşilli" },
                    { 662, 48, "Bodrum" },
                    { 663, 48, "Datça" },
                    { 664, 48, "Fethiye" },
                    { 665, 48, "Köyceğiz" },
                    { 666, 48, "Marmaris" },
                    { 667, 48, "Menteşe" },
                    { 668, 48, "Milas" },
                    { 669, 48, "Ula" },
                    { 670, 48, "Yatağan" },
                    { 671, 48, "Dalaman" },
                    { 672, 48, "Seydikemer" },
                    { 673, 48, "Ortaca" },
                    { 674, 48, "Kavaklıdere" },
                    { 675, 49, "Bulanık" },
                    { 676, 49, "Malazgirt" },
                    { 677, 49, "Merkez" },
                    { 678, 49, "Varto" },
                    { 679, 49, "Hasköy" },
                    { 680, 49, "Korkut" },
                    { 681, 50, "Avanos" },
                    { 682, 50, "Derinkuyu" },
                    { 683, 50, "Gülşehir" },
                    { 684, 50, "Hacıbektaş" },
                    { 685, 50, "Kozaklı" },
                    { 686, 50, "Merkez" },
                    { 687, 50, "Ürgüp" },
                    { 688, 50, "Acıgöl" },
                    { 689, 51, "Bor" },
                    { 690, 51, "Çamardı" },
                    { 691, 51, "Merkez" },
                    { 692, 51, "Ulukışla" },
                    { 693, 51, "Altunhisar" },
                    { 694, 51, "Çiftlik" },
                    { 695, 52, "Akkuş" },
                    { 696, 52, "Altınordu" },
                    { 697, 52, "Aybastı" },
                    { 698, 52, "Fatsa" },
                    { 699, 52, "Gölköy" },
                    { 700, 52, "Korgan" },
                    { 701, 52, "Kumru" },
                    { 702, 52, "Mesudiye" },
                    { 703, 52, "Perşembe" },
                    { 704, 52, "Ulubey" },
                    { 705, 52, "Ünye" },
                    { 706, 52, "Gülyalı" },
                    { 707, 52, "Gürgentepe" },
                    { 708, 52, "Çamaş" },
                    { 709, 52, "Çatalpınar" },
                    { 710, 52, "Çaybaşı" },
                    { 711, 52, "İkizce" },
                    { 712, 52, "Kabadüz" },
                    { 713, 52, "Kabataş" },
                    { 714, 53, "Ardeşen" },
                    { 715, 53, "Çamlıhemşin" },
                    { 716, 53, "Çayeli" },
                    { 717, 53, "Fındıklı" },
                    { 718, 53, "İkizdere" },
                    { 719, 53, "Kalkandere" },
                    { 720, 53, "Pazar" },
                    { 721, 53, "Merkez" },
                    { 722, 53, "Güneysu" },
                    { 723, 53, "Derepazarı" },
                    { 724, 53, "Hemşin" },
                    { 725, 53, "İyidere" },
                    { 726, 54, "Akyazı" },
                    { 727, 54, "Geyve" },
                    { 728, 54, "Hendek" },
                    { 729, 54, "Karasu" },
                    { 730, 54, "Kaynarca" },
                    { 731, 54, "Sapanca" },
                    { 732, 54, "Kocaali" },
                    { 733, 54, "Pamukova" },
                    { 734, 54, "Taraklı" },
                    { 735, 54, "Ferizli" },
                    { 736, 54, "Karapürçek" },
                    { 737, 54, "Söğütlü" },
                    { 738, 54, "Adapazarı" },
                    { 739, 54, "Arifiye" },
                    { 740, 54, "Erenler" },
                    { 741, 54, "Serdivan" },
                    { 742, 55, "Alaçam" },
                    { 743, 55, "Bafra" },
                    { 744, 55, "Çarşamba" },
                    { 745, 55, "Havza" },
                    { 746, 55, "Kavak" },
                    { 747, 55, "Ladik" },
                    { 748, 55, "Terme" },
                    { 749, 55, "Vezirköprü" },
                    { 750, 55, "Asarcık" },
                    { 751, 55, "Ondokuzmayıs" },
                    { 752, 55, "Salıpazarı" },
                    { 753, 55, "Tekkeköy" },
                    { 754, 55, "Ayvacık" },
                    { 755, 55, "Yakakent" },
                    { 756, 55, "Atakum" },
                    { 757, 55, "Canik" },
                    { 758, 55, "İlkadım" },
                    { 759, 56, "Baykan" },
                    { 760, 56, "Eruh" },
                    { 761, 56, "Kurtalan" },
                    { 762, 56, "Pervari" },
                    { 763, 56, "Merkez" },
                    { 764, 56, "Şirvan" },
                    { 765, 56, "Tillo" },
                    { 766, 57, "Ayancık" },
                    { 767, 57, "Boyabat" },
                    { 768, 57, "Durağan" },
                    { 769, 57, "Erfelek" },
                    { 770, 57, "Gerze" },
                    { 771, 57, "Merkez" },
                    { 772, 57, "Türkeli" },
                    { 773, 57, "Dikmen" },
                    { 774, 57, "Saraydüzü" },
                    { 775, 58, "Divriği" },
                    { 776, 58, "Gemerek" },
                    { 777, 58, "Gürün" },
                    { 778, 58, "Hafik" },
                    { 779, 58, "İmranlı" },
                    { 780, 58, "Kangal" },
                    { 781, 58, "Koyulhisar" },
                    { 782, 58, "Merkez" },
                    { 783, 58, "Suşehri" },
                    { 784, 58, "Şarkışla" },
                    { 785, 58, "Yıldızeli" },
                    { 786, 58, "Zara" },
                    { 787, 58, "Akıncılar" },
                    { 788, 58, "Altınyayla" },
                    { 789, 58, "Doğanşar" },
                    { 790, 58, "Gölova" },
                    { 791, 58, "Ulaş" },
                    { 792, 59, "Çerkezköy" },
                    { 793, 59, "Çorlu" },
                    { 794, 59, "Ergene" },
                    { 795, 59, "Hayrabolu" },
                    { 796, 59, "Malkara" },
                    { 797, 59, "Muratlı" },
                    { 798, 59, "Saray" },
                    { 799, 59, "Süleymanpaşa" },
                    { 800, 59, "Kapaklı" },
                    { 801, 59, "Şarköy" },
                    { 802, 59, "Marmaraereğlisi" },
                    { 803, 60, "Almus" },
                    { 804, 60, "Artova" },
                    { 805, 60, "Erbaa" },
                    { 806, 60, "Niksar" },
                    { 807, 60, "Reşadiye" },
                    { 808, 60, "Merkez" },
                    { 809, 60, "Turhal" },
                    { 810, 60, "Zile" },
                    { 811, 60, "Pazar" },
                    { 812, 60, "Yeşilyurt" },
                    { 813, 60, "Başçiftlik" },
                    { 814, 60, "Sulusaray" },
                    { 815, 61, "Akçaabat" },
                    { 816, 61, "Araklı" },
                    { 817, 61, "Arsin" },
                    { 818, 61, "Çaykara" },
                    { 819, 61, "Maçka" },
                    { 820, 61, "Of" },
                    { 821, 61, "Ortahisar" },
                    { 822, 61, "Sürmene" },
                    { 823, 61, "Tonya" },
                    { 824, 61, "Vakfıkebir" },
                    { 825, 61, "Yomra" },
                    { 826, 61, "Beşikdüzü" },
                    { 827, 61, "Şalpazarı" },
                    { 828, 61, "Çarşıbaşı" },
                    { 829, 61, "Dernekpazarı" },
                    { 830, 61, "Düzköy" },
                    { 831, 61, "Hayrat" },
                    { 832, 61, "Köprübaşı" },
                    { 833, 62, "Çemişgezek" },
                    { 834, 62, "Hozat" },
                    { 835, 62, "Mazgirt" },
                    { 836, 62, "Nazımiye" },
                    { 837, 62, "Ovacık" },
                    { 838, 62, "Pertek" },
                    { 839, 62, "Pülümür" },
                    { 840, 62, "Merkez" },
                    { 841, 63, "Akçakale" },
                    { 842, 63, "Birecik" },
                    { 843, 63, "Bozova" },
                    { 844, 63, "Ceylanpınar" },
                    { 845, 63, "Eyyübiye" },
                    { 846, 63, "Halfeti" },
                    { 847, 63, "Haliliye" },
                    { 848, 63, "Hilvan" },
                    { 849, 63, "Karaköprü" },
                    { 850, 63, "Siverek" },
                    { 851, 63, "Suruç" },
                    { 852, 63, "Viranşehir" },
                    { 853, 63, "Harran" },
                    { 854, 64, "Banaz" },
                    { 855, 64, "Eşme" },
                    { 856, 64, "Karahallı" },
                    { 857, 64, "Sivaslı" },
                    { 858, 64, "Ulubey" },
                    { 859, 64, "Merkez" },
                    { 860, 65, "Başkale" },
                    { 861, 65, "Çatak" },
                    { 862, 65, "Erciş" },
                    { 863, 65, "Gevaş" },
                    { 864, 65, "Gürpınar" },
                    { 865, 65, "İpekyolu" },
                    { 866, 65, "Muradiye" },
                    { 867, 65, "Özalp" },
                    { 868, 65, "Tuşba" },
                    { 869, 65, "Bahçesaray" },
                    { 870, 65, "Çaldıran" },
                    { 871, 65, "Edremit" },
                    { 872, 65, "Saray" },
                    { 873, 66, "Akdağmadeni" },
                    { 874, 66, "Boğazlıyan" },
                    { 875, 66, "Çayıralan" },
                    { 876, 66, "Çekerek" },
                    { 877, 66, "Sarıkaya" },
                    { 878, 66, "Sorgun" },
                    { 879, 66, "Şefaatli" },
                    { 880, 66, "Yerköy" },
                    { 881, 66, "Merkez" },
                    { 882, 66, "Aydıncık" },
                    { 883, 66, "Çandır" },
                    { 884, 66, "Kadışehri" },
                    { 885, 66, "Saraykent" },
                    { 886, 66, "Yenifakılı" },
                    { 887, 67, "Çaycuma" },
                    { 888, 67, "Devrek" },
                    { 889, 67, "Ereğli" },
                    { 890, 67, "Merkez" },
                    { 891, 67, "Alaplı" },
                    { 892, 67, "Gökçebey" },
                    { 893, 68, "Ağaçören" },
                    { 894, 68, "Eskil" },
                    { 895, 68, "Gülağaç" },
                    { 896, 68, "Güzelyurt" },
                    { 897, 68, "Merkez" },
                    { 898, 68, "Ortaköy" },
                    { 899, 68, "Sarıyahşi" },
                    { 900, 69, "Merkez" },
                    { 901, 69, "Aydıntepe" },
                    { 902, 69, "Demirözü" },
                    { 903, 70, "Ermenek" },
                    { 904, 70, "Merkez" },
                    { 905, 70, "Ayrancı" },
                    { 906, 70, "Kazımkarabekir" },
                    { 907, 70, "Başyayla" },
                    { 908, 70, "Sarıveliler" },
                    { 909, 71, "Delice" },
                    { 910, 71, "Keskin" },
                    { 911, 71, "Merkez" },
                    { 912, 71, "Sulakyurt" },
                    { 913, 71, "Bahşili" },
                    { 914, 71, "Balışeyh" },
                    { 915, 71, "Çelebi" },
                    { 916, 71, "Karakeçili" },
                    { 917, 71, "Yahşihan" },
                    { 918, 72, "Merkez" },
                    { 919, 72, "Beşiri" },
                    { 920, 72, "Gercüş" },
                    { 921, 72, "Kozluk" },
                    { 922, 72, "Sason" },
                    { 923, 72, "Hasankeyf" },
                    { 924, 73, "Beytüşşebap" },
                    { 925, 73, "Cizre" },
                    { 926, 73, "İdil" },
                    { 927, 73, "Silopi" },
                    { 928, 73, "Merkez" },
                    { 929, 73, "Uludere" },
                    { 930, 73, "Güçlükonak" },
                    { 931, 74, "Merkez" },
                    { 932, 74, "Kurucaşile" },
                    { 933, 74, "Ulus" },
                    { 934, 74, "Amasra" },
                    { 935, 75, "Merkez" },
                    { 936, 75, "Çıldır" },
                    { 937, 75, "Göle" },
                    { 938, 75, "Hanak" },
                    { 939, 75, "Posof" },
                    { 940, 75, "Damal" },
                    { 941, 76, "Aralık" },
                    { 942, 76, "Merkez" },
                    { 943, 76, "Tuzluca" },
                    { 944, 76, "Karakoyunlu" },
                    { 945, 77, "Merkez" },
                    { 946, 77, "Altınova" },
                    { 947, 77, "Armutlu" },
                    { 948, 77, "Çınarcık" },
                    { 949, 77, "Çiftlikköy" },
                    { 950, 77, "Termal" },
                    { 951, 78, "Eflani" },
                    { 952, 78, "Eskipazar" },
                    { 953, 78, "Merkez" },
                    { 954, 78, "Ovacık" },
                    { 955, 78, "Safranbolu" },
                    { 956, 78, "Yenice" },
                    { 957, 79, "Merkez" },
                    { 958, 79, "Elbeyli" },
                    { 959, 79, "Musabeyli" },
                    { 960, 79, "Polateli" },
                    { 961, 80, "Bahçe" },
                    { 962, 80, "Kadirli" },
                    { 963, 80, "Merkez" },
                    { 964, 80, "Düziçi" },
                    { 965, 80, "Hasanbeyli" },
                    { 966, 80, "Sumbas" },
                    { 967, 80, "Toprakkale" },
                    { 968, 81, "Akçakoca" },
                    { 969, 81, "Merkez" },
                    { 970, 81, "Yığılca" },
                    { 971, 81, "Cumayeri" },
                    { 972, 81, "Gölyaka" },
                    { 973, 81, "Çilimli" },
                    { 974, 81, "Gümüşova" },
                    { 975, 81, "Kaynaşlı" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "BossId", "CategoryId", "CityId", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "MailAdress", "ModifiedDate", "Name", "PhoneNumber", "TownId", "Url" },
                values: new object[,]
                {
                    { 1, "İnönü Cd. No:53, Aladağ/Adana", 1, 1, 1, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7238), "Lezzetli et ürünleriyle hizmet veren kasap dükkanı.", "kasap.jpg", true, false, true, "info@kasap.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7243), "Özgün Kasap", "1234567890", 1, "www.kasap.com" },
                    { 2, "19 Mayıs Cd. No:72A, Kadıköy/İstanbul", 2, 2, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7260), "Sağlık ürünleri ve ilaçların bulunduğu eczane.", "eczane.jpg", true, false, true, "info@eczane.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7260), "Namık Eczanesi", "1234567890", 432, "www.eczane.com" },
                    { 3, "19 Mayıs Cd. No:150, Kadıköy/İstanbul", 3, 3, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7264), "Kalemlerden defterlere, kırtasiye malzemelerinin satıldığı dükkân.", "kirtasiye.jpg", true, false, true, "info@kirtasiye.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7265), "Ozan Kırtasiyesi", "1234567890", 438, "www.kirtasiye.com" },
                    { 4, "İcadiye Cd. No:5/C, Üsküdar/İstanbul", 4, 4, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7268), "Kıyafet tamiratı ve dikimi yapan terzi dükkânı.", "terzi.jpg", true, false, true, "info@terzi.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7268), "Neşe Terzi", "1234567890", 425, "www.terzi.com" },
                    { 5, "Kültür Mh. No:1/7, Beşiktaş/İstanbul", 5, 5, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7272), "Diş sağlığı hizmetleri sunan dişçi kliniği.", "disci.jpg", true, false, true, "info@disci.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7272), "İtina Dişçi", "1234567890", 425, "www.disci.com" },
                    { 6, "Alibey Mh. No:C2, Silivri / İstanbul", 6, 6, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7275), "Profesyonel hizmetlerle kiralık katil işleri yapan gizli dükkân.", "kiralik-katil.jpg", true, false, true, "info@kiralik-katil.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7276), "Kiralık Katil Bedo", "1234567890", 435, "www.kiralik-katil.com" },
                    { 7, "Ziya Gökalp Sk. No:38, Fatih/İstanbul", 7, 7, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7279), "Fitness ve spor salonu.", "gym.jpg", true, false, true, "info@gym.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7279), "Şişman Gym", "1234567890", 430, "www.gym.com" },
                    { 8, "Arnavutköy. No:29C, Beşiktaş/İstanbul", 8, 8, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7282), "Lezzetli mantı çeşitlerinin servis edildiği mantı dükkânı.", "mantici.jpg", true, false, true, "info@mantici.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7283), "Enfes Mantıcı", "1234567890", 425, "www.mantici.com" },
                    { 9, "Haydarpaşa Garı Yolu. No:59, Kadıköy/İstanbul", 9, 9, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7287), "Futbol oynamak için ideal bir saha.", "futbol-sahasi.jpg", true, false, true, "info@futbol-sahasi.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7288), "Yeşil Futbol Sahası", "1234567890", 432, "www.futbol-sahasi.com" },
                    { 10, "Alemdağ Cd. No:202, Ümraniye/İstanbul", 10, 10, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7291), "Ayakkabı tamir ve bakımı yapan lostra dükkânı.", "lostra.jpg", true, false, true, "info@lostra.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7292), "Dikkat Lostra", "1234567890", 444, "www.lostra.com" },
                    { 11, "Bayramiçli Mehmet Sk. No:16, Üsküdar/İstanbul", 1, 11, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7295), "Sevilen mahalle bakkal amcanız.", "bakkal.jpg", false, false, true, "info@rafik-kasap.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7295), "Rafık Bakkal", "1234567890", 438, "www.rafik-bakkal.com" },
                    { 12, "Tunaboyu Sk. No:3/A, Ümraniye/İstanbul", 2, 12, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7298), "Lezzetli yemekler sunan restoran.", "restoran.jpg", false, false, true, "info@lezzet-restoran.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7298), "Lezzet Restoran", "1234567890", 444, "www.lezzet-restoran.com" },
                    { 13, "Esenyayla Mh. No:23, BALA/Ankara", 3, 13, 6, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7302), "Keyifli bir ortamda kahve ve atıştırmalıklar sunan kafe.", "kafe.jpg", false, false, true, "info@keyifli-kafe.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7302), "Keyifli Kafe", "1234567890", 60, "www.keyifli-kafe.com" },
                    { 14, "Caferağa. No:28b, Kadıköy/İstanbul", 4, 14, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7305), "Moda ve stilin buluştuğu şık butik mağaza.", "butik.jpg", false, false, true, "info@sik-butik.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7306), "Şık Butik", "1234567890", 432, "www.sik-butik.com" },
                    { 15, "1728. Sk. No:34/1, Karşıyaka/İzmir", 5, 15, 35, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7309), "Gözlük ve güneş gözlüğü mağazası.", "optik.jpg", false, false, true, "info@net-optik.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7309), "Net Optik", "1234567890", 470, "www.net-optik.com" },
                    { 16, "Garaj Sk. No:24, 16800 Orhangazi/Bursa", 6, 16, 16, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7312), "Konforlu ve şık mobilyaların satıldığı mağaza.", "mobilya.jpg", false, false, true, "info@rahat-mobilya.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7313), "Rahat Mobilya Mağazası", "1234567890", 200, "www.rahat-mobilya.com" },
                    { 17, "825. Sk. No:17 Korkuteli/Antalya", 7, 17, 7, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7317), "Eğlenceli ve renkli oyuncakların satıldığı oyuncakçı dükkanı.", "oyuncakci.jpg", false, false, true, "info@neseli-oyuncakci.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7317), "Neşeli Oyuncakçı", "1234567890", 90, "www.neseli-oyuncakci.com" },
                    { 18, "Bağdat Cd. No:112/C, Dilovası/Kocaeli", 8, 18, 41, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7321), "Son teknoloji elektronik ürünlerin satıldığı mağaza.", "elektronik.jpg", false, false, true, "info@teknoloji-elektronik.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7321), "Teknoloji Elektronik Mağaza", "1234567890", 560, "www.teknoloji-elektronik.com" },
                    { 19, "Saimbeyli Cd. No:12, Kozan/Adana", 9, 19, 1, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7339), "Canlı ve renkli çiçeklerin satıldığı çiçekçi dükkanı.", "cicekci.jpg", false, false, true, "info@renkli-cicekci.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7340), "Renkli Çiçekçi", "1234567890", 10, "www.renkli-cicekci.com" },
                    { 20, "Topkapı Cd. No:22/A, Ümraniye/İstanbul", 10, 20, 34, new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7342), "Geniş bir kitap koleksiyonuna sahip olan kitapçı.", "kitapci.jpg", false, false, true, "info@bilge-kitapci.com", new DateTime(2023, 8, 29, 20, 26, 0, 427, DateTimeKind.Local).AddTicks(7343), "Bilge Kitapçı", "1234567890", 444, "www.bilge-kitapci.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_SaleMembershipId",
                table: "CartItems",
                column: "SaleMembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_SaleMembershipId",
                table: "OrderItems",
                column: "SaleMembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_BossId",
                table: "Shops",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CategoryId",
                table: "Shops",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CityId",
                table: "Shops",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_TownId",
                table: "Shops",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_CityId",
                table: "Towns",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SaleMemberships");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
