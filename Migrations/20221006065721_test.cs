using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blockchat.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DOB",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                schema: "Identity",
                table: "AspNetUsers",
                newName: "DOB");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "Identity",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Identity",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
