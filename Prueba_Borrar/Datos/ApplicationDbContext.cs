using Microsoft.EntityFrameworkCore;
using Prueba_Borrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Borrar.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
