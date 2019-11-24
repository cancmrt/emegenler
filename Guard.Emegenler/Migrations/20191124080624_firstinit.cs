using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Guard.Emegenler.Migrations
{
    public partial class firstinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Emegenler");

            migrationBuilder.CreateTable(
                name: "EmegenlerPolicies",
                schema: "Emegenler",
                columns: table => new
                {
                    PolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthBase = table.Column<int>(nullable: false),
                    AuthBaseIdentifier = table.Column<string>(nullable: true),
                    PolicyElement = table.Column<string>(nullable: true),
                    PolicyElementIdentifier = table.Column<string>(nullable: true),
                    AccessProtocol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerPolicies", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "EmegenlerRoles",
                schema: "Emegenler",
                columns: table => new
                {
                    RoledId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleIdentifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerRoles", x => x.RoledId);
                });

            migrationBuilder.CreateTable(
                name: "EmegenlerUserRoles",
                schema: "Emegenler",
                columns: table => new
                {
                    RoleIdentifierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIdentifier = table.Column<string>(nullable: true),
                    RoleIdentifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmegenlerUserRoles", x => x.RoleIdentifierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmegenlerPolicies",
                schema: "Emegenler");

            migrationBuilder.DropTable(
                name: "EmegenlerRoles",
                schema: "Emegenler");

            migrationBuilder.DropTable(
                name: "EmegenlerUserRoles",
                schema: "Emegenler");
        }
    }
}
