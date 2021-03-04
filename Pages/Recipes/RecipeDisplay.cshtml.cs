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
    public class RecipeDisplayModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public RecipeDisplayModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        public Models.Recipes Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

			Recipe =  await _context.Recipe
				.Include(c => c.RecipeIngredients)
				.ThenInclude(c => c.RecipeIngredientName)
				.Include(c => c.RecipeIngredients)
				.ThenInclude(c => c.Unit)
                .Include(c => c.Instruction)
				.FirstOrDefaultAsync(m => m.Id == id)
				;
            //makes Insturction list in order, had to change from ilist to ienumerable, should read up on those.
            Recipe.Instruction = Recipe.Instruction.OrderBy(c => c.Order);

            if (Recipe == null)
            {
                return NotFound();
            }


            return Page();
        }
       
		}
    }

