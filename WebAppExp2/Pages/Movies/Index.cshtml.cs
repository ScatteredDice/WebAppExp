using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppExp2.Models;

namespace WebAppExp2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebAppExp2.Models.WebAppExp2Context _context;

        public IndexModel(WebAppExp2.Models.WebAppExp2Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
