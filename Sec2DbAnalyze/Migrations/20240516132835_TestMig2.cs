using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sec2DbAnalyze.Migrations
{
    public partial class TestMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Column2 = table.Column<string>(type: "text", nullable: true),
                    Column3 = table.Column<string>(type: "text", nullable: true),
                    Column4 = table.Column<string>(type: "text", nullable: true),
                    Column5 = table.Column<string>(type: "text", nullable: true),
                    Column6 = table.Column<string>(type: "text", nullable: true),
                    Column7 = table.Column<string>(type: "text", nullable: true),
                    Column8 = table.Column<string>(type: "text", nullable: true),
                    Column9 = table.Column<string>(type: "text", nullable: true),
                    Column10 = table.Column<string>(type: "text", nullable: true),
                    Column11 = table.Column<string>(type: "text", nullable: true),
                    Column12 = table.Column<string>(type: "text", nullable: true),
                    Column13 = table.Column<string>(type: "text", nullable: true),
                    Column14 = table.Column<string>(type: "text", nullable: true),
                    Column15 = table.Column<string>(type: "text", nullable: true),
                    Column16 = table.Column<string>(type: "text", nullable: true),
                    Column17 = table.Column<string>(type: "text", nullable: true),
                    Column18 = table.Column<string>(type: "text", nullable: true),
                    Column19 = table.Column<string>(type: "text", nullable: true),
                    Column20 = table.Column<string>(type: "text", nullable: true),
                    Column21 = table.Column<string>(type: "text", nullable: true),
                    Column22 = table.Column<string>(type: "text", nullable: true),
                    Column23 = table.Column<string>(type: "text", nullable: true),
                    Column24 = table.Column<string>(type: "text", nullable: true),
                    Column25 = table.Column<string>(type: "text", nullable: true),
                    Column26 = table.Column<string>(type: "text", nullable: true),
                    Column27 = table.Column<string>(type: "text", nullable: true),
                    Column28 = table.Column<string>(type: "text", nullable: true),
                    Column29 = table.Column<string>(type: "text", nullable: true),
                    Column30 = table.Column<string>(type: "text", nullable: true),
                    Column31 = table.Column<string>(type: "text", nullable: true),
                    Column32 = table.Column<string>(type: "text", nullable: true),
                    Column33 = table.Column<string>(type: "text", nullable: true),
                    Column34 = table.Column<string>(type: "text", nullable: true),
                    Column35 = table.Column<string>(type: "text", nullable: true),
                    Column36 = table.Column<string>(type: "text", nullable: true),
                    Column37 = table.Column<string>(type: "text", nullable: true),
                    Column38 = table.Column<string>(type: "text", nullable: true),
                    Column39 = table.Column<string>(type: "text", nullable: true),
                    Column40 = table.Column<string>(type: "text", nullable: true),
                    Column41 = table.Column<string>(type: "text", nullable: true),
                    Column42 = table.Column<string>(type: "text", nullable: true),
                    Column43 = table.Column<string>(type: "text", nullable: true),
                    Column44 = table.Column<string>(type: "text", nullable: true),
                    Column45 = table.Column<string>(type: "text", nullable: true),
                    Column46 = table.Column<string>(type: "text", nullable: true),
                    Column47 = table.Column<string>(type: "text", nullable: true),
                    Column48 = table.Column<string>(type: "text", nullable: true),
                    Column49 = table.Column<string>(type: "text", nullable: true),
                    Column50 = table.Column<string>(type: "text", nullable: true),
                    Column51 = table.Column<string>(type: "text", nullable: true),
                    Column52 = table.Column<string>(type: "text", nullable: true),
                    Column53 = table.Column<string>(type: "text", nullable: true),
                    Column54 = table.Column<string>(type: "text", nullable: true),
                    Column55 = table.Column<string>(type: "text", nullable: true),
                    Column56 = table.Column<string>(type: "text", nullable: true),
                    Column57 = table.Column<string>(type: "text", nullable: true),
                    Column58 = table.Column<string>(type: "text", nullable: true),
                    Column59 = table.Column<string>(type: "text", nullable: true),
                    Column60 = table.Column<string>(type: "text", nullable: true),
                    Column61 = table.Column<string>(type: "text", nullable: true),
                    Column62 = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentitySections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Column15 = table.Column<string>(type: "text", nullable: true),
                    Column16 = table.Column<string>(type: "text", nullable: true),
                    Column17 = table.Column<string>(type: "text", nullable: true),
                    Column18 = table.Column<string>(type: "text", nullable: true),
                    Column19 = table.Column<string>(type: "text", nullable: true),
                    Column20 = table.Column<string>(type: "text", nullable: true),
                    Column21 = table.Column<string>(type: "text", nullable: true),
                    Column22 = table.Column<string>(type: "text", nullable: true),
                    Column23 = table.Column<string>(type: "text", nullable: true),
                    Column24 = table.Column<string>(type: "text", nullable: true),
                    Column25 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentitySections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    TotalTimeMs = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Column27 = table.Column<string>(type: "text", nullable: true),
                    Column28 = table.Column<string>(type: "text", nullable: true),
                    Column29 = table.Column<string>(type: "text", nullable: true),
                    Column30 = table.Column<string>(type: "text", nullable: true),
                    Column31 = table.Column<string>(type: "text", nullable: true),
                    Column32 = table.Column<string>(type: "text", nullable: true),
                    Column33 = table.Column<string>(type: "text", nullable: true),
                    Column34 = table.Column<string>(type: "text", nullable: true),
                    Column35 = table.Column<string>(type: "text", nullable: true),
                    Column36 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Column15 = table.Column<string>(type: "text", nullable: true),
                    Column16 = table.Column<string>(type: "text", nullable: true),
                    Column17 = table.Column<string>(type: "text", nullable: true),
                    Column18 = table.Column<string>(type: "text", nullable: true),
                    Column19 = table.Column<string>(type: "text", nullable: true),
                    Column20 = table.Column<string>(type: "text", nullable: true),
                    Column21 = table.Column<string>(type: "text", nullable: true),
                    Column22 = table.Column<string>(type: "text", nullable: true),
                    Column23 = table.Column<string>(type: "text", nullable: true),
                    Column24 = table.Column<string>(type: "text", nullable: true),
                    Column25 = table.Column<string>(type: "text", nullable: true),
                    Column26 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Column2 = table.Column<string>(type: "text", nullable: true),
                    Column3 = table.Column<string>(type: "text", nullable: true),
                    Column4 = table.Column<string>(type: "text", nullable: true),
                    Column5 = table.Column<string>(type: "text", nullable: true),
                    Column6 = table.Column<string>(type: "text", nullable: true),
                    Column7 = table.Column<string>(type: "text", nullable: true),
                    Column8 = table.Column<string>(type: "text", nullable: true),
                    Column9 = table.Column<string>(type: "text", nullable: true),
                    Column10 = table.Column<string>(type: "text", nullable: true),
                    Column11 = table.Column<string>(type: "text", nullable: true),
                    Column12 = table.Column<string>(type: "text", nullable: true),
                    Column13 = table.Column<string>(type: "text", nullable: true),
                    Column14 = table.Column<string>(type: "text", nullable: true),
                    Column15 = table.Column<string>(type: "text", nullable: true),
                    Column16 = table.Column<string>(type: "text", nullable: true),
                    Column17 = table.Column<string>(type: "text", nullable: true),
                    Column18 = table.Column<string>(type: "text", nullable: true),
                    Column19 = table.Column<string>(type: "text", nullable: true),
                    Column20 = table.Column<string>(type: "text", nullable: true),
                    Column21 = table.Column<string>(type: "text", nullable: true),
                    Column22 = table.Column<string>(type: "text", nullable: true),
                    Column23 = table.Column<string>(type: "text", nullable: true),
                    Column24 = table.Column<string>(type: "text", nullable: true),
                    Column25 = table.Column<string>(type: "text", nullable: true),
                    Column26 = table.Column<string>(type: "text", nullable: true),
                    Column27 = table.Column<string>(type: "text", nullable: true),
                    Column28 = table.Column<string>(type: "text", nullable: true),
                    Column29 = table.Column<string>(type: "text", nullable: true),
                    Column30 = table.Column<string>(type: "text", nullable: true),
                    Column31 = table.Column<string>(type: "text", nullable: true),
                    Column32 = table.Column<string>(type: "text", nullable: true),
                    Column33 = table.Column<string>(type: "text", nullable: true),
                    Column34 = table.Column<string>(type: "text", nullable: true),
                    Column35 = table.Column<string>(type: "text", nullable: true),
                    Column36 = table.Column<string>(type: "text", nullable: true),
                    Column37 = table.Column<string>(type: "text", nullable: true),
                    Column38 = table.Column<string>(type: "text", nullable: true),
                    Column39 = table.Column<string>(type: "text", nullable: true),
                    Column40 = table.Column<string>(type: "text", nullable: true),
                    Column41 = table.Column<string>(type: "text", nullable: true),
                    Column42 = table.Column<string>(type: "text", nullable: true),
                    Column43 = table.Column<string>(type: "text", nullable: true),
                    Column44 = table.Column<string>(type: "text", nullable: true),
                    Column45 = table.Column<string>(type: "text", nullable: true),
                    Column46 = table.Column<string>(type: "text", nullable: true),
                    Column47 = table.Column<string>(type: "text", nullable: true),
                    Column48 = table.Column<string>(type: "text", nullable: true),
                    Column49 = table.Column<string>(type: "text", nullable: true),
                    Column50 = table.Column<string>(type: "text", nullable: true),
                    Column51 = table.Column<string>(type: "text", nullable: true),
                    Column52 = table.Column<string>(type: "text", nullable: true),
                    Column53 = table.Column<string>(type: "text", nullable: true),
                    Column54 = table.Column<string>(type: "text", nullable: true),
                    Column55 = table.Column<string>(type: "text", nullable: true),
                    Column56 = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MobilePhone = table.Column<string>(type: "text", nullable: true),
                    ApiKey = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserSectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Column2 = table.Column<string>(type: "text", nullable: true),
                    Column3 = table.Column<string>(type: "text", nullable: true),
                    Column4 = table.Column<string>(type: "text", nullable: true),
                    Column5 = table.Column<string>(type: "text", nullable: true),
                    Column6 = table.Column<string>(type: "text", nullable: true),
                    Column7 = table.Column<string>(type: "text", nullable: true),
                    Column8 = table.Column<string>(type: "text", nullable: true),
                    Column9 = table.Column<string>(type: "text", nullable: true),
                    Column10 = table.Column<string>(type: "text", nullable: true),
                    Column11 = table.Column<string>(type: "text", nullable: true),
                    Column12 = table.Column<string>(type: "text", nullable: true),
                    Column13 = table.Column<string>(type: "text", nullable: true),
                    Column14 = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserSections_UserSectionId",
                        column: x => x.UserSectionId,
                        principalTable: "UserSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    IdentitySectionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Column2 = table.Column<string>(type: "text", nullable: true),
                    Column3 = table.Column<string>(type: "text", nullable: true),
                    Column4 = table.Column<string>(type: "text", nullable: true),
                    Column5 = table.Column<string>(type: "text", nullable: true),
                    Column6 = table.Column<string>(type: "text", nullable: true),
                    Column7 = table.Column<string>(type: "text", nullable: true),
                    Column8 = table.Column<string>(type: "text", nullable: true),
                    Column9 = table.Column<string>(type: "text", nullable: true),
                    Column10 = table.Column<string>(type: "text", nullable: true),
                    Column11 = table.Column<string>(type: "text", nullable: true),
                    Column12 = table.Column<string>(type: "text", nullable: true),
                    Column13 = table.Column<string>(type: "text", nullable: true),
                    Column14 = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identities_IdentitySections_IdentitySectionId",
                        column: x => x.IdentitySectionId,
                        principalTable: "IdentitySections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Identities_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Identities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identities_IdentitySectionId",
                table: "Identities",
                column: "IdentitySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Identities_ServiceId",
                table: "Identities",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Identities_UserId",
                table: "Identities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_AccountId",
                table: "Services",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfileId",
                table: "Users",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserSectionId",
                table: "Users",
                column: "UserSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identities");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "IdentitySections");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "UserSections");
        }
    }
}
