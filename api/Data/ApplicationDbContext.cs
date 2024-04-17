using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    // public class ApplicationDbContext : IdentityDbContext <AppUser>
    public class ApplicationDbContext 
    { 
        public ApplicationDbContext(DbContextOptions dbContextOptions)
        :base(dbContextOptions)
        {

        }

         public DbSet<Reservas> Reservas {get; set; }

         public DbSet<ReservaImplementos> ReservaImplementos {get; set;} 

         public DbSet<ReservaInstalaciones> ReservaInstalaciones {get; set;}

         public DbSet<ReservaInstalaciones> ReservaInstalaciones {get; set;} 

         public DbSet<Horarios> Horarios {get; set;} 

         public DbSet<Horas> Horas {get; set;}  

         public DbSet<Commentarios> Commentarios {get; set;} 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Reservas>(x => x.Haskey( r => new{ r.AppUserId ,r.ReservaImplementosId ,r.ReservaInstalacionesId}));
            // Aquí se especifica la clave principal de la entidad Reservas. Parece que la clave principal está compuesta por múltiples propiedades: 
            //AppUserId, ReservaImplementosId y ReservaInstalacionesId.
            builder.Entity<Reservas>()
            .HasOne( x => x.AppUser)
            // Esto configura la relación entre la entidad Reservas y la entidad AppUser. Sugiere que existe una relación de uno a muchos entre Reservas 
            // y AppUser, es decir, un usuario puede tener múltiples reservas.
            .WithMany( x => x.Reservas)
            // Indica que la propiedad de navegación Reservas en la entidad AppUser representa la relación inversa, es decir, un usuario puede tener múltiples reservas.
            .HasForeignKey( x => x.ReservaImplementosId) 
            // Aquí se especifica la clave externa en la entidad Reservas que hace referencia a la entidad ReservaImplementos. Esto sugiere que ReservaImplementosId es una 
            // clave externa en la tabla Reservas que apunta a la tabla relacionada ReservaImplementos.
            .HasForeignKey( x => x.ReservaInstalacionesId);

            // LIST<IdentityRole> roles = new LIST<IdentityRole>
            // {
            //     new IdentityRole
            //     {
            //         Name = "Admin",
            //         NormalizedName = "ADMIN"
            //     },
            //      new IdentityRole
            //     {
            //         Name = "User",
            //         NormalizedName = "USER"
            //     },
            // };
            // builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}