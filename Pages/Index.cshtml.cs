using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages;

public class IndexModel : PageModel
{
    // Add: Property for database context
    private readonly AppDbContext _context; // Replaces the "db" variable from before
    private readonly ILogger<IndexModel> _logger;
    public List<Film> Films {get; set;} = default!;
    
    public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
    {
        _context = context; // Set database context - this is part 2 of dependency injection
        _logger = logger;        
    }
    public void OnGet() //go to lab 10 pages/products/index to do the onGet
    {
        Films = _context.Films
            .Include(f => f.Actors)
            .Include(f => f.Reviews)
            .Include(f => f.Musics).ToList();//https://danacidm.gitbook.io/cidm-3312/asp.net-core-+-ef-core-simple-modeling/examples/list-all-records-read
    }
}
