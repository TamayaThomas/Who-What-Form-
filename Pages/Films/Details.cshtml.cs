using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Films
{
    public class DetailsModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public DetailsModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public Film Film { get; set; } = default!;

        [BindProperty]
        public int ReviewIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films.Include(m => m.Reviews).FirstOrDefaultAsync(m => m.FilmID == id);
            if (film == null)
            {
                return NotFound();
            }
            else
            {
                Film = film;
            }
            return Page();
        }

        public IActionResult OnPostDeleteReview(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var review =  _context.Reviews.FirstOrDefault(r => r.ReviewID == ReviewIDToDelete);
            if (review != null)
            {
                _context.Remove(review);
                _context.SaveChanges();
            }

            Film = _context.Films.Include(m => m.Reviews).First(m => m.FilmID == id);
            return Page();
            } 
        }
    }

