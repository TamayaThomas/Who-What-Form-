using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Films;

public class AddReviewModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<AddReviewModel> _logger;

    [BindProperty]
    public Review Review {get; set;} = default!;

    public SelectList FilmsDropDown {get; set;} = default!;

    public AddReviewModel(AppDbContext context, ILogger<AddReviewModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        FilmsDropDown = new SelectList(_context.Films.ToList(), "MovieID", "Title");
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            var allErrors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var e in allErrors)
            {
                _logger.LogError($"Error: {e.ErrorMessage}");
            }
            return Page();
        }

        _context.Reviews.Add(Review);
        _context.SaveChanges();

        return RedirectToPage("./Index");
    }


}