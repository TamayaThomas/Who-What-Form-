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

             TotalPages = (int)Math.Ceiling(_context.Films.Count() / (double)PageSize);
    
            
            
            var query = _context.Films
            .Include(s => s.Reviews!)
            .Select(s => s);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                            query = query.Where(s => s.Title.Contains(CurrentSearch) || s.Description.Contains(CurrentSearch));

            }
{
            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.Title);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.Title);
                    break;
            }

            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            Film = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

            
}

            
        }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

    }
}
