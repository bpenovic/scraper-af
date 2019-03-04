﻿using System;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using ScraperLib.Models;

namespace ScraperLib.DAL
{
    public class ScraperDbContext : DbContext
    {
        public ScraperDbContext(DbContextOptions<ScraperDbContext> options)
            : base(options)
        { }

        public DbSet<Marker> Markers { get; set; }
        public DbSet<Quality> Qualities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
