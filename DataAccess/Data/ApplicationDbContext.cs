﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
}
