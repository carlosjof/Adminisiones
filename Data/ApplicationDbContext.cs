using System;
using System.Collections.Generic;
using System.Text;
using Admisiones.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Admisiones.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Sector> Sector { get; set; }

    }
}
