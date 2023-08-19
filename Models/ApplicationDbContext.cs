using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ordinario_3.Models;

namespace Ordinario_3
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Propietario>? Propietarios { get; set; } //Mapear modelo con la tabla de la base de datos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propietario>().HasData(
                new Propietario()
                {
                    Id = 1,
                    Nombre = "fer",
                    Apellido="poblete",
                    Direccion = "jiute",
                    CorreoElectronico = "20203tn024@utez.edu.mx",
                    Telefono="7775333958"
                },
                new Propietario()
                {
                    Id = 1,
                    Nombre = "estrella",
                    Apellido="gonzalez",
                    Direccion = "jiute",
                    CorreoElectronico = "20203tn024@utez.edu.mx",
                    Telefono="7775333958"
                }
            );
        }

    }
}