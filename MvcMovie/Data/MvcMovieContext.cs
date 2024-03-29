﻿using System;
using MvcMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Data
{
    public class MvcMovieContext: DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {}

        public DbSet<Movie> Movie { get; set; }
    }
}
