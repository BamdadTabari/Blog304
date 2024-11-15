using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataProvider.Migrations
{
    /// <inheritdoc />
    public partial class ClearCeatorAndUpdaterId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "PostCategory");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "PostCategory");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "UpdaterId",
                table: "Claim");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 2, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 3, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 4, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9538), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 5, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 6, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 11, 15, 3, 41, 35, 686, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastPasswordChangeTime", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "56D75R3W50114RJ3BPDEM7L55KAZWKR0", new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7111), "DTyAJQblQvN7NCr3jLHipsWuBY8q2Jr0jPFRZmQ+TOA=.H/BsoREiJFsQRumR6J3hvw==", "EHSP1K6CW99ZAIN4I7CRFBRURA8NZEQH", new DateTime(2024, 11, 15, 3, 41, 35, 685, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "Id", "RoleId", "UserId" },
                keyValues: new object[] { 0, 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 3, 41, 35, 657, DateTimeKind.Local).AddTicks(986), new DateTime(2024, 11, 15, 3, 41, 35, 659, DateTimeKind.Local).AddTicks(1416) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "UserRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "PostComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "PostComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "PostCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "PostCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Permission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "Permission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdaterId",
                table: "Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1005), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1015), 0 });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1181), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1184), 0 });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1235), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1237), 0 });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1240), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1241), 0 });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1244), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1245), 0 });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1250), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1252), 0 });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 445, DateTimeKind.Local).AddTicks(3368), 0, new DateTime(2024, 11, 15, 1, 12, 1, 445, DateTimeKind.Local).AddTicks(3379), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 1, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(3895), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(3906), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 2, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4467), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4476), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 3, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4478), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4480), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 4, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4481), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4483), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 5, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4485), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4486), 0 });

            migrationBuilder.UpdateData(
                table: "RolePermission",
                keyColumns: new[] { "Id", "PermissionId", "RoleId" },
                keyValues: new object[] { 0, 6, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4491), 0, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4492), 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "CreatorId", "LastPasswordChangeTime", "PasswordHash", "SecurityStamp", "UpdatedAt", "UpdaterId" },
                values: new object[] { "IDAO2OO030RFHZJ4Z0F1URH4R0G0ME88", new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(2306), 0, new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(1850), "t7xZF0JSKyBZad60EhHt1v2JmweNu4Uohye8URsWLMk=.1QAIjYMkFoeLU8RKeit3WQ==", "OBNCLCNV932KBE3UFPA4Z6OK8I71U8UG", new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(2316), 0 });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "Id", "RoleId", "UserId" },
                keyValues: new object[] { 0, 1, 1 },
                columns: new[] { "CreatedAt", "CreatorId", "UpdatedAt", "UpdaterId" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 12, 1, 442, DateTimeKind.Local).AddTicks(3119), 0, new DateTime(2024, 11, 15, 1, 12, 1, 444, DateTimeKind.Local).AddTicks(6203), 0 });
        }
    }
}
