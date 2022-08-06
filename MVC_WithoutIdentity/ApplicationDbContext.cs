using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using MVC_WithoutIdentity;

namespace MVC_WithoutIdentity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<MVC_WithoutIdentity.Good> Good { get; set; }
    }
}
