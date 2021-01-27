using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipesVersion2.Models;

namespace RecipesVersion2.Data
{
    public class RecipesVersion2Context : DbContext
    {
        public RecipesVersion2Context (DbContextOptions<RecipesVersion2Context> options)
            : base(options)
        {
        }

        public DbSet<RecipesVersion2.Models.Recipes> Recipe { get; set; }

        public DbSet<RecipesVersion2.Models.Ingredient> Ingredient { get; set; }

        public DbSet<RecipesVersion2.Models.Instruction> Instruction { get; set; }

        public DbSet<RecipesVersion2.Models.RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<RecipesVersion2.Models.Unit> Unit { get; set; }
    }
}
