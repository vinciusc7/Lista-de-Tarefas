﻿using Microsoft.EntityFrameworkCore;
using Tarefas.Models;

namespace Tarefas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            this.Database.EnsureCreated();
        }
        public DbSet<TarefasModel> Tarefas { get; set; }

    }
}
