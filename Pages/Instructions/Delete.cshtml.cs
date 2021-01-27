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
    public class DeleteModel : PageModel
    {
        private readonly RecipesVersion2.Data.RecipesVersion2Context _context;

        public DeleteModel(RecipesVersion2.Data.RecipesVersion2Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instruction = await _context.Instruction.FindAsync(id);

            if (Instruction != null)
            {
                _context.Instruction.Remove(Instruction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
