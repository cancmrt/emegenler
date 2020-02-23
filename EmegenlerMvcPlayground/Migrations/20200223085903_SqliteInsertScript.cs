using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace EmegenlerMvcPlayground.Migrations
{
    public partial class SqliteInsertScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations/PolicySql/script.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
