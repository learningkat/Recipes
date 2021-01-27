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
    public class DeleteModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public DeleteModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecipeIngredient = await _context.RecipeIngredients.FindAsync(id);

            if (RecipeIngredient != null)
            {
                _context.RecipeIngredients.Remove(RecipeIngredient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
