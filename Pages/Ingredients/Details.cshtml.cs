using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesVersion2.Data;
using RecipesVersion2.Models;

namespace RecipesVersion2.Pages.Ingredients
{
    public class DetailsModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public DetailsModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.FirstOrDefaultAsync(m => m.Id == id);

            if (Ingredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
