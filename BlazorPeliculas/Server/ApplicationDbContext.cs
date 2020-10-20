﻿using BlazorPeliculas.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Server
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GeneroPelicula> GenerosPeliculas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<PeliculaActor> PeliculasActores { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creation of Primary Key
            modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId});
            modelBuilder.Entity<PeliculaActor>().HasKey(x => new { x.PeliculaId, x.PersonaId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
