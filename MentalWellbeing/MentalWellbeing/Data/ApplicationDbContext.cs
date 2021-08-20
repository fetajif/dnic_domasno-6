using MentalWellbeing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentalWellbeing.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Discussion> Discussions { get; set; }
        public virtual DbSet<Expert> Experts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

    }
}
