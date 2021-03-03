using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesVersion2.Data;
using RecipesVersion2.Models;

namespace RecipesVersion2.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public IndexModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        public IList<Models.Recipes> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe
                .Include(c => c.RecipeIngredients)
                .ThenInclude(c => c.RecipeIngredientName)
                .ToListAsync();

        }

        
    }
}
