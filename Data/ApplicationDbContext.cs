using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NavistarGL.Data;

namespace NavistarGL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NavistarGL.Data.employees> employees { get; set; }
        public DbSet<NavistarGL.Data.departments> departments { get; set; }
        public object Movies { get; internal set; }
    }
}
