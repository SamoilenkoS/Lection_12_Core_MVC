using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MVC_WithoutIdentity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Good> Good { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
