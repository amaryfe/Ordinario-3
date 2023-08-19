using System;
using Microsoft.EntityFrameworkCore;
using Ordinario-3.Models;


namespace 
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
            
        }

        public DbSet<Paciente>? Pacientes { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente()
                {
                    Id = 1,
                    Nombre = "Canelo",
                    Especie ="Perro",
                    Raza = "Labrador",
                    Peso = 10,
                    FechaNacimiento = new DateTime()
                },
                new Paciente()
                {
                    Id = 2,
                    Nombre = "Manchas",
                    Especie ="Perro",
                    Raza = "Bulldog",
                    Peso = 12,
                    FechaNacimiento = new DateTime()
                }
            );
        }
    }
}