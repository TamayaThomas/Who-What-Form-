using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Musics
{
    public class EditModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public EditModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Music Music { get; set; } = default!;
        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music =  await _context.Musics.FirstOrDefaultAsync(m => m.SongID == id);
            if (music == null)
            {
                return NotFound();
            }
            Music = music;
           ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "Title");
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
            var existingMusic = await _context.Musics
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.SongID == Music.SongID);
             if (ImageFile != null)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);

                
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }


                Music.ImageUrl = "/img/" + fileName;
            }
            else
            {
                Music.ImageUrl = existingMusic.ImageUrl;
            }


            _context.Attach(Music).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicExists(Music.SongID))
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

        private bool MusicExists(int id)
        {
            return _context.Musics.Any(e => e.SongID == id);
        }
    }
}
