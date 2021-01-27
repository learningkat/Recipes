using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesVersion2.Data;
using RecipesVersion2.Models;

namespace RecipesVersion2.Pages.RecipeIngredients
{
    public class DetailsModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public DetailsModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        public RecipeIngredient RecipeIngredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecipeIngredient = await _context.RecipeIngredients.FirstOrDefaultAsync(m => m.Id == id);

            if (RecipeIngredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
