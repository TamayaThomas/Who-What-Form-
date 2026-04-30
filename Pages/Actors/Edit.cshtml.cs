using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Actors
{
    public class EditModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public EditModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Actor Actor { get; set; } = default!;
        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor =  await _context.Actors.FirstOrDefaultAsync(m => m.ActorID == id);
            if (actor == null)
            {
                return NotFound();
            }
            Actor = actor;
           ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "Title");
            return Page();
        }

        

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "Title");
                return Page();
            }
            var existingActor = await _context.Actors
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.ActorID == Actor.ActorID);
            if (ImageFile != null)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);

                
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }


                Actor.ImageUrl = "/img/" + fileName;
            }
            else
            {
                Actor.ImageUrl = existingActor.ImageUrl;
            }

           

            _context.Attach(Actor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActorExists(Actor.ActorID))
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

        private bool ActorExists(int id)
        {
            return _context.Actors.Any(e => e.ActorID == id);
        }
    }
}
