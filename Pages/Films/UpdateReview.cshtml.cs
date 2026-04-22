using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;//need for include
using Who_What_Form_.Models;

namespace Who_What_Form_.Pages_Films;

public class UpdateReviewModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<UpdateReviewModel> _logger;

    [BindProperty]
    public Review Review {get; set;} = default!;
    public SelectList FilmsDropDown {get; set;} = default!;


    public UpdateReviewModel(AppDbContext context, ILogger<UpdateReviewModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult OnGet(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var review = _context.Reviews.Find(id);
        if (review == null)
        {
            return NotFound();
        }
        else
        {
            Review = review;
        }

        FilmsDropDown = new SelectList(_context.Films.ToList(), "MovieID", "Title");
        return Page();
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

        _context.Attach(Review).State = EntityState.Modified;
        _context.SaveChanges();

        return RedirectToPage("./Index");
    }
}