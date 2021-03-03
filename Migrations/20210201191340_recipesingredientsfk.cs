using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesVersion2.Migrations
{
    public partial class recipesingredientsfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipesId",
                table: "RecipeIngredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipesId",
                table: "RecipeIngredients",
                column: "RecipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipe_RecipesId",
                table: "RecipeIngredients",
                column: "RecipesId",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipe_RecipesId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_RecipesId",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "RecipesId",
                table: "RecipeIngredients");
        }
    }
}
