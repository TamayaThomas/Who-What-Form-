using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Sources
{
    public class EditModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public EditModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Source Source { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var source =  await _context.Sources.FirstOrDefaultAsync(m => m.SourceID == id);
            if (source == null)
            {
                return NotFound();
            }
            Source = source;
           ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "FilmID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Source).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SourceExists(Source.SourceID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SourceExists(int id)
        {
            return _context.Sources.Any(e => e.SourceID == id);
        }
    }
}
