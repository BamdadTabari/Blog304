using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataProvider.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMobileConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastPasswordChangeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailedLoginCount = table.Column<int>(type: "int", nullable: false),
                    LockoutEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nchar(32)", fixedLength: true, maxLength: 32, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => new { x.RoleId, x.PermissionId, x.Id });
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Claim_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PostCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_PostCategory_PostCategoryId",
                        column: x => x.PostCategoryId,
                        principalTable: "PostCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId, x.Id });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UpdaterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreatedAt", "CreatorId", "IsDeleted", "Name", "Title", "UpdatedAt", "UpdaterId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1005), 0, false, "UserManagement", "مدیریت کاربران", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1015), 0, "identity.users.command" },
                    { 2, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1181), 0, false, "RoleManagement", "مدیریت نقش‌ها", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1184), 0, "identity.roles.command" },
                    { 3, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1235), 0, false, "ClaimManagement", "مدیریت دسترسی ها", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1237), 0, "identity.claims.command" },
                    { 4, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1240), 0, false, "UserView", "نمایش  مدیریت کاربران", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1241), 0, "identity.users.query" },
                    { 5, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1244), 0, false, "RoleView", "نمایش  مدیریت نقش ها", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1245), 0, "identity.roles.query" },
                    { 6, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1250), 0, false, "ClaimView", "نمایش  مدیریت دسترسی ها", new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(1252), 0, "identity.claims.query" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatorId", "IsDeleted", "Title", "UpdatedAt", "UpdaterId" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 1, 12, 1, 445, DateTimeKind.Local).AddTicks(3368), 0, false, "Owner", new DateTime(2024, 11, 15, 1, 12, 1, 445, DateTimeKind.Local).AddTicks(3379), 0 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "CreatorId", "Email", "FailedLoginCount", "IsDeleted", "IsLockedOut", "IsMobileConfirmed", "LastLoginDate", "LastPasswordChangeTime", "LockoutEndTime", "Mobile", "PasswordHash", "SecurityStamp", "State", "UpdatedAt", "UpdaterId", "Username" },
                values: new object[] { 1, "IDAO2OO030RFHZJ4Z0F1URH4R0G0ME88", new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(2306), 0, "bamdadtabari@outlook.com", 0, false, false, false, null, new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(1850), null, "09301724389", "t7xZF0JSKyBZad60EhHt1v2JmweNu4Uohye8URsWLMk=.1QAIjYMkFoeLU8RKeit3WQ==", "OBNCLCNV932KBE3UFPA4Z6OK8I71U8UG", "Active", new DateTime(2024, 11, 15, 1, 12, 1, 471, DateTimeKind.Local).AddTicks(2316), 0, "Illegible_Owner" });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "PermissionId", "RoleId", "CreatedAt", "CreatorId", "IsDeleted", "UpdatedAt", "UpdaterId" },
                values: new object[,]
                {
                    { 0, 1, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(3895), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(3906), 0 },
                    { 0, 2, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4467), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4476), 0 },
                    { 0, 3, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4478), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4480), 0 },
                    { 0, 4, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4481), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4483), 0 },
                    { 0, 5, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4485), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4486), 0 },
                    { 0, 6, 1, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4491), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 472, DateTimeKind.Local).AddTicks(4492), 0 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleId", "UserId", "CreatedAt", "CreatorId", "IsDeleted", "UpdatedAt", "UpdaterId" },
                values: new object[] { 0, 1, 1, new DateTime(2024, 11, 15, 1, 12, 1, 442, DateTimeKind.Local).AddTicks(3119), 0, false, new DateTime(2024, 11, 15, 1, 12, 1, 444, DateTimeKind.Local).AddTicks(6203), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Claim_UserId",
                table: "Claim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_AuthorId",
                table: "Post",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostCategoryId",
                table: "Post",
                column: "PostCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_PermissionId",
                table: "RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
