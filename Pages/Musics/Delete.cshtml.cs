using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Musics
{
    public class DeleteModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public DeleteModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Music Music { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Musics.FirstOrDefaultAsync(m => m.SongID == id);

            if (music is not null)
            {
                Music = music;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Musics.FindAsync(id);
            if (music != null)
            {
                Music = music;
                _context.Musics.Remove(Music);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
