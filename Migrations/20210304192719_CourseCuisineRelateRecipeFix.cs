using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesVersion2.Migrations
{
    public partial class CourseCuisineRelateRecipeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Recipe",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuisineId",
                table: "Recipe",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CourseId",
                table: "Recipe",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CuisineId",
                table: "Recipe",
                column: "CuisineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Course_CourseId",
                table: "Recipe",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Cuisine_CuisineId",
                table: "Recipe",
                column: "CuisineId",
                principalTable: "Cuisine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Course_CourseId",
                table: "Recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Cuisine_CuisineId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_CourseId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_CuisineId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CuisineId",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "Course",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cuisine",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
