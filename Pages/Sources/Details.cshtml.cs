using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Sources
{
    public class DetailsModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public DetailsModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public Source Source { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var source = await _context.Sources.FirstOrDefaultAsync(m => m.SourceID == id);

            if (source is not null)
            {
                Source = source;

                return Page();
            }

            return NotFound();
        }
    }
}
