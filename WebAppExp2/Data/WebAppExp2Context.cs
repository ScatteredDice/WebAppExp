using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppExp2.Models
{
    public class WebAppExp2Context : DbContext
    {
        public WebAppExp2Context (DbContextOptions<WebAppExp2Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppExp2.Models.Movie> Movie { get; set; }
    }
}
