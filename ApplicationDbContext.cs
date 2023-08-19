using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ordinario.Models;

namespace Ordinario
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){
        }

        public DbSet<Cita>? Citas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Cita>().HasData(
                new Cita()
                {
                    Id = 1,
                    MotivoVisita = "Consulta",
                    NombreVeterinario = "Alba L",
                    FechaReservada = new DateTime(),
                    FechaAtencion = new DateTime(),
                    Observaciones = "Perrito sano :)"
                },
                new Cita()
                {
                    Id = 2,
                    MotivoVisita = "Vacunación",
                    NombreVeterinario = "Alba L",
                    FechaReservada = new DateTime(),
                    FechaAtencion = new DateTime(),
                    Observaciones = "Perrito vacunado :)"
                }
            );
         }
    }
}
