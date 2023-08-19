using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Examen.Models;

namespace Examen
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Servicio>? Servicios { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicio>().HasData(
                new Servicio()
                {
                    Id = 1,
                    Nombre = "Aldair",
                    Descripcion="holaaaaaaaa",
                    Costo = 100,
                    RequisitosPrevios = "ejemplo1"
                },
                new Servicio()
                {
                    Id = 2,
                    Nombre = "Fer",
                    Descripcion="holaaaaaaaa",
                    Costo = 200,
                    RequisitosPrevios = "ejemplo2"
                }
            );
        }
    }
}