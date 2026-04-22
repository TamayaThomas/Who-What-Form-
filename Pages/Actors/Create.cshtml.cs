using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Actors
{
    public class CreateModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public CreateModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "FilmID");
            return Page();
        }

        [BindProperty]
        public Actor Actor { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Actors.Add(Actor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
