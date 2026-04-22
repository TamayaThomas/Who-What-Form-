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
    public class IndexModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public IndexModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Source> Source { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Source = await _context.Sources
                .Include(s => s.Film).ToListAsync();
        }
    }
}
