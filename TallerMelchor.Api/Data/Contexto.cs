using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMelchor.Api.Models;

namespace TallerMelchor.Api.Data
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options ) : base (options)
        {
        }

        public DbSet<Marca> Marca { get; set; }

        public DbSet<Color> Color { get; set; }

        public DbSet<Servicio> Servicio { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set;}

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Entrada> Entrada { get; set; }
    }
}
