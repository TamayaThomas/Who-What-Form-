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
    public class IndexModel : PageModel
    {
        private readonly Who_What_Form_.Models.AppDbContext _context;

        public IndexModel(Who_What_Form_.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Music> Music { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var query = _context.Musics
            .Include(s => s.Film)
            .AsQueryable();
            
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                            query = query.Where(s => s.SongTitle.Contains(CurrentSearch) || s.ArtistName.Contains(CurrentSearch));

            }
            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.ArtistName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.ArtistName);
                    break;
            }
        
            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            Music = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 4;
        public int TotalPages {get; set;}

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;
    }
}
