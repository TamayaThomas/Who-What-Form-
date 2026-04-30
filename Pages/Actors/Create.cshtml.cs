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
            ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "Title");
            return Page();
        }

        [BindProperty]
        public Actor Actor { get; set; } = default!;
        [BindProperty]
        public IFormFile ImageFile { get; set; }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["FilmID"] = new SelectList(_context.Films, "FilmID", "Title");
                return Page();
            }
            if(ImageFile != null)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }

                Actor.ImageUrl = "/img/" + fileName;
            }

            _context.Actors.Add(Actor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
