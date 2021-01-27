using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesVersion2.Data;
using RecipesVersion2.Models;

namespace RecipesVersion2.Pages.Instructions
{
    public class DetailsModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public DetailsModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        public Instruction Instruction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instruction = await _context.Instruction.FirstOrDefaultAsync(m => m.Id == id);

            if (Instruction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
