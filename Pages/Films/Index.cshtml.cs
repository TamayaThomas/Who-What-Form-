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
    public class IndexModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public IndexModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Film = await _context.Films
            .Include(f => f.Reviews)
            .ToListAsync();

             TotalPages = (int)Math.Ceiling(_context.Films.Count() / (double)PageSize);
    
            Film = await _context.Films.Include(s => s.Reviews!)
                .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); 
        }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

    }
}
