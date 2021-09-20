using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DENOMVC.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<DENOMVC.Models.Movie> Movie { get; set; }
        public DbSet<DENOMVC.Models.Student> Student { get; set; }
    }
