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

    }
}
