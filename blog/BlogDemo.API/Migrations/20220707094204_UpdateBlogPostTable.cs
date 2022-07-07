using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDemo.API.Migrations
{
    public partial class UpdateBlogPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "AuthorAvatar",
                table: "BlogPost");

            migrationBuilder.RenameTable(
                name: "BlogPost",
                newName: "Posts");

            migrationBuilder.RenameColumn(
                name: "Subcategory",
                table: "Posts",
                newName: "SubCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "BlogPost");

            migrationBuilder.RenameColumn(
                name: "SubCategory",
                table: "BlogPost",
                newName: "Subcategory");

            migrationBuilder.AddColumn<string>(
                name: "AuthorAvatar",
                table: "BlogPost",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "BlogPost",
                column: "Id");
        }
    }
}
