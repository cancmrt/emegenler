using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emegenler.Migrations
{
    public partial class emegenlerinitmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmegenlerPolicies",
                columns: table => new
                {
                    PolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    UserIdentifier = table.Column<string>(nullable: true),
                    PolicyElement = table.Column<int>(nullable: false),
                    PolicyElementSelector = table.Column<string>(nullable: true),
                    AuthRole = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerPolicies", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "EmegenlerRoles",
                columns: table => new
                {
                    RoledId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerRoles", x => x.RoledId);
                });

            migrationBuilder.CreateTable(
                name: "EmegenlerUserRoles",
                columns: table => new
                {
                    RoleIdentifierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdentifier = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerUserRoles", x => x.RoleIdentifierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmegenlerPolicies");

            migrationBuilder.DropTable(
                name: "EmegenlerRoles");

            migrationBuilder.DropTable(
                name: "EmegenlerUserRoles");
        }
    }
}
