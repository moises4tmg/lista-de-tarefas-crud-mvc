using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lista_de_tarefas.Models;

namespace lista_de_tarefas.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}

        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
